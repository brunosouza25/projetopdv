using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TelaDeSangria : Form
    {
        DadosTableAdapters.CaixaTableAdapter caixa = new DadosTableAdapters.CaixaTableAdapter();
        DadosTableAdapters.Observacoes_SangriaTableAdapter obs = new DadosTableAdapters.Observacoes_SangriaTableAdapter();
        public TelaDeSangria()
        {
            InitializeComponent();
            carregarSangria();
        }

        private void carregarSangria()
        {

            var idCaixa = caixa.pegarIDUltimoCaixa();
            var aux = caixa.pegarCaixaPorID(Convert.ToInt32(idCaixa[0]["idCaixa"]));
            txtBoxCaixaAtual.Text = ("R$:"+ Convert.ToDouble(aux[0]["valorAtual"]).ToString("F2"));
        }
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
                else if(txtBoxObs.Text.Length < 9)
                {
                    MessageBox.Show("O campo Motivo não deve ficar em branco e deve conter mais de 10 caracteres");
                }
                else
                {
                    string auxObs;
                    if (txtBoxObs.Text.Length < 299) {
                        auxObs = txtBoxObs.Text;
                    }
                    else
                    {
                        auxObs = txtBoxObs.Text.Substring(0, 299);

                    }
                    obs.addObsCaixa(Convert.ToInt32(aux[0]["idCaixa"]), auxObs, DateTime.Now.ToString("dd/MM/yyyy")
                        ,DateTime.Now.ToString("hh:mm"), Global.idColaborador); 
                    double total = Convert.ToDouble(aux[0]["valorAtual"]);  
                    caixa.attValorAtual(total - a,  Convert.ToInt32(idCaixa[0]["idCaixa"]));
                    MessageBox.Show("Sobrou R$" + (total - a) + " de fundo de caixa");
                    MessageBox.Show("Sangria realizado com sucesso!");
                    Close();
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
        }

        private void txtBoxSangria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                valida();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
