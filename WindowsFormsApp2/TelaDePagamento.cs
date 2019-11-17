using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            BtnFinalizar.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void confirmar()
        {
            dadosVenda.InserirVenda(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), total);
            //inserir em pagamentos
            var aux2 = dadosVenda.GetDataByVenda();
            pagamento.InserirPagamento(Convert.ToDouble(TxtBoxDinheiro.Text.Trim()), Convert.ToInt32(aux2[0]["idVenda"]), 1);

            int aux = itensDaLista.Length / 5;
            for (int i = 0; i < aux; i++)
            {
                itensVenda.InserirItensVenda(Convert.ToInt32(aux2[0]["idVenda"]), Convert.ToInt32(itensDaLista[i, 4]), 1, total);
            }
            for (int i = 0; i < aux; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    Console.WriteLine(itensDaLista[i, j]);

                    //inserir na tabela itensdavenda
                }
            }
        }

        private void TxtBoxDinheiro_Leave(object sender, EventArgs e)
        {
            if (Convert.ToDouble(TxtBoxDinheiro.Text.Trim()) >= total)
            {
                if (Convert.ToDouble(TxtBoxDinheiro.Text.Trim()) == total)
                {
                    LblTroco.Text = "R$: 0,00";
                    BtnFinalizar.Enabled = true;
                }
                
            }
            else
            {
                LblTroco.Text = "R$: " + (Convert.ToDouble(TxtBoxDinheiro.Text.Trim()) - total).ToString("F2");
                BtnFinalizar.Enabled = true;
                TxtBoxDinheiro.Text = "";
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            confirmar();
            Close();
        }

        private void TxtBoxDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtBoxDinheiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                if (Convert.ToDouble(TxtBoxDinheiro.Text.Trim()) >= total)
                {
                    if (Convert.ToDouble(TxtBoxDinheiro.Text.Trim()) == total)
                    {
                        LblTroco.Text = "R$: 0,00";
                        BtnFinalizar.Enabled = true;
                    }

                }
                else
                {
                    LblTroco.Text = "R$: " + (total - Convert.ToDouble(TxtBoxDinheiro.Text.Trim())).ToString("F2");
                    BtnFinalizar.Enabled = false;
                    TxtBoxDinheiro.Text = "";
                }

            }
        }
    }
}
