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
            informacao.Font = FontFactory.GetFont("Arial", 12);
            informacao.Alignment = Element.ALIGN_LEFT;

            doc.Add(informacao);

            Paragraph metodoPagamento = new Paragraph();
            metodoPagamento.Font = FontFactory.GetFont("Arial", 14);
            metodoPagamento.Alignment = Element.ALIGN_LEFT;
            //metodoPagamento.add();
            doc.Add(metodoPagamento);

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
    }
}

