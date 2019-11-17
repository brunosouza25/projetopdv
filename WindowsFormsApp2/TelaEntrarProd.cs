using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TelaEntrarProd : Form
    {


        int add, remove, prodCodigo;
        Boolean tipo;
        DadosTableAdapters.ProdutoTableAdapter dadosProdutos = new DadosTableAdapters.ProdutoTableAdapter();
        public TelaEntrarProd(int prodCodigo, Boolean tipo)
        {
            InitializeComponent();
            this.prodCodigo = prodCodigo;
            this.tipo = tipo;
        }

        private void addArquivos()
        {
            if (tipo)
            {
                int aux = Convert.ToInt32(TxtBoxQuant.Text);

                var aux2 = dadosProdutos.PegaQuantidade(prodCodigo);

                aux += Convert.ToInt32(aux2[0]["prodQuantidade"]);

                dadosProdutos.AttQuantidade(aux, prodCodigo);
            }
            else
            {
                int aux = Convert.ToInt32(TxtBoxQuant.Text);

                var aux2 = dadosProdutos.PegaQuantidade(prodCodigo);

                aux = Convert.ToInt32(aux2[0]["prodQuantidade"]) - aux;

                dadosProdutos.AttQuantidade(aux, prodCodigo);
            }
            Close();
            /*
            List<string> arquivo = new List<string>();
            string[] arquivo2;
            try
            { 
                add = int.Parse(TxtBoxQuant.Text);
                Console.WriteLine(produto);
                int num1, num2;
                string temp1, temp2;
                caminho = @"c:\arquivos\" + produto + ".txt";
                Console.WriteLine(caminho);
                using (StreamReader sr = new StreamReader(caminho))
                    while (!sr.EndOfStream)
                    {
                        arquivo.Add(sr.ReadLine());
                    }

                if (tipo)
                {
                    num1 = int.Parse(arquivo[4]);
                    num2 = num1 + add;
                    arquivo[4] = num2.ToString();
                }
                else
                {
                    num1 = int.Parse(arquivo[4]);
                    num2 = num1 - add;
                    arquivo[4] = num2.ToString();
                }

                try
                {
                    using (StreamWriter sw = new StreamWriter(caminho))
                    {
                        foreach (string linha in arquivo)
                        {
                            sw.WriteLine(linha);
                        }
                    }
                }
                catch (IOException er)
                {
                    Console.WriteLine("Tivemos um erro ");
                    Console.WriteLine(er.Message);
                }
                Close();
            }

            catch (IOException er)
            {
                Console.WriteLine("Tivemos um erro ");
                Console.WriteLine(er.Message);
            }
            */
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxQuant_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtEntrarQuant_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TxtBoxQuant.Text) < 1)
                {
                    MessageBox.Show("Não permitida a entrada de valores negativos");
                    TxtBoxQuant.Text = "";
                }
                else
                    addArquivos();
            } catch (IOException er)
            {
                MessageBox.Show("Não é permitida a entrada de alfabeticos");
                TxtBoxQuant.Text = "";
            }
            
           Close();

        }
    }
}
