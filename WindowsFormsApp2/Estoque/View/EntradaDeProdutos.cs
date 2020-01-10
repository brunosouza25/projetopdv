using System;
using System.Windows.Forms;
using WindowsFormsApp2.Estoque.View;


namespace WindowsFormsApp2
{
    public partial class EntradaDeProdutos : UserControl
    {
        DadosTableAdapters.ItensDeEntradaTableAdapter entradas = new DadosTableAdapters.ItensDeEntradaTableAdapter();
        string deData;
        string ateData;

        public EntradaDeProdutos()
        {
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            deData = DateTime.Now.AddMonths(-1).ToString("dd/MM/yyyy");

            InitializeComponent();
            carregarEntradas();
        }
        public void carregarEntradas()
        {

            listaEntradas.Items.Clear();
            var varEntradas = entradas.retornarEntradas(deData, ateData);

            for (int i = 0; i <= varEntradas.Count - 1; i++)
            {
                //num entrada, data, funcionario, obs

                //MessageBox.Show("id1: " + varEntradas[j]["idSecundarioItensEntrada"] + "id2: " + varEntradas[i]["idSecundarioItensEntrada"]);

                ListViewItem item = new ListViewItem();
                var auxEntradas = entradas.retornarEntradaPorId(Convert.ToInt32(varEntradas[i]["idSecundarioItensEntrada"]));

                item.SubItems.Add(auxEntradas[0]["idSecundarioItensEntrada"].ToString());
                item.SubItems.Add(Convert.ToDateTime(auxEntradas[0]["dataEntrada"]).ToString("dd/MM/yyyy") + " " + auxEntradas[0]["horaEntrada"].ToString().Substring(0, 5));
                item.SubItems.Add("Funcionario padrão");
                if (auxEntradas[0]["observacoes"].ToString().Length >= 69)
                    item.SubItems.Add(auxEntradas[0]["observacoes"].ToString().Substring(0, 69));
                else
                    item.SubItems.Add(auxEntradas[0]["observacoes"].ToString());
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
            carregarEntradas();
        }

        private void btnHoje_Click(object sender, EventArgs e)
        {
            deData = DateTime.Now.ToString("dd/MM/yyyy");
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            carregarEntradas();
        }

        private void btnOntem_Click(object sender, EventArgs e)
        {
            ateData = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
            deData = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
            carregarEntradas();
        }

        private void btn7Dias_Click(object sender, EventArgs e)
        {
            deData = DateTime.Now.AddDays(-7).ToString("dd/MM/yyyy");
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            carregarEntradas();
        }

        private void btnEsteMes_Click(object sender, EventArgs e)
        {
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            deData = DateTime.Now.ToString("01/MM/yyyy");
            carregarEntradas();
        }

        private void btnMesPassado_Click(object sender, EventArgs e)
        {

            //DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));



            var data = DateTime.Now.AddMonths(-1);
            var ultimoDia = DateTime.DaysInMonth(data.Year, data.Month);
            var dataUltimoDia = new DateTime(data.Year, data.Month, ultimoDia); //possibilidade de remoção desta linha

            ateData = (dataUltimoDia.ToString("01/MM/yyyy"));
            deData = (dataUltimoDia.ToString("dd/MM/yyyy"));
            carregarEntradas();

        }

        private void btnUltimos3Meses_Click(object sender, EventArgs e)
        {

            var data = DateTime.Now.AddMonths(-3);

            ateData = (DateTime.Now.ToString("dd/MM/yyyy"));
            deData = (data.ToString("dd/MM/yyyy"));
            carregarEntradas();
        }

        private void btnPerso_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            if (DateTime.TryParse(txtBoxDeMes.Text, out a) && DateTime.TryParse(txtBoxAteMes.Text, out b) && b > a){
                deData = txtBoxDeMes.Text;
                ateData = txtBoxAteMes.Text;
                carregarEntradas();
            } else
                MessageBox.Show("Datas invalidas");
        }
    }
}
