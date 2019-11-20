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
    public partial class TelaDePagamento : Form
    {
        public string[,] itensDaLista { get; set; }
        double total;
        Boolean permicao = false;
        DadosTableAdapters.ProdutoTableAdapter dadosProdutos = new DadosTableAdapters.ProdutoTableAdapter();
        DadosTableAdapters.VendaTableAdapter dadosVenda = new DadosTableAdapters.VendaTableAdapter();
        DadosTableAdapters.ItensDaVendaTableAdapter itensVenda = new DadosTableAdapters.ItensDaVendaTableAdapter();
        DadosTableAdapters.PagamentoTableAdapter pagamento = new DadosTableAdapters.PagamentoTableAdapter();

        public TelaDePagamento(string[,] itensDaLista, double total)
        {
            InitializeComponent();
            this.itensDaLista = itensDaLista;
            this.total = total;
            LblTotal.Text = "R$: " + total.ToString("F2");
            BtnFinalizar.Enabled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool valida()
        {
            bool ok = false;
            double a;
            if (double.TryParse(TxtBoxDinheiro.Text.Trim(), out a))
            {
                if (Convert.ToDouble(TxtBoxDinheiro.Text.Trim()) == total)
                {
                    LblTroco.Text = "";
                    LblFalta.Text = "";
                    LblTroco.Text = "Troco R$: 0,00";
                    ok = true;
                }
                else if (Convert.ToDouble(TxtBoxDinheiro.Text.Trim()) > total)
                {
                    LblFalta.Text = "";
                    LblTroco.Text = "Troco R$: " + (Convert.ToDouble(TxtBoxDinheiro.Text.Trim()) - total).ToString("F2");
                    ok = true;
                }
                else
                {
                    LblTroco.Text = "";
                    LblFalta.Text = "Falta: " + (total - Convert.ToDouble(TxtBoxDinheiro.Text.Trim())).ToString("F2");
                    ok = false;
                }
            }
            else
            {
                MessageBox.Show("Deu ruim");
            }
            return ok;
        }
        public void confirmar()
        {
            dadosVenda.InserirVenda(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), total);
            //inserir em pagamentos
            var aux2 = dadosVenda.GetDataByVenda();
            //pagamento.InserirPagamento(Convert.ToDouble(TxtBoxDinheiro.Text.Trim()), Convert.ToInt32(aux2[0]["idVenda"]), 1);
            pagamento.InserirPagamento(Convert.ToDouble(total), Convert.ToInt32(aux2[0]["idVenda"]), 1);

            int aux = itensDaLista.Length / 5;
            for (int i = 0; i < aux; i++)
            {
                itensVenda.InserirItensVenda(Convert.ToInt32(aux2[0]["idVenda"]), Convert.ToInt32(itensDaLista[i, 4]), 1, total);
            }

            Close();
        }

        private void TxtBoxDinheiro_Leave(object sender, EventArgs e)
        {
            //valida();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if (valida())
                confirmar();

        }

        private void TxtBoxDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtBoxDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (valida())
                {
                    this.TopMost = true;
                    this.Activate();
                    BtnFinalizar.Select();
                }
            }


        }
    }
}

