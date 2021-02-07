using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp2.Vendas.View;
namespace WindowsFormsApp2
{
    public partial class TelaDoPdv : UserControl
    {
        public TelaDoPdv()
        {
            InitializeComponent();
            BtnFinalizarVenda.Enabled = false;
            txtBoxQnt.Enabled = false;
            Bt_Add_Prod.Enabled = false;
            Bt_Remover_Prod.Enabled = false;
            Bt_Cancelar_Venda.Enabled = false;
            TxtBoxPesquisaProd.Enabled = false;
            btnSangria.Enabled = false;
            txtBoxQnt.Text = "1";
            var idCaixa = caixa.pegarIDUltimoCaixa();
            var aux = caixa.pegarCaixaPorID(Convert.ToInt32(idCaixa[0]["idCaixa"]));
            if (Convert.ToByte(aux[0]["estadoCaixa"]) == 1)
            {
                btnFecharCaixa.Visible = true;
                btnAbrirCaixa.Visible = false;
                lblCaixa.Text = "Fechar Caixa";
            }
            else
            {
                btnFecharCaixa.Visible = false;
                btnAbrirCaixa.Visible = true;
                lblCaixa.Text = "Abrir Caixa";
            }
            if (Global.sangria == false)
            {
                btnSangria.Visible = false;
            }
            if (Global.lancarVendas == false)
            {
                BtnFinalizarVenda.Visible = false;
            }

        }
        DadosTableAdapters.CaixaTableAdapter caixa = new DadosTableAdapters.CaixaTableAdapter();
        DadosTableAdapters.ProdutoTableAdapter dadosProdutos = new DadosTableAdapters.ProdutoTableAdapter();


        string pesquisa;
        double total = 0;
        int qnt = 0;
        public string[,] itensDaLista { get; set; }
        List<Produto> listaProduto = new List<Produto>();

