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
        DadosTableAdapters.DataRelatorioTableAdapter detalheVenda = new DadosTableAdapters.DataRelatorioTableAdapter();

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
            var auxVenda = detalheVenda.retornarVendaPorId(codVenda);
            var auxProdutosVenda = detalheVenda.retornarItensDaVenda(codVenda);

            lblDin.Text = auxVenda[0]["PagValor"].ToString();
            lblCredVista.Text = auxVenda[1]["PagValor"].ToString();
            lblCredParc.Text = auxVenda[2]["PagValor"].ToString();
            lblDebt.Text = auxVenda[3]["PagValor"].ToString();

            lblNumVenda.Text = auxVenda[0]["idVenda"].ToString();

            lblTotal.Text = auxVenda[0]["valorCompra"].ToString();

            lblData.Text = Convert.ToDateTime(auxVenda[0]["vendData"]).ToString("dd/MM/yyyy");

            for(int i = 0; i < auxProdutosVenda.Count; i++)
            {
                ListViewItem item = new ListViewItem();

                item.SubItems.Add(auxProdutosVenda[i]["prodNome"].ToString());
                item.SubItems.Add(auxProdutosVenda[i]["prodCodBarras"].ToString());
                item.SubItems.Add(Convert.ToDateTime(auxVenda[i]["vendData"]).ToString("dd/MM/yyyy"));
                item.SubItems.Add(Convert.ToDouble(auxVenda[i]["valorCompra"]).ToString("F2"));

                listaVendas.Items.Add(item);
            }


        }
    }
}
