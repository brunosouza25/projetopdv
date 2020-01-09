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
        public ListaDeVendas()
        {
            InitializeComponent();
            carregarListaVendas();
        }
        int pesquisa;
        public void carregarListaVendas()
        {
            listaVendas.Items.Clear();
            var varVendas = listaDeVendas.retornarVendas();

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
            int pesquisa;
            if (Int32.TryParse(TxtBoxPesquisaProd.Text.Trim(), out pesquisa) || TxtBoxPesquisaProd.Text == "")
            {
                TxtBoxPesquisaProd.Select();
                listaVendas.Items.Clear();

                var varVendas = listaDeVendas.retornarVendaPorId(Convert.ToInt32(pesquisa));

                if (varVendas.Count > 0)
                {
                    for (int i = 0; i < varVendas.Count; i++)
                    {
                        ListViewItem item = new ListViewItem();


                        item.SubItems.Add(varVendas[i]["idVenda"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(varVendas[i]["vendData"]).ToString("dd/MM/yyyy"));
                        item.SubItems.Add(Convert.ToDouble(varVendas[i]["valorCompra"]).ToString("F2"));

                        listaVendas.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Este campo não aceita letras, somente número");
                TxtBoxPesquisaProd.Text = "";
                TxtBoxPesquisaProd.Select();
            }

        }

        private void btnPerso_Click(object sender, EventArgs e)
        {

        }
    }
}
