using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DadosTableAdapters;

namespace WindowsFormsApp2.Estoque.View
{
    public partial class TelaDeEntradaProduto : Form
    {
        DadosTableAdapters.ProdutoTableAdapter dadosProdutos = new DadosTableAdapters.ProdutoTableAdapter();
        DadosTableAdapters.ItensDeEntradaTableAdapter dadosEntrada = new DadosTableAdapters.ItensDeEntradaTableAdapter();
        int idEntrada;
        public string[,] itensDaLista { get; set; }

        bool tipo;
        public TelaDeEntradaProduto()
        {
            InitializeComponent();
            ultimoId();
            txtBoxQnt.Text = "1";
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblNumEntrada.Text = idEntrada.ToString();
            TxtBoxPesquisaProd.Select();
            btnSalvar.Visible = false;
        }
        public TelaDeEntradaProduto(bool tipo, int idEntrada)
        {
            InitializeComponent();

            this.tipo = tipo;
            this.idEntrada = idEntrada;
            btnEntrar.Enabled = false;
            txtBoxQnt.Enabled = false;
            TxtBoxPesquisaProd.Enabled = false;
            carregarEntrada();
        }

        private void carregarEntrada()
        {
            var aux = dadosEntrada.retornarEntradaPorId(idEntrada);
            lblData.Text = Convert.ToDateTime(aux[0]["dataEntrada"]).ToString("dd/MM/yyyy");
            lblHora.Text = aux[0]["horaEntrada"].ToString().Substring(0,5);
            lblNumEntrada.Text = idEntrada.ToString();
            txtBoxObs.Text = aux[0]["observacoes"].ToString();
            int soma = 0;

            for (int i = 0; i < aux.Count; i++)
            {
                //cod barras, valor de venda, qnt, total
                var aux2 = dadosProdutos.retornarProdutoPorId(Convert.ToInt32(aux[i]["idProduto"]));
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(aux2[0]["prodNome"].ToString());
                item.SubItems.Add(aux2[0]["prodCodBarras"].ToString());
                item.SubItems.Add("R$" + Convert.ToDouble(aux2[0]["prodValor"]).ToString("F2"));
                item.SubItems.Add(aux[i]["qntItem"].ToString());
                item.SubItems.Add("R$"+(Convert.ToInt32(aux[i]["qntItem"]) * Convert.ToDouble(aux2[0]["prodValor"])).ToString("F2"));
                listaDeEntrada.Items.Add(item);
                soma = soma + Convert.ToInt32(aux[i]["qntItem"]);
            }
            lblTotalItens.Text = soma.ToString();
        }

        string pesquisa;
        double total = 0;
        int qnt = 0;
        List<Produto> listaProduto = new List<Produto>();
        private void valida()
        {
            int a;

            if (int.TryParse(txtBoxQnt.Text.Trim(), out a))
            {
                if (Convert.ToInt32(txtBoxQnt.Text) < 1)
                {
                    MessageBox.Show("Não permitida a entrada de valores negativos");
                    txtBoxQnt.Text = "";
                }
                else
                    pesquisaEstoque();
            }
            else
            {
                MessageBox.Show("Número invalido");
            }

        }

