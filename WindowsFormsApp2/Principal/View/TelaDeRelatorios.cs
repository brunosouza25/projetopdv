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
        bool existeDiretorio = Directory.Exists(@"C:\relatorios");

        public TelaDeRelatorios()
        {
            InitializeComponent();
            if (!existeDiretorio)
            {
                Directory.CreateDirectory(@"C:\relatorios");
            }

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

                    string caminho = @"C:\relatorios\relatorio_" + aux.ToString() + ".pdf";


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
                DadosTableAdapters.CaixaTableAdapter caixa = new DadosTableAdapters.CaixaTableAdapter();
                var varProd = fechamento.relatorio();
                //instanciando e setando o tipo de página que vou utilizar
                Document doc = new Document(PageSize.A4);
                //colocando margens no pdf
                doc.SetMargins(40, 40, 40, 80);

                string aux = DateTime.Now.ToString("dd-MM-yyyy");

                string caminho = @"C:\relatorios\fechamento" + aux.ToString() + ".pdf";


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
                /*var dinheiro = fechamento.retornarFechamentoComDevolucao("DINHEIRO", DateTime.Now.ToString("dd/MM/yyyy")
                    , DateTime.Now.ToString("dd/MM/yyyy"));
                if (dinheiro.Count < 1)*/
                var dinheiro = fechamento.retornarFechamentoSemDevolucao("DINHEIRO", DateTime.Now.ToString("dd/MM/yyyy")
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

                /*var creditoVista = fechamento.retornarFechamentoComDevolucao("CREDITO A VISTA", DateTime.Now.ToString("dd/MM/yyyy")
                , DateTime.Now.ToString("dd/MM/yyyy"));
                if (creditoVista.Count < 1)*/
                var creditoVista = fechamento.retornarFechamentoSemDevolucao("CREDITO A VISTA", DateTime.Now.ToString("dd/MM/yyyy")
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
                        table2.AddCell("R$ " + Convert.ToDouble(creditoVista[i]["PagValor"]).ToString("F2"));
                        totalCredVista = totalCredVista + Convert.ToDouble(creditoVista[i]["PagValor"]);
                    }
                    doc.Add(table2);
                    informacao.Clear();
                    informacao.Add("\n\n" + "Total Crédito à Vista: R$" + totalCredVista.ToString("F2"));
                    doc.Add(informacao);
                }

                //para credito parcelado ==================================================================
                PdfPTable table3 = new PdfPTable(5);

                /* var creditoParc = fechamento.retornarFechamentoComDevolucao("CREDITO PARCELADO", DateTime.Now.ToString("dd/MM/yyyy")
                 , DateTime.Now.ToString("dd/MM/yyyy"));
                 if (creditoParc.Count < 1)*/

                var creditoParc = fechamento.retornarFechamentoSemDevolucao("CREDITO PARCELADO", DateTime.Now.ToString("dd/MM/yyyy")
                    , DateTime.Now.ToString("dd/MM/yyyy"));

                if (creditoParc.Count > 0)
                {
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
                    informacao.Clear();
                    informacao.Add("\n\n" + "Total Crédito Parcelado: R$" + totalCredParc.ToString("F2"));
                    doc.Add(informacao);
                }



                //para credito débito ==================================================================
                PdfPTable table4 = new PdfPTable(5);

                /*var debito = fechamento.retornarFechamentoComDevolucao("DEBITO", DateTime.Now.ToString("dd/MM/yyyy")
    , DateTime.Now.ToString("dd/MM/yyyy"));
                if (debito.Count < 1)*/
                var debito = fechamento.retornarFechamentoSemDevolucao("DEBITO", DateTime.Now.ToString("dd/MM/yyyy")
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
                    table4.AddCell("Valor da venda");



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
                informacao.Clear();

                informacao.Font = FontFactory.GetFont("Arial", 14, BaseColor.RED);

                DadosTableAdapters.Itens_DevolucaoTableAdapter auxDevo = new DadosTableAdapters.Itens_DevolucaoTableAdapter();
                DadosTableAdapters.ItensDaVendaTableAdapter auxItensVenda = new DadosTableAdapters.ItensDaVendaTableAdapter();
                var devolucao = auxDevo.retornarDevolucoes(Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")), Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")));
                if (devolucao.Count > 0)
                {
                    DadosTableAdapters.ProdutoTableAdapter dadosProduto = new DadosTableAdapters.ProdutoTableAdapter();
                    PdfPTable table5 = new PdfPTable(4);
                    table5.AddCell("Código da devolução");
                    table5.AddCell("Código da Venda");
                    table5.AddCell("Produto");
                    table5.AddCell("Quantidade");

                    double totalDevolucao = 0;

                    for (int i = 0; i < devolucao.Count; i++)
                    {
                        metodoPagamento.Clear();
                        metodoPagamento.Add("\n\nDevoluções\n\n");
                        doc.Add(metodoPagamento);
                        //planejar melhor essa parte de colocar os itens devolvidos no fechamento.
                        table5.AddCell(devolucao[i]["idItensDevolucao"].ToString());

                        table5.AddCell(devolucao[i]["idVenda"].ToString());

                        var produto = dadosProduto.retornarProdutoPorId(Convert.ToInt32(devolucao[i]["idProduto"]));

                        table5.AddCell(produto[0]["prodNome"].ToString());

                        table5.AddCell(devolucao[i]["quantidadeDevolucao"].ToString());

                        
                        totalDevolucao += Convert.ToDouble(devolucao[i]["valorProduto"]);
                    }
                    doc.Add(table5);
                    informacao.Add("\n\nDevoluções: R$-" + totalDevolucao.ToString("F2"));
                    doc.Add(informacao);
                }

                /***************************************************************************************/

                DadosTableAdapters.Vendas_CanceladasTableAdapter venda = new DadosTableAdapters.Vendas_CanceladasTableAdapter();
                var vendasCanceladas = venda.retornarCancelamentosPorData(DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("dd/MM/yyyy"));

                if(vendasCanceladas.Count > 0)
                {
                    DadosTableAdapters.PagamentoTableAdapter pagamento = new DadosTableAdapters.PagamentoTableAdapter();

                    PdfPTable table6 = new PdfPTable(4);
                    table6.AddCell("Código da Venda");
                    table6.AddCell("Data da Venda");
                    table6.AddCell("Data do Cancelamento");
                    table6.AddCell("Valor da Venda");
                    for(int i = 0;  i < vendasCanceladas.Count; i++)
                    {
                        table6.AddCell(vendasCanceladas[i]["idVenda"].ToString());
                        table6.AddCell(vendasCanceladas[i]["dataVenda"].ToString());
                        table6.AddCell(vendasCanceladas[i]["dataCancelamento"].ToString());
                        var desconto = pagamento.retornarDescPorIdVenda(Convert.ToInt32(vendasCanceladas[i]["idVenda"]));
                        table6.AddCell("R$"+Convert.ToDouble(Convert.ToDouble(vendasCanceladas[i]["valorDaVenda"])));
                    }
                    informacao.Clear();
                    informacao.Add("\n\nVendas Canceladas \n\n" );
                    doc.Add(informacao);

                    doc.Add(table6);
                }

                /***************************************************************************************/

                informacao.Clear();
                informacao.Add("\n\n" + (totalDin + totalDebt + totalCredVista + totalCredParc).ToString("F2"));


                var caixaAtual = caixa.pegarCaixaPorData(DateTime.Now.ToString("dd/MM/yyyy"));
                if (caixaAtual.Count > 0)
                {
                    informacao.Font = FontFactory.GetFont("Arial", 14, BaseColor.GRAY);
                    informacao.Clear();
                    informacao.Add("\n\nCaixa Atual: R$" + Convert.ToDouble(caixaAtual[0]["valorAtual"]).ToString("F2"));
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

                string caminho = @"C:\relatorios\relatorio_vendas_" + aux.ToString() + ".pdf";


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

        private void btnHoje_Click(object sender, EventArgs e)
        {

        }
    }
}

