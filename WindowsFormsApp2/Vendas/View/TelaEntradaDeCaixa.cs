using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Vendas.View
{
    public partial class TelaEntradaDeCaixa : Form
    {
        double valorEntrada;
        DadosTableAdapters.CaixaTableAdapter caixa = new DadosTableAdapters.CaixaTableAdapter();
        DadosTableAdapters.Observacoes_SangriaTableAdapter obs = new DadosTableAdapters.Observacoes_SangriaTableAdapter();
        public TelaEntradaDeCaixa()
        {
            InitializeComponent();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            abrirCaixa();

        }
        public void abrirCaixa()
        {
            double a;
            var idCaixa = caixa.pegarIDUltimoCaixa();
            var aux = caixa.pegarCaixaPorID(Convert.ToInt32(idCaixa[0]["idCaixa"]));


            if (double.TryParse(txtBoxEntrada.Text.Trim(), out a))
            {
                if (a > 0)
                {
                    valorEntrada = a;
                    var saldoAnterior = caixa.pegarCaixaPorID(Convert.ToInt32(idCaixa[0]["idCaixa"]));
                    caixa.inserirCaixa(valorEntrada, Convert.ToDouble(saldoAnterior[0]["fechamentoCaixa"]), valorEntrada, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff"), 1);
                    MessageBox.Show("Caixa aberto com sucesso");
                    MessageBox.Show("Caixa aberto com: R$" + valorEntrada);
                    Close();

                }
                else
                {
                    MessageBox.Show("Valores não permitidos");

                }

            }
            else
            {
                MessageBox.Show("Valores não permitidos");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBoxEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                abrirCaixa();
            }

        
    }
    }
}