        //FUNÇÃO PARA ALTERNAR ABRIR E FECHAR CAIXA
        public void travarBotoes()
        {
            var idCaixa = caixa.pegarIDUltimoCaixa();
            var aux = caixa.pegarCaixaPorID(Convert.ToInt32(idCaixa[0]["idCaixa"]));


            if (btnFecharCaixa.Visible)
            {
                //var idCaixa = caixa.pegarIDUltimoCaixa();
                //var aux = caixa.pegarCaixaPorID(Convert.ToInt32(idCaixa[0]["idCaixa"]));

                caixa.fecharCaixa(Convert.ToDouble(aux[0]["valorAtual"]), Convert.ToByte(0), Convert.ToInt32(aux[0]["idCaixa"]));
                MessageBox.Show("Caixa fechado com Sucesso");
                btnFecharCaixa.Visible = false;
                btnAbrirCaixa.Visible = true;
                lblCaixa.Text = "Abrir Caixa";
                listaCaixa.Items.Clear();
                txtBoxQnt.Enabled = false;
                BtnFinalizarVenda.Enabled = false;
                Bt_Add_Prod.Enabled = false;
                Bt_Cancelar_Venda.Enabled = false;
                Bt_Remover_Prod.Enabled = false;
                TxtBoxPesquisaProd.Enabled = false;
                btnSangria.Enabled = false;
            }
            else
            {

                /*var saldoAnterior = caixa.pegarCaixaPorID(Convert.ToInt32(idCaixa[0]["idCaixa"]));
                caixa.inserirCaixa(Convert.ToDouble(saldoAnterior[0]["fechamentoCaixa"]), 0, Convert.ToDouble(saldoAnterior[0]["fechamentoCaixa"]), DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff"), 1);
                MessageBox.Show("Caixa aberto com sucesso");*/
                btnFecharCaixa.Visible = true;
                btnAbrirCaixa.Visible = false;
                lblCaixa.Text = "Fechar Caixa";
                /*MessageBox.Show("Caixa aberto com: R$" + saldoAnterior[0]["fechamentoCaixa"]);
                */
                txtBoxQnt.Enabled = true;
                BtnFinalizarVenda.Enabled = true;
                Bt_Add_Prod.Enabled = true;
                Bt_Cancelar_Venda.Enabled = true;
                Bt_Remover_Prod.Enabled = true;
                TxtBoxPesquisaProd.Enabled = true;
                btnSangria.Enabled = true;
            }
            TxtBoxPesquisaProd.Select();
        }
        //FUNÇÃO PARA FAZER PESQUISA NO BANCO QUANDO DIGITADO NO TXTBOX
        private void pesquisaListaCaixa()
        {
            try
            {
                var varPesquisa1 = dadosProdutos.pegarBanco(pesquisa, pesquisa);
                int aux = 0;
                if (varPesquisa1.Count > 0)
                    aux = Convert.ToInt32(varPesquisa1[0]["prodQuantidade"]);


                if (varPesquisa1.Count < 1 || Convert.ToInt32(varPesquisa1[0]["prodEstado"]) == 1 || Convert.ToInt32(txtBoxQnt.Text) > aux)
                    MessageBox.Show("Não existe esse produto no estoque ou este produto está inativo ou a quantidade inserida é maior do que contem no estoque");
                else
                {

                    Produto prod = new Produto();
                    prod.prodNome = varPesquisa1[0]["prodNome"].ToString();
                    prod.prodValor = Convert.ToDouble(varPesquisa1[0]["prodValor"]);
                    prod.prodCodBarras = varPesquisa1[0]["prodCodBarras"].ToString();
                    prod.idProduto = Convert.ToInt32(varPesquisa1[0]["idProduto"]);

                    int qnt = Convert.ToInt32(txtBoxQnt.Text);
                    /*if (txtBoxQnt.Text == "")
                        prod.prodQuantidade = 1;
                    else
                        prod.prodQuantidade = Convert.ToInt32(txtBoxQnt.Text);
                        */
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(prod.prodNome);
                    item.SubItems.Add(prod.prodCodBarras);
                    item.SubItems.Add(prod.prodValor.ToString());
                    bool permitido = false;
                    bool achou = false;


                    /* if (listaProduto.Count == 0)
                     {
                         //prod.prodQuantidade = 0;
                         listaProduto.Add(prod);
                         permitido = true;
                     }
                     else
                     {*/

                    for (int j = 0; j < listaProduto.Count; j++)
                    {
                        if (listaProduto[j].prodNome == prod.prodNome)
                        {
                            achou = true;
                            if (aux + 1 > listaProduto[j].prodQuantidade + qnt)
                            {
                                listaProduto[j].prodQuantidade = qnt + listaProduto[j].prodQuantidade;
                                permitido = true;
                            }
                            else
                            {
                                MessageBox.Show("Não tem mais deste produto suficiente no estoque para ser adicionado a venda");
                            }
                        }
                    }
                    //}
                    item.SubItems.Add(qnt.ToString());



                    if (!achou)
                    {
                        prod.prodQuantidade = 1;
                        listaProduto.Add(prod);
                        permitido = true;
                    }
                    if (permitido)
                    {
                        total += prod.prodValor * qnt;
                        item.SubItems.Add("R$ " + (prod.prodValor * qnt).ToString("F2"));
                        LblTotal.Text = "R$: " + total.ToString("F2");
                        listaCaixa.Items.Add(item);
                    }

                    //=======================================================================================
                    /*permitido = false;
                    achou = false;
                    for (int j = 0; j < listaProduto.Count; j++)
                    {
                        if (listaProduto[j].prodNome == prod.prodNome)
                        {
                            aux = Convert.ToInt32(varPesquisa1[0]["prodQuantidade"]);

                            if (listaProduto[j].prodQuantidade < aux)
                            {
                                listaProduto[j].prodQuantidade += 1;
                                achou = true;
                                permitido = true;

                            }
                            else
                            {
                                MessageBox.Show("Não tem mais esse item em estoque para ser adicionado a venda");
                                permitido = false;
                                achou = true;
                            }
                        }
                    }
                    if (!achou)
                    {
                        prod.prodQuantidade = 1;
                        listaProduto.Add(prod);
                        permitido = true;
                    }
                    if (permitido)
                    {
                        total += prod.prodValor * qnt;
                        item.SubItems.Add("R$ " + (prod.prodValor * qnt).ToString("F2"));
                        LblTotal.Text = "R$: " + total.ToString("F2");
                        listaCaixa.Items.Add(item);
                    }/***/
                    //========================================================================================
                    item.SubItems.Add(prod.idProduto.ToString());

                }
                TxtBoxPesquisaProd.Text = "";
                txtBoxQnt.Text = "1";
            }catch(IOException er)
            {
                MessageBox.Show("Tivemos um erro, favor consultar o suporte. Código do erro: (venda 1)");
            }
        }

        private void listaDoCaixa_Load(object sender, EventArgs e)
        {
            TxtBoxPesquisaProd.Select();
        }

