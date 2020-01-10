using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsFormsApp2.Vendas.View
{

    public partial class ListaDeVendas : UserControl
    {
        DadosTableAdapters.VendaTableAdapter listaDeVendas = new DadosTableAdapters.VendaTableAdapter();
        string deData, ateData;
        public ListaDeVendas()
        {
            InitializeComponent();
            deData = DateTime.Now.ToString("dd/MM/yyyy");
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            carregarListaVendas();
        }
        int pesquisa;
        public void carregarListaVendas()
        {
            listaVendas.Items.Clear();
            var varVendas = listaDeVendas.retornarVendas(Convert.ToDateTime(deData), Convert.ToDateTime(ateData));

            for (int i = 0; i < varVendas.Count; i++)
            {
                ListViewItem item = new ListViewItem();


                item.SubItems.Add(varVendas[i]["idVenda"].ToString());
                item.SubItems.Add(Convert.ToDateTime(varVendas[i]["vendData"]).ToString("dd/MM/yyyy"));
                item.SubItems.Add(Convert.ToDouble(varVendas[i]["valorCompra"]).ToString("F2"));

                listaVendas.Items.Add(item);
            }
        }


        private void listaVendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listaVendas_DoubleClick(object sender, EventArgs e)
        {
            TelaDetalhesDaVenda tela = new TelaDetalhesDaVenda(Convert.ToInt32(listaVendas.SelectedItems[0].SubItems[1].Text));
            tela.ShowDialog();
        }

        private void TxtBoxPesquisaProd_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnHoje_Click(object sender, EventArgs e)
        {
            deData = DateTime.Now.ToString("dd/MM/yyyy");
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            carregarListaVendas();
        }

        private void btnOntem_Click(object sender, EventArgs e)
        {
            ateData = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
            deData = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
         
            carregarListaVendas();
        }

        private void btn7Dias_Click(object sender, EventArgs e)
        {
            deData = DateTime.Now.AddDays(-7).ToString("dd/MM/yyyy");
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            carregarListaVendas();
        }

        private void btnEsteMes_Click(object sender, EventArgs e)
        {
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            deData = DateTime.Now.ToString("01/MM/yyyy");
            carregarListaVendas();
        }

        private void btnMesPassado_Click(object sender, EventArgs e)
        {

            //DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));



            var data = DateTime.Now.AddMonths(-1);
            var ultimoDia = DateTime.DaysInMonth(data.Year, data.Month);
            var dataUltimoDia = new DateTime(data.Year, data.Month, ultimoDia); //possibilidade de remoção desta linha

            ateData = (dataUltimoDia.ToString("01/MM/yyyy"));
            deData = (dataUltimoDia.ToString("dd/MM/yyyy"));
            carregarListaVendas();

        }

        private void btnUltimos3Meses_Click(object sender, EventArgs e)
        {

            var data = DateTime.Now.AddMonths(-3);

            ateData = (DateTime.Now.ToString("dd/MM/yyyy"));
            deData = (data.ToString("dd/MM/yyyy"));
            carregarListaVendas();
        }

        private void btnPerso_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            if (DateTime.TryParse(txtBoxDeMes.Text, out a) && DateTime.TryParse(txtBoxAteMes.Text, out b) && b > a)
            {
                deData = txtBoxDeMes.Text;
                ateData = txtBoxAteMes.Text;
                carregarListaVendas();
            }
            else
                MessageBox.Show("Datas invalidas");
        }
        private void TxtBoxPesquisaProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int pesquisa;
                if (Int32.TryParse(TxtBoxPesquisaProd.Text.Trim(), out pesquisa))
                {
                    TxtBoxPesquisaProd.Select();
                    listaVendas.Items.Clear();

                    var varVendas = listaDeVendas.retornarVendaPorId(Convert.ToInt32(pesquisa));

                    if (varVendas.Count > 0)
                    {
                        ListViewItem item = new ListViewItem();


                        item.SubItems.Add(varVendas[0]["idVenda"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(varVendas[0]["vendData"]).ToString("dd/MM/yyyy"));
                        item.SubItems.Add(Convert.ToDouble(varVendas[0]["valorCompra"]).ToString("F2"));

                        listaVendas.Items.Add(item);
                    }
                }
                else if (TxtBoxPesquisaProd.Text == "")
                {
                    carregarListaVendas();
                }
                else
                {
                    MessageBox.Show("Este campo não aceita letras, somente número");
                    TxtBoxPesquisaProd.Text = "";
                    TxtBoxPesquisaProd.Select();
                }
            }
            
        }
    }
}
