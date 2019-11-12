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
        int add, remove;
        String caminho;
        Boolean tipo;

        public TelaEntrarProd(String produto, Boolean tipo)
        {
            InitializeComponent();
            //this.produto = produto;
            this.produto = produto;
            this.tipo = tipo;
        }

        private void addArquivos()
        {
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


                Console.WriteLine(arquivo[4]+ "aaaaaaaaaaaaaa");

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
            addArquivos();
        }
    }
}
