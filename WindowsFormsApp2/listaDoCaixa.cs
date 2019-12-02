using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class listaDoCaixa : UserControl
    {
        public listaDoCaixa()
        {
            InitializeComponent();
            BtnFinalizarVenda.Enabled = false;
            Bt_Add_Prod.Enabled = false;
            Bt_Remover_Prod.Enabled = false;
            Bt_Cancelar_Venda.Enabled = false;
            TxtBoxPesquisaProd.Enabled = false;
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
        }
        DadosTableAdapters.CaixaTableAdapter caixa = new DadosTableAdapters.CaixaTableAdapter();
        DadosTableAdapters.ProdutoTableAdapter dadosProdutos = new DadosTableAdapters.ProdutoTableAdapter();
        Produto prod = new Produto();
        List<Produto> produtos = new List<Produto>();


        string pesquisa;
        double total = 0;
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

                BtnFinalizarVenda.Enabled = false;
                Bt_Add_Prod.Enabled = false;
                Bt_Cancelar_Venda.Enabled = false;
                Bt_Remover_Prod.Enabled = false;
                TxtBoxPesquisaProd.Enabled = false;
            }
            else
            {
                
                var saldoAnterior = caixa.pegarCaixaPorID(Convert.ToInt32(idCaixa[0]["idCaixa"]));
                caixa.inserirCaixa(Convert.ToDouble(saldoAnterior[0]["fechamentoCaixa"]), 0, Convert.ToDouble(saldoAnterior[0]["fechamentoCaixa"]), DateTime.Now.ToString("dd/MM/yyy"), 1);
                MessageBox.Show("Caixa aberto com sucesso");
                btnFecharCaixa.Visible = true;
                btnAbrirCaixa.Visible = false;
                lblCaixa.Text = "Fechar Caixa";
                MessageBox.Show("Caixa aberto com: R$" + saldoAnterior[0]["fechamentoCaixa"]);

                BtnFinalizarVenda.Enabled = true;
                Bt_Add_Prod.Enabled = true;
                Bt_Cancelar_Venda.Enabled = true;
                Bt_Remover_Prod.Enabled = true;
                TxtBoxPesquisaProd.Enabled = true;
            }
            TxtBoxPesquisaProd.Select();
        }
        //FUNÇÃO PARA FAZER PESQUISA NO BANCO QUANDO DIGITADO NO TXTBOX
        private void pesquisaListaCaixa()
        {
            var varPesquisa1 = dadosProdutos.pegarBanco(pesquisa, pesquisa);
            if (varPesquisa1.Count < 1 || Convert.ToInt32(varPesquisa1[0]["prodEstado"]) == 1)
                MessageBox.Show("Não existe esse produto no estoque ou este produto está inativo");
            else
            {
                Produto prod = new Produto();
                prod.prodNome = varPesquisa1[0]["prodNome"].ToString();
                prod.prodValor = Convert.ToDouble(varPesquisa1[0]["prodValor"]);
                prod.prodCodBarras = varPesquisa1[0]["prodCodBarras"].ToString();
                prod.idProduto = Convert.ToInt32(varPesquisa1[0]["idProduto"]);

                ListViewItem item = new ListViewItem();
                item.SubItems.Add(prod.prodNome);
                item.SubItems.Add(prod.prodCodBarras);
                item.SubItems.Add(prod.prodValor.ToString());
                item.SubItems.Add(prod.idProduto.ToString());

                bool permitido = false;
                bool achou = false;
                for (int j = 0; j < listaProduto.Count; j++)
                {
                    if (listaProduto[j].prodNome == prod.prodNome)
                    {
                        int aux = Convert.ToInt32(varPesquisa1[0]["prodQuantidade"]);

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
                    total += prod.prodValor;
                    LblTotal.Text = "R$: " + total.ToString("F2");
                    listaCaixa.Items.Add(item);
                }
            }
            TxtBoxPesquisaProd.Text = "";
        }

        private void listaDoCaixa_Load(object sender, EventArgs e)
        {
            TxtBoxPesquisaProd.Select();
        }

        private void TxtBoxPesquisaProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisa = TxtBoxPesquisaProd.Text;
                pesquisaListaCaixa();
            }
        }

        private void Bt_Cancelar_Venda_Click(object sender, EventArgs e)
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

        private void Bt_Add_Prod_Click(object sender, EventArgs e)
        {
            pesquisa = TxtBoxPesquisaProd.Text;
            pesquisaListaCaixa();
            TxtBoxPesquisaProd.Select();
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
                    total -= Convert.ToDouble(item.SubItems[3].Text);
                    LblTotal.Text = "R$: " + total.ToString("F2");

                }
            else
                MessageBox.Show("Não tem nenhum item selecionado!");
            TxtBoxPesquisaProd.Select();
        }

        private void BtnFinalizarVenda_Click_1(object sender, EventArgs e)
        {
            if (listaCaixa.Items.Count > 0)
            {
                if (total > 0)
                {
                    itensDaLista = new string[this.listaCaixa.Items.Count, 5];
                    for (int i = 0; i < this.listaCaixa.Items.Count; i++)
                    {
                        for (int j = 0; j <= 4; j++)
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

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            travarBotoes();
        }

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            travarBotoes();
        }

        private void btnSangria_Click(object sender, EventArgs e)
        {
            TelaDeSangria sangria = new TelaDeSangria();
            sangria.ShowDialog();
            TxtBoxPesquisaProd.Select();
        }
    }
}
