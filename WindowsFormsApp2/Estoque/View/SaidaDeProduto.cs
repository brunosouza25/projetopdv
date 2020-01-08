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
        string deData;
        string ateData;
        public SaidaDeProduto()
        {
            deData = DateTime.Now.ToString("dd-MM-yyyy");
            ateData = DateTime.Now.AddMonths(-1).ToString();

            InitializeComponent();
            carregarSaidas();
        }
        public void carregarSaidas()
        {

            listaSaidas.Items.Clear();
            var varSaidas = saidas.retornarSaidas(ateData, deData);

            for (int i = 0; i < varSaidas.Count - 1; i++)
            {
                //num entrada, data, funcionario, obs

                //MessageBox.Show("id1: " + varEntradas[j]["idSecundarioItensEntrada"] + "id2: " + varEntradas[i]["idSecundarioItensEntrada"]);

                ListViewItem item = new ListViewItem();
                var auxSaidas = saidas.retornarSaidaPorId(Convert.ToInt32(varSaidas[i]["idSecundarioItensSaida"]));

                item.SubItems.Add(auxSaidas[0]["idSecundarioItensSaida"].ToString());
                item.SubItems.Add(Convert.ToDateTime(auxSaidas[0]["dataSaida"]).ToString("dd/MM/yyyy") + " " + auxSaidas[0]["horaSaida"].ToString().Substring(0, 5));
                item.SubItems.Add("Funcionario padrão");
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
        }

        private void btnHoje_Click(object sender, EventArgs e)
        {
            deData = DateTime.Now.ToString("dd-MM-yyyy");
            ateData = DateTime.Now.ToString("dd-MM-yyyy");
            carregarSaidas();
        }

        private void btnOntem_Click(object sender, EventArgs e)
        {
            ateData = DateTime.Now.AddDays(-1).ToString();
            deData = DateTime.Now.AddDays(-1).ToString();
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
            var ultimoDia = DateTime.DaysInMonth(data.Year, data.Month);
            var dataUltimoDia = new DateTime(data.Year, data.Month, ultimoDia); //possibilidade de remoção desta linha

            ateData = (dataUltimoDia.ToString("01/MM/yyyy"));
            deData = (dataUltimoDia.ToString("dd/MM/yyyy"));
            carregarSaidas();

        }
        private void btnUltimos3Meses_Click(object sender, EventArgs e)
        {

            var data = DateTime.Now.AddMonths(-3);

            ateData = (DateTime.Now.ToString());
            deData = (data.ToString("dd/MM/yyyy"));
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
    }
}
