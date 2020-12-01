using System;

using System.Windows.Forms;

namespace WindowsFormsApp2.Estoque.View
{
    public partial class TelaInformacaoGeralProd : UserControl
    {
        byte checkbox;
        Boolean tipo;
        int codigoProd;
        String caminho;
        string quantidade;
        private Produto prod = new Produto();
        DadosTableAdapters.ProdutoTableAdapter dadosProdutos = new DadosTableAdapters.ProdutoTableAdapter();
        public TelaInformacaoGeralProd(Boolean tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            BtCriar.Text = "Criar";
            lblInativo.Visible = false;
            ckboxInativo.Visible = false;
            TxtBoxCodBarras.Select();


        }
        public TelaInformacaoGeralProd(Boolean tipo, int codigoProd)
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
            ckboxInativo.Checked = Convert.ToBoolean(varProd[0]["prodEstado"]);
            /*if(arquivo.Count > 4)
            {
                quantidade = arquivo[4];
            }
            else
            {
                quantidade = "0";
            }*/
        }

        private void BtCriar_Click(object sender, EventArgs e)
        {
            double a, b;
            if (TxtBoxCodBarras.Text == "" | TxtBoxCusto.Text == "" | TxtBoxNome.Text == "" | TxtBoxValor.Text == "")
                MessageBox.Show("Por favor, preencha todos os campos!");
            else if (double.TryParse(TxtBoxCusto.Text.Trim(), out a) && (double.TryParse(TxtBoxValor.Text.Trim(), out b)))
            {
                if (tipo)
                {
                    dadosProdutos.InserirDados(
                        prod.prodNome = TxtBoxNome.Text,
                        prod.prodValor = double.Parse(TxtBoxValor.Text),
                        prod.prodCusto = double.Parse(TxtBoxCusto.Text),
                        prod.prodQuantidade = 0,
                        prod.prodCodBarras = TxtBoxCodBarras.Text,
                        0);

                }
                else
                {
                    if (ckboxInativo.Checked)
                        checkbox = 1;
                    else
                        checkbox = 0;


                    /*if (Convert.ToInt32(varProd[0]["prodQuantidade"]) > 0 && ckboxInativo.Checked)
                        MessageBox.Show("Não foi possível inativar pois ainda tem o produto em estoque");
                    */

                    dadosProdutos.AttDados(
                        TxtBoxNome.Text,
                        Convert.ToDouble(TxtBoxValor.Text),
                        Convert.ToDouble(TxtBoxCusto.Text),
                        TxtBoxCodBarras.Text,
                        checkbox,
                        codigoProd);


                }
            }
            else
                MessageBox.Show("Valores não permitidos");

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
