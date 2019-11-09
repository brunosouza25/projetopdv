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

        private void carregarLista()
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
            carregarLista();
        }

        private void Bt_Entrar_Prod_Click_1(object sender, EventArgs e)
        {

        }

        //função para ler os arquivos e colocar na listview
        private void TelaDeEstoque_Load(object sender, EventArgs e)
        {
            carregarLista();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
