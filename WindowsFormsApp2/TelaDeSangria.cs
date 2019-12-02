using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TelaDeSangria : Form
    {
        public TelaDeSangria()
        {
            InitializeComponent();
        }
        DadosTableAdapters.CaixaTableAdapter caixa = new DadosTableAdapters.CaixaTableAdapter();
        private void valida()
        {
            double a;

            if (double.TryParse(txtBoxSangria.Text.Trim(), out a))
            {
                var idCaixa = caixa.pegarIDUltimoCaixa();
                var aux = caixa.pegarCaixaPorID(Convert.ToInt32(idCaixa[0]["idCaixa"]));
                if (a < 0)
                    MessageBox.Show("Não é permitida a entrada de valores negativo");
                else if(a > Convert.ToDouble(aux[0]["valorAtual"]))
                    MessageBox.Show("O valor inserido é maior que o contido em caixa");
                else
                {
                    
                    double total = Convert.ToDouble(aux[0]["valorAtual"]);  
                    caixa.attValorAtual(total - a,  Convert.ToInt32(idCaixa[0]["idCaixa"]));
                    MessageBox.Show("Sobrou R$" + (total - a) + " de fundo de caixa");
                    caixa.fecharCaixa(total - a, Convert.ToByte(aux[0]["estadoCaixa"]), Convert.ToInt32(aux[0]["idCaixa"]));
                }

            }
            else
                MessageBox.Show("Entrada invalida");
        } 

        private void txtBoxSangria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            valida();
            Close();
        }

        private void txtBoxSangria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                valida();
                Close();
            }
        }
    }
}
