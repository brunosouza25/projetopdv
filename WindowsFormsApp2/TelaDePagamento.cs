﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TelaDePagamento : Form
    {
        public string[,] itensDaLista { get; set; }
        double total;
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
            double a, b, c, d, f;
            double valorDin, valorCredVista, valorCredParc, valorDeb, valorDesc, valorPagar;

            if (TxtBoxDinheiro.Text == "")
                valorDin = 0;
            else
                valorDin = Convert.ToDouble(TxtBoxDinheiro.Text);

            if (txtCredVista.Text == "")
                valorCredVista = 0;
            else
                valorCredVista = Convert.ToDouble(txtCredVista.Text);

            if (txtCredParc.Text == "")
                valorCredParc = 0;
            else
                valorCredParc = Convert.ToDouble(txtCredParc.Text);

            if (txtDeb.Text == "")
                valorDeb = 0;
            else
                valorDeb = Convert.ToDouble(txtDeb.Text);

            if (txtBoxDesc.Text == "")
                valorDesc = 0;
            else
                valorDesc = Convert.ToDouble(txtBoxDesc.Text);



            double somaTotal = valorDin + valorCredVista + valorCredParc + valorDeb;

            string valorTotal = total.ToString("F2");
            total = total - valorDesc;


            if ((double.TryParse(TxtBoxDinheiro.Text.Trim(), out a) || TxtBoxDinheiro.Text == "") && ((double.TryParse(txtCredVista.Text.Trim(), out b) || txtCredVista.Text == "")) 
                && ((double.TryParse(txtCredParc.Text.Trim(), out c) || txtCredParc.Text == "")) && ((double.TryParse(txtDeb.Text.Trim(), out d) || txtDeb.Text == ""))
                && ((double.TryParse(txtBoxDesc.Text.Trim(), out f )|| txtBoxDesc.Text == "")))
            {
                if (somaTotal == Convert.ToDouble(valorTotal))
                {
                    LblFalta.Text = "Falta: R$";
                    LblTroco.Text = "Troco R$0,00";
                    ok = true;
                }
                else if (somaTotal > total)
                {
                    LblFalta.Text = "Falta: R$0,00";
                    LblTroco.Text = "Troco R$" + (somaTotal - total).ToString("F2");
                    ok = true;
                }
                else
                {
                    LblTroco.Text = "Troco: R$0,00";
                    LblFalta.Text = "Falta: R$" + (total - somaTotal).ToString("F2");
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
            dadosVenda.InserirVenda(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), total);
            //inserir em pagamentos
            var aux2 = dadosVenda.GetDataByVenda();
            
            if(TxtBoxDinheiro.Text == "" || TxtBoxDinheiro.Text == "0")
                pagamento.InserirPagamento(0, Convert.ToInt32(aux2[0]["idVenda"]), 1);
            else
                pagamento.InserirPagamento(Convert.ToDouble(Convert.ToDouble(TxtBoxDinheiro.Text)), Convert.ToInt32(aux2[0]["idVenda"]), 1);

            if (txtCredVista.Text == "" || txtCredVista.Text == "0")
                pagamento.InserirPagamento(0, Convert.ToInt32(aux2[0]["idVenda"]), 2);
            else
                pagamento.InserirPagamento(Convert.ToDouble(Convert.ToDouble(txtCredVista.Text)), Convert.ToInt32(aux2[0]["idVenda"]), 2);
            if (txtCredParc.Text == "" || txtCredParc.Text == "0")
                pagamento.InserirPagamento(0, Convert.ToInt32(aux2[0]["idVenda"]), 3);
            else
                pagamento.InserirPagamento(Convert.ToDouble(Convert.ToDouble(txtCredParc.Text)), Convert.ToInt32(aux2[0]["idVenda"]), 3);
            if (txtDeb.Text == "" || txtDeb.Text == "0")
                pagamento.InserirPagamento(0, Convert.ToInt32(aux2[0]["idVenda"]), 4);
            else
                pagamento.InserirPagamento(Convert.ToDouble(Convert.ToDouble(txtDeb.Text)), Convert.ToInt32(aux2[0]["idVenda"]), 4);


            int aux = itensDaLista.Length / 7;
            for (int i = 0; i < aux; i++)
            {
                
                itensVenda.InserirItensVenda(Convert.ToInt32(aux2[0]["idVenda"]), Convert.ToInt32(itensDaLista[i, 6]), Convert.ToInt32(itensDaLista[i, 4]), total);
                var prodQuant = produto.PegaQuantidadePorCod(itensDaLista[i, 2].ToString());

                produto.AttPorCodBarras(Convert.ToInt32(prodQuant[0]["prodQuantidade"])- Convert.ToInt32(itensDaLista[i, 4]), itensDaLista[i, 2].ToString()); 
            }
            var idCaixa = caixa.pegarIDUltimoCaixa();
            var totalCaixa = caixa.pegarCaixaPorID(Convert.ToInt32(idCaixa[0]["idCaixa"]));
            double tempTotal = total + Convert.ToDouble(totalCaixa[0]["valorAtual"]);
            string tempTotalString = tempTotal.ToString("F2");
            caixa.attValorAtual(Convert.ToDouble(tempTotalString), Convert.ToInt32(idCaixa[0]["idCaixa"]));
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

        private void txtCredVista_KeyDown(object sender, KeyEventArgs e)
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

        private void txtDeb_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCredParc_KeyDown(object sender, KeyEventArgs e)
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

        private void txtBoxDesc_KeyDown(object sender, KeyEventArgs e)
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

