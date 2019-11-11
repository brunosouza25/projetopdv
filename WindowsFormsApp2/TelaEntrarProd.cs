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

        String produto;
        int add;
        public TelaEntrarProd(String produto)
        {
            InitializeComponent();
            this.produto = produto;
        }

        private string addArquivos(string produto, int add)
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
                    if (arquivo[0] == produto.Trim())
                    {
                        arquivo[3] = add + arquivo[3];
                        caminho = @"c:\arquivos\" + produto + ".txt";
                        try
                        {
                            using (StreamWriter sw = new StreamWriter(caminho))
                            {
                                sw.WriteLine(arquivo);
                            }
                        }
                        catch (IOException er)
                        {
                            Console.WriteLine("Tivemos um erro ");
                            Console.WriteLine(er.Message);
                        }
                        Close();
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
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtEntrarQuant_Click(object sender, EventArgs e)
        {
            add = int.Parse(TxtBoxQuant.Text);
            addArquivos(this.produto, add);
        }
    }
}