        private void cancelarVenda()
        {
            if (MessageBox.Show("Tem certeza?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listaCaixa.Items.Clear();
                LblTotal.Text = "R$: 0,00";
                total = 0;
                listaProduto.Clear();
            }
            TxtBoxPesquisaProd.Select();
        }

        private void Bt_Cancelar_Venda_Click(object sender, EventArgs e)
        {
            cancelarVenda();
        }

        private void Bt_Add_Prod_Click(object sender, EventArgs e)
        {
            pesquisa = TxtBoxPesquisaProd.Text;
            pesquisaListaCaixa();
            //TxtBoxPesquisaProd.Select();
        }

        private void Bt_Remover_Prod_Click(object sender, EventArgs e)
        {
            if (listaCaixa.SelectedItems.Count > 0)
                for (int i = listaCaixa.SelectedItems.Count; i >= 1; i--)
                {
                    ListViewItem item = new ListViewItem();
                    item = listaCaixa.SelectedItems[i - 1];
                    for (int j = 0; j < listaProduto.Count; j++)
                    {
                        if (listaProduto[j].prodNome == listaCaixa.SelectedItems[i - 1].SubItems[1].Text)
                        {
                            listaProduto[j].prodQuantidade -= 1;
                        }
                    }
                    listaCaixa.Items.Remove(listaCaixa.SelectedItems[i - 1]);
                    total -= Convert.ToDouble(item.SubItems[3].Text) * Convert.ToDouble(item.SubItems[4].Text);
                    LblTotal.Text = "R$: " + total.ToString("F2");

                }
            else
                MessageBox.Show("Não tem nenhum item selecionado!");
            TxtBoxPesquisaProd.Select();
        }

        private void BtnFinalizarVenda_Click_1(object sender, EventArgs e)
        {
            DadosTableAdapters.Config_SistemaTableAdapter config = new DadosTableAdapters.Config_SistemaTableAdapter();
            var auxFiscal = config.retornarConfig();
            bool fiscal = Convert.ToBoolean(auxFiscal[0]["fiscal"]);
            // try
            //{
            if (fiscal)
            {
                if (listaCaixa.Items.Count > 0)
                {
                    if (total > 0)
                    {
                        itensDaLista = new string[this.listaCaixa.Items.Count, 7];
                        for (int i = 0; i < this.listaCaixa.Items.Count; i++)
                        {
                            for (int j = 0; j <= 6; j++)
                            {
                                itensDaLista[i, j] = listaCaixa.Items[i].SubItems[j].Text;
                            }
                        }
                        TelaDePagamento telaDePagamento = new TelaDePagamento(itensDaLista, total);
                        telaDePagamento.ShowDialog();
                        listaProduto.Clear();
                        listaCaixa.Items.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Não tem itens na venda");
                }
                total = 0;
                LblTotal.Text = "";
                TxtBoxPesquisaProd.Select();
            }
            else
            {
                MessageBox.Show("Favor preencher todos os dados fiscais da empresa");
            }
            //}
            /*catch(IOExeption er)
            {
                MessageBox.Show("Temos um erro aqui");
            }
            }*/
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            TelaEntradaDeCaixa telaEntradaDeCaixa = new TelaEntradaDeCaixa();
            telaEntradaDeCaixa.ShowDialog();
            var idCaixa = caixa.pegarIDUltimoCaixa();
            var liberar = caixa.pegarCaixaPorID(Convert.ToInt32(idCaixa[0]["idCaixa"]));
            if (Convert.ToByte(liberar[0]["estadoCaixa"]) == 1)
            {
                travarBotoes();

            }
            else
            {
                MessageBox.Show("Favor, inserir valor para abrir o caixa");
            }
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            travarBotoes();
            listaCaixa.Items.Clear();
            LblTotal.Text = "R$: 0,00";
            total = 0;
            listaProduto.Clear();
            TxtBoxPesquisaProd.Select();
        }

        private void btnSangria_Click(object sender, EventArgs e)
        {
            TelaDeSangria sangria = new TelaDeSangria();
            sangria.ShowDialog();
            TxtBoxPesquisaProd.Select();
        }

        private void TxtBoxPesquisaProd_KeyDown_1(object sender, KeyEventArgs e)
        {
            pesquisa = TxtBoxPesquisaProd.Text;
            pesquisaListaCaixa();
            TxtBoxPesquisaProd.Select();
        }

        private void txtBoxQnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisa = TxtBoxPesquisaProd.Text;
                pesquisaListaCaixa();
            }
            txtBoxQnt.Select();
        }

        private void TxtBoxPesquisaProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisa = TxtBoxPesquisaProd.Text;
                pesquisaListaCaixa();
            }
            TxtBoxPesquisaProd.Select();
        }
    }
}

