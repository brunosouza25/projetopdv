using System;
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
        DadosTableAdapters.ProdutoTableAdapter produto = new DadosTableAdapters.ProdutoTableAdapter();
        DadosTableAdapters.CaixaTableAdapter caixa = new DadosTableAdapters.CaixaTableAdapter();   

        public TelaDePagamento(string[,] itensDaLista, double total)
        {
            InitializeComponent();
            this.itensDaLista = itensDaLista;
            this.total = total;
            LblTotal.Text = "R$: " + total.ToString("F2");
            BtnFinalizar.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool valida()
        {
            bool ok = false;
            double a;
            string valor = TxtBoxDinheiro.Text;
            string valor2 = total.ToString("F2");
            if (double.TryParse(TxtBoxDinheiro.Text.Trim(), out a))
            {
                if (Convert.ToDouble(valor) == Convert.ToDouble(valor2))
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
                MessageBox.Show("Dados invalidos");
            }
            return ok;
        }
        public void confirmar()
        {
            dadosVenda.InserirVenda(DateTime.Now.ToString("dd/MM/yyyy"), total);
            //inserir em pagamentos
            var aux2 = dadosVenda.GetDataByVenda();
            var itens = itensVenda.GetData();
            
            pagamento.InserirPagamento(Convert.ToDouble(total), Convert.ToInt32(aux2[0]["idVenda"]), 1);

            int aux = itensDaLista.Length / 5;
            for (int i = 0; i < aux; i++)
            {
                
                itensVenda.InserirItensVenda(Convert.ToInt32(aux2[0]["idVenda"]), Convert.ToInt32(itensDaLista[i, 4]), 1, total);
                var prodQuant = produto.PegaQuantidadePorCod(itensDaLista[i, 2].ToString());

                produto.AttPorCodBarras(Convert.ToInt32(prodQuant[0]["prodQuantidade"])-1, itensDaLista[i, 2].ToString()); 
            }
            var idCaixa = caixa.pegarIDUltimoCaixa();
            var totalCaixa = caixa.pegarCaixaPorID(Convert.ToInt32(idCaixa[0]["idCaixa"]));
            caixa.attValorAtual(total + Convert.ToDouble(totalCaixa[0]["valorAtual"]), Convert.ToInt32(idCaixa[0]["idCaixa"]));
            MessageBox.Show("Venda realizada com sucesso!");
            Close();
        }
        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if (valida())
                confirmar();
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

