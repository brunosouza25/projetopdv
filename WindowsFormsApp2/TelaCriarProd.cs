using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TelaCriarProd : Form
    {
        public TelaCriarProd()
        {
            InitializeComponent();
        }

        private Produto prod = new Produto();
        public Boolean criado { get; set; }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtCriar_Click(object sender, EventArgs e)
        {

            string[] arquivo;
            prod.prodNome = TxtBoxNome.Text;
            prod.prodCusto = double.Parse(TxtBoxCusto.Text);
            prod.prodValor = double.Parse(TxtBoxValor.Text);
            prod.prodCodBarras = TxtBoxCodBarras.Text;
            string caminho = @"c:\arquivos\"+prod.prodNome+".txt";
            Console.WriteLine(prod.prodCodBarras);
            try
            {
                using (StreamWriter sw = new StreamWriter(caminho))
                {
                    sw.WriteLine(prod);
                }
            }
            catch (IOException er)
            {
                Console.WriteLine("Tivemos um erro ");
                Console.WriteLine(er.Message);
            }
            Close();
        }

        private void painel_CriarProd_Leave(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}