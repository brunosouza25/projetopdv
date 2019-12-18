using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Vendas.View
{
    public partial class TelaDetalhesDaVenda : Form
    {
        DadosTableAdapters.VendaTableAdapter venda = new DadosTableAdapters.VendaTableAdapter();
        DadosTableAdapters.PagamentoTableAdapter pagVenda = new DadosTableAdapters.PagamentoTableAdapter();
        DadosTableAdapters.ItensDaVendaTableAdapter itensVenda = new DadosTableAdapters.ItensDaVendaTableAdapter();

        int codVenda;
        public TelaDetalhesDaVenda(int codVenda)
        {
            InitializeComponent();
            this.codVenda = codVenda;
            carregarTela();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
        }
        private void carregarTela()
        {
            var auxVenda = venda.retornarVendaPorId(codVenda);
            var auxPag = pagVenda.retornarTiposPagamentos(codVenda);
            var auxItens = itensVenda.itensVenda(codVenda);

            lblDin.Text = auxPag[0]["PagValor"].ToString();
            lblCredVista.Text = auxPag[1]["PagValor"].ToString();
            lblCredParc.Text = auxPag[2]["PagValor"].ToString();
            lblDebt.Text = auxPag[3]["PagValor"].ToString();

            lblNumVenda.Text = auxVenda[0]["idVenda"].ToString();

            lblTotal.Text = auxVenda[0]["valorCompra"].ToString();

            lblData.Text = Convert.ToDateTime(auxVenda[0]["vendData"]).ToString("dd/MM/yyyy");

            for(int i = 0; i <= auxItens.Count; i++)
            {
                ListViewItem item = new ListViewItem();


                item.SubItems.Add(auxItens[i]["idVenda"].ToString());
                item.SubItems.Add(Convert.ToDateTime(varVendas[i]["vendData"]).ToString("dd/MM/yyyy"));
                item.SubItems.Add(Convert.ToDouble(varVendas[i]["valorCompra"]).ToString("F2"));

                listaVendas.Items.Add(item);
            }


        }
    }
}
