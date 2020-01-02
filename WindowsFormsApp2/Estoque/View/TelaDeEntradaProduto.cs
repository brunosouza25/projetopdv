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
        public TelaDeEntradaProduto()
        {
            InitializeComponent();
            ultimoId();
        }


        int idEntrada;
        string pesquisa;
        double total = 0;
        int qnt = 0;
        public string[,] itensDaLista { get; set; }
        List<Produto> listaProduto = new List<Produto>();

        private void ultimoId()
        {
            var aux = dadosEntrada.retornarIdUltimaEntrada();
            if (aux.Count < 1)
                this.idEntrada = 1;
            else
                this.idEntrada = Convert.ToInt32(aux[0]["idItensEntrada"])+1;

            lblNumEntrada.Text = idEntrada.ToString();

        }
        private void pesquisaEstoque()
        {

            
            var varPesquisa1 = dadosProdutos.pegarBanco(pesquisa, pesquisa);
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

                if (listaProduto.Count == 0)
                {
                    //prod.prodQuantidade = 0;
                    listaProduto.Add(prod);
                }

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



                if (!achou)
                    listaProduto.Add(prod);

                if (permitido)
                {
                    total += prod.prodValor * qnt;
                     //item.SubItems.Add("R$ " + (prod.prodValor * qnt).ToString("F2"));
                    listaDeEntrada.Items.Add(item);
                }
                item.SubItems.Add(prod.idProduto.ToString());

            }
            txtBoxQnt.Text = "1";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxPesquisaProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisaEstoque();
            }
        }
    }
}
