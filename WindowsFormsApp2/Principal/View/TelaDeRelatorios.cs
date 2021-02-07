using System;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing;

namespace WindowsFormsApp2
{
    public partial class TelaDeRelatorios : UserControl
    {
        bool existeDiretorio = Directory.Exists(@"C:\pdv\relatorios");
        DateTime deData = DateTime.Now;
        DateTime ateData = DateTime.Now;
        int selecionado = 0;
        string imprimir;

        public TelaDeRelatorios()
        {
            InitializeComponent();
            if (!existeDiretorio)
            {
                Directory.CreateDirectory(@"C:\pdv\relatorios");
            }

        }

        private void fechamentoDiario()
        {
            try
            {
                selecionado = 1;

                DadosTableAdapters.CaixaTableAdapter caixa = new DadosTableAdapters.CaixaTableAdapter();
                double totalDin = 0, totalCredVista = 0, totalCredParc = 0, totalDebt = 0, descontoDevolucao = 0;
                DadosTableAdapters.DataTable2TableAdapter fechamento = new DadosTableAdapters.DataTable2TableAdapter();

                DadosTableAdapters.Observacoes_SangriaTableAdapter sangria = new DadosTableAdapters.Observacoes_SangriaTableAdapter();

                //var varProd = fechamento.relatorio();

                //instanciando e setando o tipo de página que vou utilizar
                Document doc = new Document(PageSize.A4);
                //colocando margens no pdf
                doc.SetMargins(40, 40, 40, 80);

                string aux = deData.ToString("dd-MM-yyyy") + " - " + ateData.ToString("dd-MM-yyyy");

                string caminho = @"C:\pdv\relatorios\fechamento diario-" + aux.ToString() + ".pdf";


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

                relatorioVendas(false, doc, informacao, titulo, metodoPagamento);

                /***************************************************************************************/
                /*****************************      Devoluções     *************************************/
                /***************************************************************************************/


                doc = relatorioDevolucoes(false, doc, informacao, titulo, metodoPagamento);

                /***************************************************************************************/
                /*****************************  Vendas Canceladas  *************************************/
                /***************************************************************************************/

                doc = relatorioVendasCanceladas(false, doc, informacao, titulo);


                /***************************************************************************************/
                /*****************************     Caixa Atual     *************************************/
                /***************************************************************************************/


               /* doc = caixaAtual(false, doc, informacao, titulo);*/

                /***************************************************************************************/
                /*****************************       Sangria       *************************************/
                /***************************************************************************************/
                doc = relatorioSangria(false, doc, informacao, titulo);

                doc.Close();
                //MessageBox.Show("Relatório gerado com sucesso!");
                abrirPdf(caminho);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        public Document relatorioVendas(bool tipo = false, Document doc = null, Paragraph informacao = null, Paragraph titulo = null, Paragraph metodoPagamento = null)
        {
            selecionado = 2;
            string caminho = "";
            DadosTableAdapters.CaixaTableAdapter caixa = new DadosTableAdapters.CaixaTableAdapter();
            double totalDin = 0, totalCredVista = 0, totalCredParc = 0, totalDebt = 0, descontoDevolucao = 0;
            DadosTableAdapters.DataTable2TableAdapter fechamento = new DadosTableAdapters.DataTable2TableAdapter();

            DadosTableAdapters.Observacoes_SangriaTableAdapter sangria = new DadosTableAdapters.Observacoes_SangriaTableAdapter();
            if (tipo)
            {
                //var varProd = fechamento.relatorio();

                //instanciando e setando o tipo de página que vou utilizar
                Document docLimpo = new Document(PageSize.A4);

                //colocando margens no pdf
                docLimpo.SetMargins(40, 40, 40, 80);
                doc = docLimpo;
                string aux = deData.ToString("dd-MM-yyyy") + " - " + ateData.ToString("dd-MM-yyyy");

                caminho = @"C:\pdv\relatorios\vendas-" + aux.ToString() + ".pdf";


                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                doc.Open();

                Paragraph tituloLimpo = new Paragraph();
                titulo = tituloLimpo;
                titulo.Font = FontFactory.GetFont("Arial", 18);
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.Add("Vendas " + deData.ToString("dd/MM/yyyy") + " - " + ateData.ToString("dd/MM/yyyy") + " \n\n");
                doc.Add(titulo);

                Paragraph informacaoLimpo = new Paragraph();
                informacao = informacaoLimpo;
                informacao.Font = FontFactory.GetFont("Arial", 12, BaseColor.BLUE);
                informacao.Alignment = Element.ALIGN_LEFT;

                Paragraph metodoPagamentoLimpo = new Paragraph();
                metodoPagamento = metodoPagamentoLimpo;
                metodoPagamento.Font = FontFactory.GetFont("Arial", 14);
                metodoPagamento.Alignment = Element.ALIGN_LEFT;
            }
            //para o dinheiro==================================================================
            /*var dinheiro = fechamento.retornarFechamentoComDevolucao("DINHEIRO", DateTime.Now.ToString("dd/MM/yyyy")
                , DateTime.Now.ToString("dd/MM/yyyy"));
            if (dinheiro.Count < 1)*/
            var dinheiro = fechamento.retornarFechamentoSemDevolucao("DINHEIRO", deData.ToString("dd/MM/yyyy"), ateData.ToString("dd/MM/yyyy"));

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
                    table.AddCell(Convert.ToDateTime(dinheiro[i]["vendData"]).ToString("dd/MM/yyyy"));
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
            var creditoVista = fechamento.retornarFechamentoSemDevolucao("CREDITO A VISTA", deData.ToString("dd/MM/yyyy"), ateData.ToString("dd/MM/yyyy"));

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

            var creditoParc = fechamento.retornarFechamentoSemDevolucao("CREDITO PARCELADO", deData.ToString("dd/MM/yyyy")
                , ateData.ToString("dd/MM/yyyy"));

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
            var debito = fechamento.retornarFechamentoSemDevolucao("DEBITO", deData.ToString("dd/MM/yyyy")
            , ateData.ToString("dd/MM/yyyy"));

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
                    table4.AddCell(Convert.ToDateTime(debito[i]["vendData"]).ToString("dd/MM/yyyy") + " " + Convert.ToDateTime(debito[i]["vendData"]).ToString("HH:mm:ss"));
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

            if (tipo)
            {
                doc.Close();
                abrirPdf(caminho);
                //                MessageBox.Show("Relatório gerado com sucesso!");
            }
            return doc;
        }

        public Document relatorioDevolucoes(bool tipo = false, Document doc = null, Paragraph informacao = null, Paragraph titulo = null, Paragraph metodoPagamento = null)
        {
            selecionado = 3;
            string caminho = "";
            if (tipo)
            {
                Document docLimpo = new Document(PageSize.A4);

                //colocando margens no pdf
                docLimpo.SetMargins(40, 40, 40, 80);
                doc = docLimpo;
                string aux = deData.ToString("dd-MM-yyyy") + " - " + ateData.ToString("dd-MM-yyyy");

                caminho = @"C:\pdv\relatorios\devolucoes-" + aux.ToString() + ".pdf";


                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                doc.Open();

                Paragraph tituloLimpo = new Paragraph();
                titulo = tituloLimpo;
                titulo.Font = FontFactory.GetFont("Arial", 18);
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.Add("Devoluções " + deData.ToString("dd/MM/yyyy") + " - " + ateData.ToString("dd/MM/yyyy") + " \n\n");
                doc.Add(titulo);

                Paragraph informacaoLimpo = new Paragraph();
                informacao = informacaoLimpo;
                informacao.Font = FontFactory.GetFont("Arial", 12, BaseColor.BLUE);
                informacao.Alignment = Element.ALIGN_LEFT;

                Paragraph metodoPagamentoLimpo = new Paragraph();
                metodoPagamento = metodoPagamentoLimpo;
                metodoPagamento.Font = FontFactory.GetFont("Arial", 14);
                metodoPagamento.Alignment = Element.ALIGN_LEFT;

            }
            informacao.Font = FontFactory.GetFont("Arial", 14, BaseColor.RED);

            DadosTableAdapters.Itens_DevolucaoTableAdapter auxDevo = new DadosTableAdapters.Itens_DevolucaoTableAdapter();
            DadosTableAdapters.ItensDaVendaTableAdapter auxItensVenda = new DadosTableAdapters.ItensDaVendaTableAdapter();
            var devolucao = auxDevo.retornarDevolucoes(Convert.ToDateTime(deData.ToString("dd/MM/yyyy")), Convert.ToDateTime(ateData.ToString("dd/MM/yyyy")));
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
            if (tipo)
            {
                doc.Close();
                abrirPdf(caminho);
                //MessageBox.Show("Relatório gerado com sucesso!");
            }
            return doc;
        }

        public Document relatorioVendasCanceladas(bool tipo = false, Document doc = null, Paragraph informacao = null, Paragraph titulo = null)
        {
            selecionado = 4;
            string caminho = "";
            DadosTableAdapters.Vendas_CanceladasTableAdapter venda = new DadosTableAdapters.Vendas_CanceladasTableAdapter();
            var vendasCanceladas = venda.retornarCancelamentosPorData(deData.ToString("dd/MM/yyyy"), ateData.ToString("dd/MM/yyyy"));
            if (tipo) {
                Document docLimpo = new Document(PageSize.A4);

                //colocando margens no pdf
                docLimpo.SetMargins(40, 40, 40, 80);
                doc = docLimpo;
                string aux = deData.ToString("dd-MM-yyyy") + " - " + ateData.ToString("dd-MM-yyyy");

                caminho = @"C:\pdv\relatorios\vendas-canceladas-" + aux.ToString() + ".pdf";


                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                doc.Open();

                Paragraph tituloLimpo = new Paragraph();
                titulo = tituloLimpo;
                titulo.Font = FontFactory.GetFont("Arial", 18);
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.Add("Vendas Canceladas " + deData.ToString("dd/MM/yyyy") + " - " + ateData.ToString("dd/MM/yyyy") + " \n\n");
                doc.Add(titulo);

                Paragraph informacaoLimpo = new Paragraph();
                informacao = informacaoLimpo;
                informacao.Font = FontFactory.GetFont("Arial", 12, BaseColor.BLUE);
                informacao.Alignment = Element.ALIGN_LEFT;
            }
            if (vendasCanceladas.Count > 0)
            {
                DadosTableAdapters.PagamentoTableAdapter pagamento = new DadosTableAdapters.PagamentoTableAdapter();

                PdfPTable table6 = new PdfPTable(4);
                table6.AddCell("Código da Venda");
                table6.AddCell("Data da Venda");
                table6.AddCell("Data do Cancelamento");
                table6.AddCell("Valor da Venda");
                for (int i = 0; i < vendasCanceladas.Count; i++)
                {
                    table6.AddCell(vendasCanceladas[i]["idVenda"].ToString());
                    table6.AddCell(Convert.ToDateTime(vendasCanceladas[i]["dataVenda"]).ToString("dd/MM/yyyy"));
                    table6.AddCell(Convert.ToDateTime(vendasCanceladas[i]["dataCancelamento"]).ToString("dd/MM/yyyy"));
                    //+" "+        Convert.ToDateTime(vendasCanceladas[i]["horaCancelamento"]).ToString("HH:mm:ss")
                    var desconto = pagamento.retornarDescPorIdVenda(Convert.ToInt32(vendasCanceladas[i]["idVenda"]));
                    table6.AddCell("R$" + Convert.ToDouble(Convert.ToDouble(vendasCanceladas[i]["valorDaVenda"])).ToString("F2"));
                }
                informacao.Clear();
                informacao.Add("\n\nVendas Canceladas \n\n");
                doc.Add(informacao);

                doc.Add(table6);
            }
            if (tipo)
            {
                doc.Close();
                abrirPdf(caminho);
                //MessageBox.Show("Relatório gerado com sucesso!");
            }
            return doc;
        }
        public Document relatorioSangria(bool tipo = false, Document doc = null, Paragraph informacao = null, Paragraph titulo = null)
        {
            selecionado = 5;
            string caminho = "";
            DadosTableAdapters.Observacoes_SangriaTableAdapter sangria = new DadosTableAdapters.Observacoes_SangriaTableAdapter();
            if (tipo)
            {
                Document docLimpo = new Document(PageSize.A4);
                
                //colocando margens no pdf
                docLimpo.SetMargins(40, 40, 40, 80);
                doc = docLimpo;
                string aux = deData.ToString("dd-MM-yyyy") + " - " + ateData.ToString("dd-MM-yyyy");

                caminho = @"C:\pdv\relatorios\sangria-" + aux.ToString() + ".pdf";


                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                doc.Open();

                Paragraph tituloLimpo = new Paragraph();
                titulo = tituloLimpo;
                titulo.Font = FontFactory.GetFont("Arial", 18);
                titulo.Alignment = Element.ALIGN_CENTER;
                titulo.Add("Sangria "+deData.ToString("dd/MM/yyyy")+" - "+ateData.ToString("dd/MM/yyyy") + " \n\n");
                doc.Add(titulo);

                Paragraph informacaoLimpo = new Paragraph();
                informacao = informacaoLimpo;
                informacao.Font = FontFactory.GetFont("Arial", 12, BaseColor.BLUE);
                informacao.Alignment = Element.ALIGN_LEFT;
            }
                informacao.Clear();
                informacao.Add("\n\n" + ("Sangria")+ "\n\n");
                doc.Add(informacao);
                var auxSangria = sangria.retornarSangriaPorData(deData.ToString("dd/MM/yyyy"), ateData.ToString("dd/MM/yyyy"));
                DadosTableAdapters.FuncionarioTableAdapter funcionario = new DadosTableAdapters.FuncionarioTableAdapter();
                if (auxSangria.Count > 0)
                {
                    informacao.Font = FontFactory.GetFont("Arial", 14, BaseColor.RED);
                    informacao.Clear();

                    PdfPTable table7 = new PdfPTable(4);
                    table7.AddCell("Data da Sangria");
                    table7.AddCell("Colaborador");
                    table7.AddCell("Observações");
                    table7.AddCell("Valor da sangria");
                    for (int i = 0; i < auxSangria.Count; i++)
                    {
                        table7.AddCell(Convert.ToDateTime(auxSangria[i]["dataSangria"]).ToString("dd/MM/yyyy")+"  "+auxSangria[i]["horaSangria"].ToString().Substring(0, 5));
                        var auxFunc = funcionario.retornarColaboradorPorId(Convert.ToInt32(auxSangria[i]["idColaborador"]));
                        table7.AddCell(auxFunc[0]["nomeFunc"].ToString());
                        table7.AddCell(auxSangria[i]["observacoes"].ToString());
                        table7.AddCell("R$"+ Convert.ToDouble(auxSangria[i]["valorSangria"]).ToString("F2"));
                        
                        //var desconto = pagamento.retornarDescPorIdVenda(Convert.ToInt32(vendasCanceladas[i]["idVenda"]));
                        //table7.AddCell("R$" + Convert.ToDouble(Convert.ToDouble(vendasCanceladas[i]["valorDaVenda"])));
                    }
                    doc.Add(table7);
            }
            if (tipo)
            {
                doc.Close();
                abrirPdf(caminho);
                //MessageBox.Show("Relatório gerado com sucesso!");
            }
            return doc;
        }
        public Document caixaAtual(bool tipo, Document doc = null, Paragraph informacao = null, Paragraph titulo = null)
        {
            selecionado = 6;
            string caminho = "";
            DadosTableAdapters.CaixaTableAdapter caixa = new DadosTableAdapters.CaixaTableAdapter();
            if (tipo)
            {
                Document docLimpo = new Document(PageSize.A4);

                //colocando margens no pdf
                docLimpo.SetMargins(40, 40, 40, 80);
                doc = docLimpo;
                string aux = deData.ToString("dd-MM-yyyy") + " - " + ateData.ToString("dd-MM-yyyy");

                caminho = @"C:\pdv\relatorios\caixa-" + aux.ToString() + ".pdf";


                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                doc.Open();
                Paragraph tituloLimpo = new Paragraph();
                titulo = tituloLimpo;
                titulo.Font = FontFactory.GetFont("Arial", 18);
                titulo.Alignment = Element.ALIGN_CENTER;/*
                titulo.Add("Caixa Atual " + deData.ToString("dd/MM/yyyy") + " - " + ateData.ToString("dd/MM/yyyy") + " \n\n");
                */
                titulo.Add("Caixa Atual " + DateTime.Now.ToString("dd/MM/yyyy") + " \n\n");

                doc.Add(titulo);

                Paragraph informacaoLimpo = new Paragraph();
                informacao = informacaoLimpo;
                informacao.Font = FontFactory.GetFont("Arial", 12, BaseColor.BLUE);
                informacao.Alignment = Element.ALIGN_LEFT;
            }

            informacao.Clear();
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

            doc.Add(informacao);
            if (tipo)
            {
                doc.Close();
                abrirPdf(caminho);

                //MessageBox.Show("Relatório gerado com sucesso!");
            }
            return doc;
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


        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnFechamentoDiario_Click(object sender, EventArgs e)
        {
            if(deData != null)
            {
                fechamentoDiario();
            }
            else
            {
                MessageBox.Show("Selecione um perído primeiro");
            }
            
        }

        public void salvarRelatorio()
        {

        }
        private void alterarCor()
        {
            btnHoje.BackColor = Color.Gainsboro;
            btnOntem.BackColor = Color.Gainsboro;
            btn7Dias.BackColor = Color.Gainsboro;
            btnEsteMes.BackColor = Color.Gainsboro;
            btnMesPassado.BackColor = Color.Gainsboro;
            btnUltimos3Meses.BackColor = Color.Gainsboro;
            btnPerso.BackColor = Color.Gainsboro;
        }
        private void btnHoje_Click(object sender, EventArgs e)
        {
            deData = DateTime.Now;
            ateData = DateTime.Now;
            alterarCor();
            btnHoje.BackColor = Color.Gray;
        }
        public void hoje()
        {
            deData = DateTime.Now;
            ateData = DateTime.Now;
            alterarCor();
            btnHoje.BackColor = Color.Gray;
        }
        private void btnOntem_Click(object sender, EventArgs e)
        {
            ateData = DateTime.Now.AddDays(-1);
            deData = DateTime.Now.AddDays(-1);
            alterarCor();
            btnOntem.BackColor = Color.Gray;
        }

        private void btn7Dias_Click(object sender, EventArgs e)
        {
            deData = DateTime.Now.AddDays(-7);
            ateData = DateTime.Now;
            alterarCor();
            btn7Dias.BackColor = Color.Gray;
        }

        private void btnEsteMes_Click(object sender, EventArgs e)
        {
            ateData = DateTime.Now;
            deData = DateTime.Now;
            alterarCor();
            btnEsteMes.BackColor = Color.Gray;
        }

        private void btnMesPassado_Click(object sender, EventArgs e)
        {

            //DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));



            var data = DateTime.Now.AddMonths(-1);
            var ultimoDia = DateTime.DaysInMonth(data.Year, data.Month);
            var dataUltimoDia = new DateTime(data.Year, data.Month, ultimoDia); //possibilidade de remoção desta linha

            ateData = dataUltimoDia;
            deData = dataUltimoDia;

            alterarCor();
            btnMesPassado.BackColor = Color.Gray;
        }

        private void btnUltimos3Meses_Click(object sender, EventArgs e)
        {

            var data = DateTime.Now.AddMonths(-3);

            ateData = DateTime.Now;
            deData = data;
            alterarCor();
            btnUltimos3Meses.BackColor = Color.Gray;
        }

        private void btnPerso_Click(object sender, EventArgs e)
        {
            alterarCor();
            btnPerso.BackColor = Color.Gray;
            DateTime a, b;
            if (DateTime.TryParse(txtBoxDeMes.Text, out a) && DateTime.TryParse(txtBoxAteMes.Text, out b) && b > a)
            {
                deData = a;
                ateData = b;
            }
            else
                MessageBox.Show("Datas invalidas");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnRelatorioCaixa_Click(object sender, EventArgs e)
        {
            caixaAtual(true);
        }

        private void btnSangria_Click(object sender, EventArgs e)
        {
            relatorioSangria(true);
        }

        private void btnFechamentoDiario_Click_1(object sender, EventArgs e)
        {
            fechamentoDiario();
        }

        private void btnRelatorioDevolucoes_Click(object sender, EventArgs e)
        {
            relatorioDevolucoes(true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            relatorioVendas(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abrirPdf();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            relatorioVendasCanceladas(true);
        }
        public void limpaSelecionado()
        {
            selecionado = 0;

        }
         public void abrirPdf(string dir)
        {
            imprimir = dir;
            OpenFileDialog file = new OpenFileDialog();
            file.FileName = dir;

            axAcroPDF1.LoadFile(file.FileName);
        }
        public void fecharPdf()
        {
            axAcroPDF1.Dispose();
        }
    }
}
