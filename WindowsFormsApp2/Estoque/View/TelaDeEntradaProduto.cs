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
        public TelaDeEntradaProduto()
        {
            InitializeComponent();
            ultimoId();
            txtBoxQnt.Text = "1";
            lblData2.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblNumEntrada.Text = idEntrada.ToString();
            TxtBoxPesquisaProd.Select();

        }


        string pesquisa;
        double total = 0;
        int qnt = 0;
        public string[,] itensDaLista { get; set; }
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
                int aux2 = Convert.ToInt32(aux[0]["idItensEntrada"]);
                this.idEntrada = aux2 + 1;
            }
            else
                this.idEntrada = 1;

            lblNumEntrada.Text = idEntrada.ToString();
        }
    private void pesquisaEstoque()
    {


        var varPesquisa1 = dadosProdutos.pegarBancoParaEntrada(pesquisa, pesquisa);
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
                listaDeEntrada.Items.Add(item);
            }



            if (!achou)
            {
                listaProduto.Add(prod);
                listaDeEntrada.Items.Add(item);

            }
            if (permitido)
            {
                total += prod.prodValor * qnt;
                //item.SubItems.Add("R$ " + (prod.prodValor * qnt).ToString("F2"));
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
            for (int i = 0; i < listaProduto.Count; i++)
            {
                int aux = listaProduto[i].prodQuantidade;
                var aux2 = dadosProdutos.PegaQuantidade(listaProduto[i].idProduto);
                aux += Convert.ToInt32(aux2[0]["prodQuantidade"]);
                dadosProdutos.AttQuantidade(aux, listaProduto[i].idProduto);
                if (txtBoxObs.Text.Length > 299)
                    MessageBox.Show("O limite de caracteres no campo observação é maior de 300, será cortado o restante");
                
                    dadosEntrada.inserirItensEntrada(idEntrada, listaProduto[i].prodQuantidade, DateTime.Now
                , listaProduto[i].idProduto, txtBoxObs.Text, 1);
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
}
}
