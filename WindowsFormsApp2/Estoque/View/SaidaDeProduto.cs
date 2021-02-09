using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Estoque.View
{
    public partial class SaidaDeProduto : UserControl
    {
        DadosTableAdapters.ItensDeSaidaTableAdapter saidas = new DadosTableAdapters.ItensDeSaidaTableAdapter();
        DadosTableAdapters.FuncionarioTableAdapter colaborador = new DadosTableAdapters.FuncionarioTableAdapter();

        string deData;
        string ateData;
        public SaidaDeProduto()
        {
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            deData = DateTime.Now.AddMonths(-1).ToString("dd/MM/yyyy");

            InitializeComponent();
            carregarSaidas();
        }

        internal Produto Produto
        {
            get => default;
            set
            {
            }
        }

        public void carregarSaidas()
        {

            listaSaidas.Items.Clear();
            var varSaidas = saidas.retornarSaidas(deData, ateData);

            for (int i = 0; i <= varSaidas.Count - 1; i++)
            {
                //num entrada, data, funcionario, obs

                //MessageBox.Show("id1: " + varEntradas[j]["idSecundarioItensEntrada"] + "id2: " + varEntradas[i]["idSecundarioItensEntrada"]);

                ListViewItem item = new ListViewItem();
                var auxSaidas = saidas.retornarSaidaPorId(Convert.ToInt32(varSaidas[i]["idSecundarioItensSaida"]));
                var auxColaborador = colaborador.retornarColaboradorPorId(Convert.ToInt32(auxSaidas[0]["idColaborador"]));


                item.SubItems.Add(auxSaidas[0]["idSecundarioItensSaida"].ToString());
                item.SubItems.Add(Convert.ToDateTime(auxSaidas[0]["dataSaida"]).ToString("dd/MM/yyyy") + " " + auxSaidas[0]["horaSaida"].ToString().Substring(0, 5));
                item.SubItems.Add(auxColaborador[0]["nomeFunc"].ToString());
                if (auxSaidas[0]["observacoes"].ToString().Length >= 69)
                    item.SubItems.Add(auxSaidas[0]["observacoes"].ToString().Substring(0, 69));
                else
                    item.SubItems.Add(auxSaidas[0]["observacoes"].ToString());
                listaSaidas.Items.Add(item);

            }


        }

        private void btnSaidaDeProduto_Click(object sender, EventArgs e)
        {
            TelaDeSaidaProduto telaSaida = new TelaDeSaidaProduto();
            telaSaida.ShowDialog();
            carregarSaidas();
        }

        private void listaSaidas_DoubleClick(object sender, EventArgs e)
        {
            TelaDeSaidaProduto tela = new TelaDeSaidaProduto(false, Convert.ToInt32(listaSaidas.SelectedItems[0].SubItems[1].Text));
            tela.ShowDialog();
            carregarSaidas();
        }

        private void btnHoje_Click(object sender, EventArgs e)
        {
            deData = DateTime.Now.ToString("dd/MM/yyyy");
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            carregarSaidas();
        }

        private void btnOntem_Click(object sender, EventArgs e)
        {
            ateData = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
            deData = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
            carregarSaidas();
        }

        private void btnEsteMes_Click(object sender, EventArgs e)
        {
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            deData = DateTime.Now.ToString("01/MM/yyyy");
            carregarSaidas();
        }

        private void btnMesPassado_Click(object sender, EventArgs e)
        {

            //DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));



            var data = DateTime.Now.AddMonths(-1);
            int ultimoDia = DateTime.DaysInMonth(data.Year, data.Month);
            var dataUltimoDia = new DateTime(data.Year, data.Month, ultimoDia); //possibilidade de remoção desta linha

            DateTime primeiroDiaDoMes = new DateTime(data.Year, data.Month, 1);
            DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));

            deData = primeiroDiaDoMes.ToString();


            ateData = ultimoDiaDoMes.ToString();
            carregarSaidas();

        }

        private void btnUltimos3Meses_Click(object sender, EventArgs e)
        {

            var data = DateTime.Now.AddMonths(-3);

            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            deData = data.ToString("dd/MM/yyyy");
            carregarSaidas();
        }
        private void btnPerso_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            if (DateTime.TryParse(txtBoxDeMes.Text, out a) && DateTime.TryParse(txtBoxAteMes.Text, out b) && b > a)
            {
                deData = txtBoxDeMes.Text;
                ateData = txtBoxAteMes.Text;
                carregarSaidas();
            }
            else
                MessageBox.Show("Datas invalidas");
        }

        private void btn7Dias_Click(object sender, EventArgs e)
        {
            deData = DateTime.Now.AddDays(-7).ToString("dd/MM/yyyy");
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            carregarSaidas();
        }
    }
}
