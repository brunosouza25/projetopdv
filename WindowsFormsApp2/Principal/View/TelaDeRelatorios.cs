using System;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace WindowsFormsApp2
{
    public partial class TelaDeRelatorios : UserControl
    {
        public TelaDeRelatorios()
        {
            InitializeComponent();

        }



        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    DadosTableAdapters.DataTable2TableAdapter dadosProdutos = new DadosTableAdapters.DataTable2TableAdapter();
                    var varProd = dadosProdutos.GetDataBy1();

                    //instanciando e setando o tipo de página que vou utilizar
                    Document doc = new Document(PageSize.A4);
                    //colocando margens no pdf
                    doc.SetMargins(40, 40, 40, 80);

                    string aux = DateTime.Now.ToString("dd-MM-yyyy");

                    string caminho = @"C:\Users\bruno\Desktop\relatorios\relatorio_" + aux.ToString() + ".pdf";


                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                    doc.Open();

                    Paragraph titulo = new Paragraph();
                    titulo.Font = FontFactory.GetFont("Arial", 18);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.Add("Relatório de Vendas\n\n");
                    doc.Add(titulo);

                    PdfPTable table = new PdfPTable(4);
                    table.AddCell("Data da venda");
                    table.AddCell("Código da venda");
                    table.AddCell("Valor da venda");
                    table.AddCell("Tipo de pagamento");


                    for (int i = 0; i < varProd.Count(); i++)
                    {
                        table.AddCell(Convert.ToDateTime(varProd[i]["vendData"]).ToString("dd/MM/yyyy HH:mm:ss"));
                        table.AddCell(varProd[i]["idVenda"].ToString());
                        table.AddCell("R$ " + Convert.ToDouble(varProd[i]["valorCompra"]).ToString("F2"));
                        table.AddCell(varProd[i]["pagamentoTipo"].ToString());

                    }
                    doc.Add(table);
                    doc.Close();
                    MessageBox.Show("Relatório gerado com sucesso!");
                }
                catch (IOException er)
                {
                    MessageBox.Show("Não foi possível criar o arquivo, o mesmo pode estar sendo executado por outro programa");
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fechamentoCaixa()
        {
            try
            {
                double totalDin = 0, totalCredVista = 0, totalCredParc = 0, totalDebt = 0, descontoDevolucao = 0;
                DadosTableAdapters.DataTable2TableAdapter fechamento = new DadosTableAdapters.DataTable2TableAdapter();
                var varProd = fechamento.relatorio();
                //instanciando e setando o tipo de página que vou utilizar
                Document doc = new Document(PageSize.A4);
                //colocando margens no pdf
                doc.SetMargins(40, 40, 40, 80);

                string aux = DateTime.Now.ToString("dd-MM-yyyy");

                string caminho = @"C:\Users\bruno\Desktop\relatorios\fechamento" + aux.ToString() + ".pdf";


                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                doc.Open();

                Paragraph titulo = new Paragraph();
                titulo.Font = FontFactory.GetFont("Arial", 18);
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.Add("Fechamento do dia \n\n");
                doc.Add(titulo);

                Paragraph informacao = new Paragraph();
                informacao.Font = FontFactory.GetFont("Arial", 12, BaseColor.BLUE);
                informacao.Alignment = Element.ALIGN_LEFT;

                Paragraph metodoPagamento = new Paragraph();
                metodoPagamento.Font = FontFactory.GetFont("Arial", 14);
                metodoPagamento.Alignment = Element.ALIGN_LEFT;

                //para o dinheiro==================================================================
                var dinheiro = fechamento.retornarFechamentoComDevolucao("DINHEIRO", DateTime.Now.ToString("dd/MM/yyyy")
                    , DateTime.Now.ToString("dd/MM/yyyy"));
                if (dinheiro.Count < 1)
                    dinheiro = fechamento.retornarFechamentoSemDevolucao("DINHEIRO", DateTime.Now.ToString("dd/MM/yyyy")
                    , DateTime.Now.ToString("dd/MM/yyyy"));

                if (dinheiro.Count > 0)
                {
                    metodoPagamento.Add("Dinheiro \n\n");
                    doc.Add(metodoPagamento);

                    PdfPTable table = new PdfPTable(5);
                    table.AddCell("Data da venda");
                    table.AddCell("Código da venda");
                    table.AddCell("Tipo de pagamento");
                    table.AddCell("Vendedor");
                    table.AddCell("Valor da venda");

                    for (int i = 0; i < dinheiro.Count(); i++)
                    {
                        table.AddCell(Convert.ToDateTime(dinheiro[i]["vendData"]).ToString("dd/MM/yyyy HH:mm:ss"));
                        table.AddCell(dinheiro[i]["idVenda"].ToString());
                        table.AddCell("Dinheiro");
                        table.AddCell("Vendedor padrão");
                        table.AddCell("R$ " + Convert.ToDouble(dinheiro[i]["PagValor"]).ToString("F2"));
                        totalDin = totalDin + Convert.ToDouble(dinheiro[i]["PagValor"]);
                    }
                    doc.Add(table);
                    informacao.Add("\n\n" + "Total Dinheiro: R$" + totalDin.ToString("F2"));
                    doc.Add(informacao);
                }
                //para credito a vista ==================================================================
                PdfPTable table2 = new PdfPTable(5);

                var creditoVista = fechamento.retornarFechamentoComDevolucao("CREDITO A VISTA", DateTime.Now.ToString("dd/MM/yyyy")
                , DateTime.Now.ToString("dd/MM/yyyy"));
                if (creditoVista.Count < 1)
                    creditoVista = fechamento.retornarFechamentoSemDevolucao("CREDITO A VISTA", DateTime.Now.ToString("dd/MM/yyyy")
                    , DateTime.Now.ToString("dd/MM/yyyy"));

                if (creditoVista.Count > 0)
                {
                    metodoPagamento.Clear();
                    metodoPagamento.Add("\n\nCrédito à vista\n\n");
                    doc.Add(metodoPagamento);

                    table2.AddCell("Data da venda");
                    table2.AddCell("Código da venda");
                    table2.AddCell("Tipo de pagamento");
                    table2.AddCell("Vendedor");
                    table2.AddCell("Valor da venda");



                    for (int i = 0; i < creditoVista.Count(); i++)
                    {
                        table2.AddCell(Convert.ToDateTime(creditoVista[i]["vendData"]).ToString("dd/MM/yyyy HH:mm:ss"));
                        table2.AddCell(creditoVista[i]["idVenda"].ToString());
                        table2.AddCell("Crédito à vista");
                        table2.AddCell("Vendedor padrão");
                        table2.AddCell("R$ " + Convert.ToDouble(dinheiro[i]["PagValor"]).ToString("F2"));
                        totalCredVista = totalCredVista + Convert.ToDouble(dinheiro[i]["PagValor"]);
                    }
                    doc.Add(table2);
                    informacao.Clear();
                    informacao.Add("\n\n" + "Total Crédito à Vista: R$" + totalCredVista.ToString("F2"));
                    doc.Add(informacao);
                }

                //para credito parcelado ==================================================================
                PdfPTable table3 = new PdfPTable(5);

                var creditoParc = fechamento.retornarFechamentoComDevolucao("CREDITO PARCELADO", DateTime.Now.ToString("dd/MM/yyyy")
                , DateTime.Now.ToString("dd/MM/yyyy"));
                if (creditoParc.Count < 1)
                    creditoParc = fechamento.retornarFechamentoSemDevolucao("CREDITO PARCELADO", DateTime.Now.ToString("dd/MM/yyyy")
                    , DateTime.Now.ToString("dd/MM/yyyy"));

                if (creditoParc.Count > 0) {
                    metodoPagamento.Clear();
                    metodoPagamento.Add("\n\nCrédito parcelado\n\n");
                    doc.Add(metodoPagamento);

                    table3.AddCell("Data da venda");
                    table3.AddCell("Código da venda");
                    table3.AddCell("Tipo de pagamento");
                    table3.AddCell("Vendedor");
                    table3.AddCell("Valor da venda");



                    for (int i = 0; i < creditoParc.Count(); i++)
                    {
                        table3.AddCell(Convert.ToDateTime(creditoParc[i]["vendData"]).ToString("dd/MM/yyyy HH:mm:ss"));
                        table3.AddCell(creditoParc[i]["idVenda"].ToString());
                        table3.AddCell("Crédito à vista");
                        table3.AddCell("Vendedor padrão");
                        table3.AddCell("R$ " + Convert.ToDouble(creditoParc[i]["PagValor"]).ToString("F2"));
                        totalCredParc = totalCredParc + Convert.ToDouble(creditoParc[i]["PagValor"]);
                    }
                    doc.Add(table3);
                }

                informacao.Clear();
                informacao.Add("\n\n" + "Total Crédito Parcelado: R$" + totalCredParc.ToString("F2"));
                doc.Add(informacao);

                //para credito parcelado ==================================================================
                PdfPTable table4 = new PdfPTable(5);

                var debito = fechamento.retornarFechamentoComDevolucao("DEBITO", DateTime.Now.ToString("dd/MM/yyyy")
    , DateTime.Now.ToString("dd/MM/yyyy"));
                if (debito.Count < 1)
                    debito = fechamento.retornarFechamentoSemDevolucao("DEBITO", DateTime.Now.ToString("dd/MM/yyyy")
                    , DateTime.Now.ToString("dd/MM/yyyy"));

                if (debito.Count > 0)
                {
                    metodoPagamento.Clear();
                    metodoPagamento.Add("\n\nDébito\n\n");
                    doc.Add(metodoPagamento);

                    table4.AddCell("Data da venda");
                    table4.AddCell("Código da venda");
                    table4.AddCell("Tipo de pagamento");
                    table4.AddCell("Vendedor");
                    table2.AddCell("Valor da venda");



                    for (int i = 0; i < debito.Count(); i++)
                    {
                        table4.AddCell(Convert.ToDateTime(debito[i]["vendData"]).ToString("dd/MM/yyyy HH:mm:ss"));
                        table4.AddCell(debito[i]["idVenda"].ToString());
                        table4.AddCell("Débito");
                        table4.AddCell("Vendedor padrão");
                        table4.AddCell("R$ " + Convert.ToDouble(debito[i]["PagValor"]).ToString("F2"));
                        totalDebt = totalDebt + Convert.ToDouble(debito[i]["PagValor"]);
                    }
                    doc.Add(table4);

                    informacao.Clear();
                    informacao.Add("\n\n" + "Total Débito: R$" + totalDebt.ToString("F2"));
                    doc.Add(informacao);
                }
                informacao.Font = FontFactory.GetFont("Arial", 14, BaseColor.GREEN);

                informacao.Clear();
                informacao.Add("\n\nTotal das vendas: R$" + (totalDin + totalDebt + totalCredVista + totalCredParc).ToString("F2"));

                doc.Add(informacao);

                doc.Close();
                MessageBox.Show("Relatório gerado com sucesso!");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


            private void BtnSalvarPDF_Click(object sender, EventArgs e)
            {
                try
                {
                    DadosTableAdapters.DataTable2TableAdapter dadosProdutos = new DadosTableAdapters.DataTable2TableAdapter();
                    var varProd = dadosProdutos.GetDataBy1();

                    //instanciando e setando o tipo de página que vou utilizar
                    Document doc = new Document(PageSize.A4);
                    //colocando margens no pdf
                    doc.SetMargins(40, 40, 40, 80);

                    string aux = DateTime.Now.ToString("dd-MM-yyyy");

                    string caminho = @"C:\Users\bruno\Desktop\relatorios\relatorio_vendas_" + aux.ToString() + ".pdf";


                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                    doc.Open();

                    Paragraph titulo = new Paragraph();
                    titulo.Font = FontFactory.GetFont("Arial", 18);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.Add("Relatório de Vendas\n\n");
                    doc.Add(titulo);

                    PdfPTable table = new PdfPTable(4);
                    table.AddCell("Data da venda");
                    table.AddCell("Código da venda");
                    table.AddCell("Valor da venda");
                    table.AddCell("Tipo de pagamento");


                    for (int i = 0; i < varProd.Count(); i++)
                    {
                        table.AddCell(Convert.ToDateTime(varProd[i]["vendData"]).ToString("dd/MM/yyyy HH:mm:ss"));
                        table.AddCell(varProd[i]["idVenda"].ToString());
                        table.AddCell("R$ " + Convert.ToDouble(varProd[i]["valorCompra"]).ToString("F2"));
                        table.AddCell(varProd[i]["pagamentoTipo"].ToString());


                    }
                    doc.Add(table);
                    doc.Close();
                    MessageBox.Show("Relatório gerado com sucesso!");
                }
                catch (IOException er)
                {
                    MessageBox.Show("Não foi possível criar o arquivo, o mesmo pode estar sendo executado por outro programa");
                }
            }



            private void relatorioCaixaToolStripButton_Click(object sender, EventArgs e)
            {
                try
                {
                    this.caixa1TableAdapter.relatorioCaixa(this.dados.Caixa1);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }

            private void TelaDeRelatorios_Load(object sender, EventArgs e)
            {

            }

            private void relatorioCaixaToolStripButton_Click_1(object sender, EventArgs e)
            {

            }

            private void btnPerso_Click(object sender, EventArgs e)
            {

            }

            private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
            {

            }

            private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {

            }

            private void btnFechamentoDiario_Click(object sender, EventArgs e)
            {
                fechamentoCaixa();
            }
        }
    }

