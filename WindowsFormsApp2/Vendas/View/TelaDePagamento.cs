﻿using System;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsFormsApp2
{
    public partial class TelaDePagamento : Form
    {
        public string[,] itensDaLista { get; set; }

        public TelaDoPdv TelaDoPdv
        {
            get => default;
            set
            {
            }
        }

        internal Fiscal Fiscal
        {
            get => default;
            set
            {
            }
        }

        double total, valorDesc = 0;
        int idPagamento;
        DadosTableAdapters.ProdutoTableAdapter dadosProdutos = new DadosTableAdapters.ProdutoTableAdapter();
        DadosTableAdapters.VendaTableAdapter dadosVenda = new DadosTableAdapters.VendaTableAdapter();
        DadosTableAdapters.ItensDaVendaTableAdapter itensVenda = new DadosTableAdapters.ItensDaVendaTableAdapter();
        DadosTableAdapters.PagamentoTableAdapter pagamento = new DadosTableAdapters.PagamentoTableAdapter();
        DadosTableAdapters.ProdutoTableAdapter produto2 = new DadosTableAdapters.ProdutoTableAdapter();
        DadosTableAdapters.CaixaTableAdapter caixa = new DadosTableAdapters.CaixaTableAdapter();
        DadosTableAdapters.Config_SistemaTableAdapter configSistema = new DadosTableAdapters.Config_SistemaTableAdapter();
        DadosTableAdapters.ItensDaVendaTableAdapter itensDaVenda = new DadosTableAdapters.ItensDaVendaTableAdapter();



        public TelaDePagamento(string[,] itensDaLista, double total)
        {
            InitializeComponent();
            this.itensDaLista = itensDaLista;
            this.total = total;
            LblTotal.Text = "R$: " + total.ToString("F2");
            BtnFinalizar.Enabled = false;
            ultimoId();
        }

        private void ultimoId()
        {

            var aux = pagamento.retornaUltimoIdPagamento();
            if (aux.Count > 0)
                this.idPagamento = Convert.ToInt32(aux[0]["idPagamento"]) + 1;
            else
                this.idPagamento = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool valida()
        {
            bool ok = false;
            double a, b, c, d, f;
            double valorDin = 0, valorCredVista = 0, valorCredParc = 0,  valorDeb = 0, totalvalidar = 0;




               string valorTotal = total.ToString("F2");


            if ((double.TryParse(TxtBoxDinheiro.Text.Trim(), out a) || TxtBoxDinheiro.Text == "") && ((double.TryParse(txtCredVista.Text.Trim(), out b) || txtCredVista.Text == ""))
                && ((double.TryParse(txtCredParc.Text.Trim(), out c) || txtCredParc.Text == "")) && ((double.TryParse(txtDeb.Text.Trim(), out d) || txtDeb.Text == ""))
                && ((double.TryParse(txtBoxDesc.Text.Trim(), out f) || txtBoxDesc.Text == "")))
            {
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

                
                totalvalidar = total - valorDesc;


                if (somaTotal == totalvalidar)
                {
                    LblFalta.Text = "Falta: R$0,00";
                    LblTroco.Text = "Troco R$0,00";
                    ok = true;
                }
                else if (somaTotal >= totalvalidar)
                {
                    LblFalta.Text = "Falta: R$0,00";
                    LblTroco.Text = "Troco R$" + Math.Abs(somaTotal - total - valorDesc).ToString("F2");
                    ok = true;
                }
                else
                {
                    LblTroco.Text = "Troco: R$0,00";
                    LblFalta.Text = "Falta: R$" + ((total - somaTotal)-valorDesc).ToString("F2");
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
            
            var idCaixa = caixa.pegarIDUltimoCaixa();
            double valorpago = total - valorDesc;

            //inserir em pagamentos

            if (txtBoxDesc.Text == "")
                valorDesc = 0;
            else
                valorDesc = Convert.ToDouble(txtBoxDesc.Text);
            dadosVenda.InserirVenda(DateTime.Now.ToString("dd/MM/yyyy"), total, Convert.ToByte(1), Convert.ToInt32(idCaixa[0]["idCaixa"]), "", DateTime.Now.ToString("HH:mm:ss"), valorpago, Global.idColaborador);
            var aux2 = dadosVenda.GetDataByVenda();

            double din;
            if (TxtBoxDinheiro.Text == "" || TxtBoxDinheiro.Text == "0")
            {
                din = 0;
            }
            else
            {
                din = Convert.ToDouble(TxtBoxDinheiro.Text);
            }
                /*if (TxtBoxDinheiro.Text != "" && TxtBoxDinheiro.Text != "0")
                {*/
                  pagamento.InserirPagamento(din, Convert.ToInt32(aux2[0]["idVenda"]), 1, valorDesc, idPagamento);
                var totalCaixa = caixa.pegarCaixaPorID(Convert.ToInt32(idCaixa[0]["idCaixa"]));
                double tempTotal = din + Convert.ToDouble(totalCaixa[0]["valorAtual"]);
                string tempTotalString = tempTotal.ToString("F2");
                caixa.attValorAtual(Convert.ToDouble(tempTotalString), Convert.ToInt32(idCaixa[0]["idCaixa"]));
            /*}*/
            if (txtCredVista.Text != "" && txtCredVista.Text != "0")
                pagamento.InserirPagamento(Convert.ToDouble(Convert.ToDouble(txtCredVista.Text)), Convert.ToInt32(aux2[0]["idVenda"]), 2, valorDesc, idPagamento);

            if (txtCredParc.Text != "" && txtCredParc.Text != "0")
                pagamento.InserirPagamento(Convert.ToDouble(Convert.ToDouble(txtCredParc.Text)), Convert.ToInt32(aux2[0]["idVenda"]), 3, valorDesc, idPagamento);
            if (txtDeb.Text != "" && txtDeb.Text != "0")
                pagamento.InserirPagamento(Convert.ToDouble(Convert.ToDouble(txtDeb.Text)), Convert.ToInt32(aux2[0]["idVenda"]), 4, valorDesc, idPagamento);


            int aux = itensDaLista.Length / 7;
            for (int i = 0; i < aux; i++)
            {
                var produto = dadosProdutos.pegarBancoCodigoBarras(itensDaLista[i, 2].ToString());
                itensVenda.InserirItensVenda(Convert.ToInt32(aux2[0]["idVenda"]), Convert.ToInt32(itensDaLista[i, 6]), Convert.ToInt32(itensDaLista[i, 4]), total, 0, 0, Convert.ToDouble(itensDaLista[i, 3]), Convert.ToDouble(produto[0]["prodCusto"].ToString()), itensDaLista[i, 2].ToString());
                var prodQuant = produto2.PegaQuantidadePorCod(itensDaLista[i, 2].ToString());
                
                produto2.AttPorCodBarras(Convert.ToInt32(prodQuant[0]["prodQuantidade"]) - Convert.ToInt32(itensDaLista[i, 4]), itensDaLista[i, 2].ToString());
            }
            
            

            try
            {
                var auxFiscal = configSistema.retornarConfig();
                if (Convert.ToBoolean(auxFiscal[0]["fiscal"]))
                {
                    var quantidadeItensVenda = itensDaVenda.retornarItensVenda(Convert.ToInt32(aux2[0]["idVenda"]));
                    Boolean fiscal = true;
                    string nomeProduto = "";
                    for (int i = 0; i >= quantidadeItensVenda.Count; i++)
                    {

                        if (!Convert.ToBoolean(quantidadeItensVenda[i]["fiscal"]))
                        {
                            fiscal = false;
                            nomeProduto = quantidadeItensVenda[i]["prodNome"].ToString();
                        }

                    }
                    if (fiscal)
                    {
                        Fiscal cupomFiscal = new Fiscal();
                        string tick = DateTime.Now.Ticks.ToString();
                        cupomFiscal.escreverIniNfce(Convert.ToInt32(aux2[0]["idVenda"]), tick);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível emitir o cupom fiscal, faltam dados fiscais do produto: " + nomeProduto);
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível emitir o cupom fiscal, faltam dados fiscais da empresa");
                }
                MessageBox.Show("Venda realizada com sucesso!");
            }
            catch (IOException e)
            {
                MessageBox.Show("Whoops, tivemos um erro na venda, favor contatar o suporte");
            }
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
                    BtnFinalizar.Enabled = true;
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
                    BtnFinalizar.Enabled = true;
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
                    BtnFinalizar.Enabled = true;
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
                    BtnFinalizar.Enabled = true;
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
                    BtnFinalizar.Enabled = true;
                    BtnFinalizar.Select();
                }
            }
        }
    }
}

