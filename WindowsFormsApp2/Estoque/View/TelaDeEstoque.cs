using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class TelaDeEstoque : UserControl
    {
        public TelaDeEstoque()
        {
            InitializeComponent();
        }

        DadosTableAdapters.ProdutoTableAdapter dadosProdutos = new DadosTableAdapters.ProdutoTableAdapter();

        //CARREGA A LISTVIEW COM OS PRODUTOS NO BANCO
        public void carregarListaEstoque()
        {
            Produto prod = new Produto();
            listaProdutos.Items.Clear();
            var varProd = dadosProdutos.GetData();

            for (int i = 0; i < varProd.Count; i++)
            {
                prod.idProduto = Convert.ToInt32(varProd[i]["idProduto"]);

                prod.prodNome = varProd[i]["prodNome"].ToString();
                prod.prodCusto = Convert.ToDouble(varProd[i]["prodCusto"]);
                prod.prodValor = Convert.ToDouble(varProd[i]["prodValor"]);
                prod.prodQuantidade = Convert.ToInt32(varProd[i]["prodQuantidade"]);
                prod.prodCodBarras = varProd[i]["prodCodBarras"].ToString();
                prod.prodEstado = Convert.ToBoolean(varProd[i]["prodEstado"]);

                ListViewItem item = new ListViewItem();


                item.SubItems.Add(prod.prodNome);
                item.SubItems.Add("R$"+prod.prodCusto.ToString("F2"));
                item.SubItems.Add("R$"+prod.prodValor.ToString("F2"));
                item.SubItems.Add(prod.prodCodBarras);
                item.SubItems.Add(prod.prodQuantidade.ToString());
                item.SubItems.Add(prod.idProduto.ToString());

                if (!prod.prodEstado)
                {
                    item.SubItems.Add("Ativo");
                }
                else
                {
                    item.SubItems.Add("Inativo");
                    item.BackColor = System.Drawing.Color.Gray;

                }
                listaProdutos.Items.Add(item);


            }
        }

        Produto produtos = new Produto();
        private void Bt_Criar_Prod_Click(object sender, EventArgs e)
        {
                TelaCriarProd telaCriar = new TelaCriarProd(true);
                telaCriar.ShowDialog();
                carregarListaEstoque();
        }

        //função para ler os arquivos e colocar na listview
        private void TelaDeEstoque_Load(object sender, EventArgs e)
        {
            carregarListaEstoque();
        }

        private void Bt_Entrar_Prod_Click(object sender, EventArgs e)
        {
            if (listaProdutos.SelectedItems.Count > 0)
            {
                if (listaProdutos.SelectedItems[0].SubItems[7].Text == "Ativo")
                {

                    TelaEntrarProd telaEntrar = new TelaEntrarProd(Convert.ToInt32(listaProdutos.SelectedItems[0].SubItems[6].Text), true);
                    telaEntrar.ShowDialog();
                    carregarListaEstoque();
                }
                else
                {
                    MessageBox.Show("Este produto está inativo");
                }
            }
            else
            {
                MessageBox.Show("Não foi selecionado nenhum produto");
            }
        }

        private void Bt_Retirar_Prod_Click(object sender, EventArgs e)
        {
            if (listaProdutos.SelectedItems.Count > 0)
            {
                if (listaProdutos.SelectedItems[0].SubItems[7].Text == "Ativo")
                {
                    TelaEntrarProd telaEntrar = new TelaEntrarProd(Convert.ToInt32(listaProdutos.SelectedItems[0].SubItems[6].Text), false);
                    telaEntrar.ShowDialog();
                    carregarListaEstoque();
                }
                else
                {
                    MessageBox.Show("Este produto está inativo");

                }
            }
            else
            {
                MessageBox.Show("Não foi selecionado nenhum produto");
            }

        }

        private void Bt_Editar_Prod_Click(object sender, EventArgs e)
        {
            if (listaProdutos.SelectedItems.Count > 0)
            {
                TelaCriarProd telaCriar = new TelaCriarProd(false, Convert.ToInt32(listaProdutos.SelectedItems[0].SubItems[6].Text));
                telaCriar.ShowDialog();
                carregarListaEstoque();
            }
            else
            {
                MessageBox.Show("Não foi selecionado nenhum produto");
            }

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel_Total_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxPesquisaProdEstoque_KeyUp(object sender, KeyEventArgs e)
        {
            Produto prod = new Produto();
            listaProdutos.Items.Clear();
            var varProd = dadosProdutos.pesquisaNome(TxtBoxPesquisaProdEstoque.Text);

            if (varProd.Count > 0)
            {
                for (int i = 0; i < varProd.Count; i++)
                {
                    prod.idProduto = Convert.ToInt32(varProd[i]["idProduto"]);

                    prod.prodNome = varProd[i]["prodNome"].ToString();
                    prod.prodCusto = Convert.ToDouble(varProd[i]["prodCusto"]);
                    prod.prodValor = Convert.ToDouble(varProd[i]["prodValor"]);
                    prod.prodQuantidade = Convert.ToInt32(varProd[i]["prodQuantidade"]);
                    prod.prodCodBarras = varProd[i]["prodCodBarras"].ToString();
                    prod.prodEstado = Convert.ToBoolean(varProd[i]["prodEstado"]);

                    ListViewItem item = new ListViewItem();


                    item.SubItems.Add(prod.prodNome);
                    item.SubItems.Add("R$" + prod.prodCusto.ToString("F2"));
                    item.SubItems.Add("R$" + prod.prodValor.ToString("F2"));
                    item.SubItems.Add(prod.prodCodBarras);
                    item.SubItems.Add(prod.prodQuantidade.ToString());
                    item.SubItems.Add(prod.idProduto.ToString());

                    if (!prod.prodEstado)
                    {
                        item.SubItems.Add("Ativo");
                    }
                    else
                    {
                        item.SubItems.Add("Inativo");
                        item.BackColor = System.Drawing.Color.Gray;

                    }
                    listaProdutos.Items.Add(item);
                }
            }
        }
    }
}
