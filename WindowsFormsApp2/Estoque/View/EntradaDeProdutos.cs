using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Estoque.View;


namespace WindowsFormsApp2
{
    public partial class EntradaDeProdutos : UserControl
    {
        DadosTableAdapters.ItensDeEntradaTableAdapter entradas = new DadosTableAdapters.ItensDeEntradaTableAdapter();
        string dataPesquisa1;
        string dataPesquisa2;
        DateTime data;


        public EntradaDeProdutos()
        {
            dataPesquisa1 = DateTime.Now.ToString("dd-MM-yyyy");
            dataPesquisa2 = DateTime.Now.AddMonths(-1).ToString();

            InitializeComponent();
            carregarEntradas();
        }
        public void carregarEntradas()
        {

            listaEntradas.Items.Clear();
            var varEntradas = entradas.retornarEntradas(dataPesquisa1, dataPesquisa2);

            for (int i = 0; i < varEntradas.Count; i++)
            {
                //num entrada, data, funcionario, obs

                //MessageBox.Show("id1: " + varEntradas[j]["idSecundarioItensEntrada"] + "id2: " + varEntradas[i]["idSecundarioItensEntrada"]);

                ListViewItem item = new ListViewItem();
                var auxEntradas = entradas.retornarEntradaPorId(Convert.ToInt32(varEntradas[i]["idSecundarioItensEntrada"]));

                item.SubItems.Add(auxEntradas[i]["idSecundarioItensEntrada"].ToString());
                item.SubItems.Add(Convert.ToDateTime(auxEntradas[i]["dataEntrada"]).ToString("dd/MM/yyyy") + " " + auxEntradas[i]["horaEntrada"].ToString().Substring(0, 5));
                item.SubItems.Add("Funcionario padrão");
                if (auxEntradas[i]["observacoes"].ToString().Length >= 69)
                    item.SubItems.Add(auxEntradas[i]["observacoes"].ToString().Substring(0, 69));
                else
                    item.SubItems.Add(auxEntradas[i]["observacoes"].ToString());
                listaEntradas.Items.Add(item);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntrarProd_Click(object sender, EventArgs e)
        {
            TelaDeEntradaProduto telaEntrada = new TelaDeEntradaProduto();
            telaEntrada.ShowDialog();
            carregarEntradas();
        }

        private void listaEntradas_DoubleClick(object sender, EventArgs e)
        {
            TelaDeEntradaProduto tela = new TelaDeEntradaProduto(false, Convert.ToInt32(listaEntradas.SelectedItems[0].SubItems[1].Text));
            tela.ShowDialog();
        }

        private void btnHoje_Click(object sender, EventArgs e)
        {
            dataPesquisa1 = DateTime.Now.ToString("dd-MM-yyyy");
            dataPesquisa2 = DateTime.Now.ToString("dd-MM-yyyy");
            carregarEntradas();
        }

        private void btnOntem_Click(object sender, EventArgs e)
        {
            dataPesquisa1 = DateTime.Now.ToString("dd/MM/yyyy");
            dataPesquisa2 = DateTime.Now.AddDays(-1).ToString();
            carregarEntradas();
        }

        private void btn7Dias_Click(object sender, EventArgs e)
        {
            dataPesquisa1 = DateTime.Now.ToString("dd/MM/yyyy");
            dataPesquisa2 = DateTime.Now.AddDays(-7).ToString();
            carregarEntradas();
        }

        private void btnEsteMes_Click(object sender, EventArgs e)
        {
            dataPesquisa1 = DateTime.Now.ToString("dd/MM/yyyy");
            dataPesquisa2 = DateTime.Now.ToString("01/MM/yyyy");
            carregarEntradas();
        }

        private void btnMesPassado_Click(object sender, EventArgs e)
        {

            //DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));

            var data = DateTime.Now.AddMonths(-1);
            var ultimoDia = DateTime.DaysInMonth(data.Year, data.Month);
            var dataUltimoDia = new DateTime(data.Year, data.Month, ultimoDia);

            dataPesquisa1 = (dataUltimoDia.ToString("01/MM/yyyy"));
            dataPesquisa2 = (dataUltimoDia.ToString("dd/MM/yyyy"));

        }

        private void btnUltimos3Meses_Click(object sender, EventArgs e)
        {

            var data = DateTime.Now.AddMonths(-3);

            dataPesquisa1 = (DateTime.Now.ToString());
            dataPesquisa2 = (data.ToString("dd/MM/yyyy"));

        }

        private void btnPerso_Click(object sender, EventArgs e)
        {

        }
    }
}
