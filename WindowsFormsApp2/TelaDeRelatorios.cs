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


        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable2TableAdapter.FillBy1(this.dados.DataTable2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.dataTable2TableAdapter.FillBy1(this.dados.DataTable2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable2TableAdapter.FillBy1(this.dados.DataTable2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable2TableAdapter.FillBy1(this.dados.DataTable2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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

                string caminho = @"C:\Users\bruno\Desktop\relatorios\relatorio_vendas_" + aux.ToString()+".pdf";


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
                    table.AddCell(Convert.ToDateTime(varProd[i]["vendData"]).ToString("dd/MM/yyyy HH:mm:ss.fff"));
                    table.AddCell(varProd[i]["idVenda"].ToString());
                    table.AddCell("R$ "+Convert.ToDouble(varProd[i]["valorCompra"]).ToString("F2"));
                    table.AddCell(varProd[i]["pagamentoTipo"].ToString());


                }
                doc.Add(table);
                doc.Close();
                MessageBox.Show("Relatório gerado com sucesso!");
            }catch(IOException er)
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
            try
            {
                try
                {
                    DadosTableAdapters.CaixaTableAdapter caixa = new DadosTableAdapters.CaixaTableAdapter();
                    var idCaixa = caixa.pegarIDUltimoCaixa();
                    var aux1 = caixa.pegarCaixaCompleto();

                    //instanciando e setando o tipo de página que vou utilizar
                    Document doc = new Document(PageSize.A4);
                    //colocando margens no pdf
                    doc.SetMargins(40, 40, 40, 80);

                    string aux = DateTime.Now.ToString("dd-MM-yyyy");

                    string caminho = @"C:\Users\bruno\Desktop\relatorios\relatorio_caixa_" + aux.ToString() + ".pdf";


                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

                    doc.Open();

                    Paragraph titulo = new Paragraph();
                    titulo.Font = FontFactory.GetFont("Arial", 18);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.Add("Relatório de caixas\n\n");
                    doc.Add(titulo);

                    PdfPTable table = new PdfPTable(6);
                    table.AddCell("Data da caixa");
                    table.AddCell("Código do caixa");
                    table.AddCell("Valor incial do caixa");
                    table.AddCell("Valor total do caixa");
                    table.AddCell("Valor final do caixa");
                    table.AddCell("Estado do caixa");


                    for (int i = 0; i < aux1.Count(); i++)
                    {
                        table.AddCell(Convert.ToDateTime(aux1[i]["dataCaixa"]).ToString("dd/MM/yyyy HH:mm:ss.fff"));
                        table.AddCell(aux1[i]["idCaixa"].ToString());
                        table.AddCell("R$ " + Convert.ToDouble(aux1[i]["aberturaCaixa"]).ToString("F2"));
                        table.AddCell("R$ " + Convert.ToDouble(aux1[i]["valorAtual"]).ToString("F2"));
                        table.AddCell("R$ " + Convert.ToDouble(aux1[i]["fechamentoCaixa"]).ToString("F2"));
                        if (Convert.ToInt32(aux1[i]["estadoCaixa"]) == 0)
                            table.AddCell("Fechado");
                        else
                            table.AddCell("Aberto");
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
    }
}
