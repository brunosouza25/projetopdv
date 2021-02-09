using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Vendas.View
{
    public partial class TelaDeDevolucoes : UserControl
    {
        DadosTableAdapters.Itens_DevolucaoTableAdapter dadosDevolucao = new DadosTableAdapters.Itens_DevolucaoTableAdapter();
        DadosTableAdapters.ProdutoTableAdapter produto = new DadosTableAdapters.ProdutoTableAdapter();
        string deData, ateData;
        public TelaDeDevolucoes()
        {
            InitializeComponent();
            deData = DateTime.Now.ToString("dd/MM/yyyy");
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public void carregarListaDevolucoes()
        {
            var auxDevo = dadosDevolucao.retornarDevolucoes(Convert.ToDateTime(deData), Convert.ToDateTime(ateData));

            listaDevolucoes.Items.Clear();


            for (int i = 0; i < auxDevo.Count; i++)
            {
                ListViewItem item = new ListViewItem();

                item.SubItems.Add(auxDevo[i]["idItensDevolucao"].ToString());
                item.SubItems.Add(auxDevo[i]["idVenda"].ToString());
                item.SubItems.Add(Convert.ToDateTime(auxDevo[i]["dataDevolucao"]).ToString("dd/MM/yyyy"));
                //item.SubItems.Add(auxDevo[i]["observacoes"].ToString());
                var aux = produto.retornarProdutoPorId(Convert.ToInt32(auxDevo[i]["idProduto"]));
                item.SubItems.Add(aux[0]["prodNome"].ToString());
                listaDevolucoes.Items.Add(item);
            }
        }
        private void btnHoje_Click(object sender, EventArgs e)
        {
            deData = DateTime.Now.ToString("dd/MM/yyyy");
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            carregarListaDevolucoes();
        }

        private void btnOntem_Click(object sender, EventArgs e)
        {
            ateData = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
            deData = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");

            carregarListaDevolucoes();
        }

        private void btn7Dias_Click(object sender, EventArgs e)
        {
            deData = DateTime.Now.AddDays(-7).ToString("dd/MM/yyyy");
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            carregarListaDevolucoes();
        }

        private void btnEsteMes_Click(object sender, EventArgs e)
        {
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            deData = DateTime.Now.ToString("01/MM/yyyy");
            carregarListaDevolucoes();
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
            carregarListaDevolucoes();

        }

        private void btnUltimos3Meses_Click(object sender, EventArgs e)
        {

            var data = DateTime.Now.AddMonths(-3);

            ateData = (DateTime.Now.ToString("dd/MM/yyyy"));
            deData = (data.ToString("dd/MM/yyyy"));
            carregarListaDevolucoes();
        }

        private void btnDevo_Click(object sender, EventArgs e)
        {
            TelaDevolucao devolucao = new TelaDevolucao();
            devolucao.ShowDialog();
            carregarListaDevolucoes() ;
        }

        private void btnPerso_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            if (DateTime.TryParse(txtBoxDeMes.Text, out a) && DateTime.TryParse(txtBoxAteMes.Text, out b) && b > a)
            {
                deData = txtBoxDeMes.Text;
                ateData = txtBoxAteMes.Text;
                carregarListaDevolucoes();
            }
            else
                MessageBox.Show("Datas invalidas");
        }
    }
}
