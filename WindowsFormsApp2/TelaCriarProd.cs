using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TelaCriarProd : Form
    {
        Boolean tipo;
        int codigoProd;
        String caminho;
        string quantidade;
        private Produto prod = new Produto();
        DadosTableAdapters.ProdutoTableAdapter dadosProdutos = new DadosTableAdapters.ProdutoTableAdapter();
        public TelaCriarProd(Boolean tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            BtCriar.Text = "Criar";
        }
        public TelaCriarProd(Boolean tipo, int codigoProd)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.codigoProd = codigoProd;
            BtCriar.Text = "Alterar";
            carregarTela();

        }
       
        
        private void carregarTela()
        {
            Console.WriteLine(this.codigoProd);
            var varProd = dadosProdutos.GetDataById(this.codigoProd);

            TxtBoxNome.Text = varProd[0]["prodNome"].ToString();
            TxtBoxCusto.Text = varProd[0]["prodCusto"].ToString();
            TxtBoxValor.Text = varProd[0]["prodValor"].ToString();
            TxtBoxCodBarras.Text = varProd[0]["prodCodBarras"].ToString();
            /*if(arquivo.Count > 4)
            {
                quantidade = arquivo[4];
            }
            else
            {
                quantidade = "0";
            }*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtCriar_Click(object sender, EventArgs e)
        {
            if (tipo)
            {
                dadosProdutos.InserirDados(
                    prod.prodNome = TxtBoxNome.Text,
                    prod.prodValor = double.Parse(TxtBoxValor.Text),
                    prod.prodCusto = double.Parse(TxtBoxCusto.Text),
                    prod.prodQuantidade = 0,
                    prod.prodCodBarras = TxtBoxCodBarras.Text);
                Close();
            }
            else
            {
                dadosProdutos.AttDados(
                    TxtBoxNome.Text,
                    Convert.ToDouble(TxtBoxValor.Text),
                    Convert.ToDouble(TxtBoxCusto.Text),
                    TxtBoxCodBarras.Text,
                    codigoProd
                    );
                Close();
            }
            /*
            string[] arquivo;
            if(TxtBoxNome.Text != produto && tipo == false)
            {
                System.IO.File.Delete(@"c:\arquivos\" + produto+ ".txt");
            }
            prod.prodNome = TxtBoxNome.Text;
            prod.prodCusto = double.Parse(TxtBoxCusto.Text);
            prod.prodValor = double.Parse(TxtBoxValor.Text);
            prod.prodCodBarras = TxtBoxCodBarras.Text;
            string caminho = @"c:\arquivos\" + prod.prodNome + ".txt";
            if (tipo)
                prod.prodQuantidade = 0;
            else
                
            Console.WriteLine(prod.prodQuantidade + "fafa");
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
            */
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