        private void ultimoId()
        {
            var aux = dadosEntrada.retornarIdUltimaEntrada();

            if (aux.Count > 0)
            {
                int aux2 = Convert.ToInt32(aux[0]["idSecundarioItensEntrada"]);
                this.idEntrada = aux2 + 1;
            }
            else
                this.idEntrada = 1;

            lblNumEntrada.Text = idEntrada.ToString();
        }
        private void pesquisaEstoque()
        {


            var varPesquisa1 = dadosProdutos.pegarBancoParaEntrar_Sair(pesquisa, pesquisa);
            int aux = 0;
            /*
            if (varPesquisa1.Count > 0)
                aux = Convert.ToInt32(varPesquisa1[0]["prodQuantidade"]);
                */

            if (varPesquisa1.Count < 1 || Convert.ToInt32(varPesquisa1[0]["prodEstado"]) == 1)
                MessageBox.Show("Não existe esse produto no estoque ou este produto está inativo");
            else
            {

                Produto prod = new Produto();
                int qnt = Convert.ToInt32(txtBoxQnt.Text);

                prod.prodNome = varPesquisa1[0]["prodNome"].ToString();
                prod.prodValor = Convert.ToDouble(varPesquisa1[0]["prodValor"]);
                prod.prodCodBarras = varPesquisa1[0]["prodCodBarras"].ToString();
                prod.idProduto = Convert.ToInt32(varPesquisa1[0]["idProduto"]);
                //prod.prodQuantidade = ;

                if (txtBoxQnt.Text == "")
                    prod.prodQuantidade = 1;
                else
                    prod.prodQuantidade = Convert.ToInt32(txtBoxQnt.Text);


                ListViewItem item = new ListViewItem();
                item.SubItems.Add(prod.prodNome);
                item.SubItems.Add(prod.prodCodBarras);
                item.SubItems.Add("R$" + prod.prodValor.ToString("F2"));
                bool permitido = false;
                bool achou = false;


                for (int j = 0; j < listaProduto.Count; j++)
                {
                    if (listaProduto[j].prodNome == prod.prodNome)
                    {
                        achou = true;

                        listaProduto[j].prodQuantidade = qnt + listaProduto[j].prodQuantidade;

                        permitido = true;

                    }
                }
                item.SubItems.Add(qnt.ToString());
                if (listaProduto.Count == 0)
                {
                    prod.prodQuantidade = qnt;
                    listaProduto.Add(prod);
                    achou = true;
                    //item.SubItems.Add("R$" + (qnt * Convert.ToDouble(varPesquisa1[0]["prodValor"])).ToString("F2"));

                    //item.SubItems.Add(prod.idProduto.ToString());

                    listaDeEntrada.Items.Add(item);
                }



                if (!achou)
                {
                    //item.SubItems.Add("R$" + (qnt * Convert.ToDouble(varPesquisa1[0]["prodValor"])).ToString("F2"));

                    //item.SubItems.Add(prod.idProduto.ToString());

                    listaProduto.Add(prod);
                    listaDeEntrada.Items.Add(item);

                }
                if (permitido)
                {
                    total += prod.prodValor * qnt;
                    //item.SubItems.Add("R$" + (qnt * Convert.ToDouble(varPesquisa1[0]["prodValor"])).ToString("F2"));

                    //item.SubItems.Add(prod.idProduto.ToString());

                    listaDeEntrada.Items.Add(item);
                }
                item.SubItems.Add("R$" + (qnt * Convert.ToDouble(varPesquisa1[0]["prodValor"])).ToString("F2"));
                item.SubItems.Add(prod.idProduto.ToString());


            }
            txtBoxQnt.Text = "1";
            TxtBoxPesquisaProd.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxPesquisaProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int a;
                if (int.TryParse(txtBoxQnt.Text.Trim(), out a))
                {
                    this.pesquisa = TxtBoxPesquisaProd.Text;
                    valida();
                }
                else
                {
                    MessageBox.Show("Valor incorreto inserido na quantidade");
                }

            }
            TxtBoxPesquisaProd.Select();

        }

        private void txtBoxQnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisa = TxtBoxPesquisaProd.Text;
                valida();
                TxtBoxPesquisaProd.Select();

            }
            else
                txtBoxQnt.Select();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (listaDeEntrada.Items.Count > 0)
            {
                for (int i = 0; i < listaDeEntrada.Items.Count; i++)
                {
                    string auxObs;
                    int aux = Convert.ToInt32(listaDeEntrada.Items[i].SubItems[4].Text);
                    MessageBox.Show(listaDeEntrada.Items[i].SubItems[4].Text);
                    var aux2 = dadosProdutos.PegaQuantidade(Convert.ToInt32(listaDeEntrada.Items[i].SubItems[6].Text));
                    aux += Convert.ToInt32(aux2[0]["prodQuantidade"]);
                    dadosProdutos.AttQuantidade(aux, Convert.ToInt32(listaDeEntrada.Items[i].SubItems[6].Text));
                    if (txtBoxObs.Text.Length < 300)
                    {
                        auxObs = txtBoxObs.Text;
                    }
                    else
                    {
                        MessageBox.Show("O limite de caracteres no campo observação é maior de 300, será cortado o restante");
                        auxObs = txtBoxObs.Text.Substring(0, 299);
                    }

                    dadosEntrada.inserirItensEntrada( idEntrada ,Convert.ToInt32(listaDeEntrada.Items[i].SubItems[4].Text), DateTime.Now.ToString("dd/MM/yyyy")
                    , DateTime.Now.ToString("HH:mm")
                    , Convert.ToInt32(listaDeEntrada.Items[i].SubItems[6].Text), txtBoxObs.Text, 1);
                }
                MessageBox.Show("Produtos inserido com sucesso!");
                Close();
            }
            else
                MessageBox.Show("Não tem nenhum item para ser adicionado");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listaDeEntrada.Items.Clear();
            listaProduto.Clear();
            TxtBoxPesquisaProd.Select();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string auxObs;
            if (txtBoxObs.Text.Length < 300)
            {
                auxObs = txtBoxObs.Text;
                dadosEntrada.attObs(auxObs, idEntrada);
            }
            else
            {
                MessageBox.Show("O limite de caracteres no campo observação é maior de 300, será cortado o restante");
                auxObs = txtBoxObs.Text.Substring(0, 299);
                dadosEntrada.attObs(auxObs, idEntrada);
            }
            Close();
        }
    }
}
