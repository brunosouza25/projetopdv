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

        private string pesquisaListaCaixa(string pesquisa)
        {
            string caminho = @"c:\arquivos";
            string[] arquivo;
            try
            {
                IEnumerable<string> arquivos = Directory.EnumerateFiles(caminho, "*.txt", SearchOption.AllDirectories);
                Console.WriteLine(arquivos);
                foreach (string prod in arquivos)
                {
                    arquivo = File.ReadAllLines(prod);
                    if (arquivo[0] == pesquisa.Trim())
                    {
                        TxtBoxPesquisaProdEstoque.Text = "";
                        ListViewItem item = new ListViewItem();
                        for (int i = 0; i < arquivo.Length; i++)
                        {
                            item.SubItems.Add(arquivo[i]);
                        }
                    }
                }
            }
            catch (IOException er)
            {
                Console.WriteLine("Tivemos um erro ");
                Console.WriteLine(er.Message);
            }
            return "0";
        }
        private void carregarListaEstoque()
        {
            listaProdutos.Items.Clear();
            string caminho = @"c:\arquivos";
            string[] arquivo;
            try
            {
                IEnumerable<string> arquivos = Directory.EnumerateFiles(caminho, "*.txt", SearchOption.AllDirectories);
                Console.WriteLine(arquivos);
                foreach (string prod in arquivos)
                {
                    arquivo = File.ReadAllLines(prod);
                    ListViewItem item = new ListViewItem();
                    for (int i = 0; i < arquivo.Length; i++)
                    {
                        item.SubItems.Add(arquivo[i]);
                    }
                    listaProdutos.Items.Add(item);
                }
            }
            catch (IOException er)
            {
                Console.WriteLine("Tivemos um erro ");
                Console.WriteLine(er.Message);
            }
        }
        private Boolean criar = false;
        Produto produtos = new Produto();
        private void Bt_Criar_Prod_Click(object sender, EventArgs e)
        {
            //AINDA NÃO CONCLUIDO "TENTANDO BLOQUEAR PARA EXIBIR APENAS UM POR VEZ"
            //If para verificação se a form já está aberta
            if (Application.OpenForms.OfType<TelaCriarProd>().Count() > 0)
            {
                MessageBox.Show("A tela de cadastro já está aberta");
            }
            else
            {
                TelaCriarProd telaCriar = new TelaCriarProd();
                telaCriar.ShowDialog();
            }
            carregarListaEstoque();
        }

        //função para ler os arquivos e colocar na listview
        private void TelaDeEstoque_Load(object sender, EventArgs e)
        {
            carregarListaEstoque();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pesquisaProd_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pesquisaProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisaListaCaixa(TxtBoxPesquisaProdEstoque.Text);
            }
        }

        private void Bt_Entrar_Prod_Click(object sender, EventArgs e)
        {

            TelaEntrarProd telaEntrar = new TelaEntrarProd(listaProdutos.SelectedItems[0].SubItems[1].Text);
            telaEntrar.ShowDialog();
            carregarListaEstoque();
        }
    }
}
