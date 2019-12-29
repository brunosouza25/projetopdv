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
            var pagamentosVenda = detalheVenda.pagamentosVenda(codVenda);

            txtBoxDin.Text =  Convert.ToDouble(pagamentosVenda[0]["PagValor"]).ToString("F2");
            txtBoxCredParc.Text = Convert.ToDouble(pagamentosVenda[1]["PagValor"]).ToString("F2");
            txtBoxCredVista.Text = Convert.ToDouble(pagamentosVenda[2]["PagValor"]).ToString("F2");
            txtBoxDebt.Text = Convert.ToDouble(pagamentosVenda[3]["PagValor"]).ToString("F2");

            lblNumVenda.Text = auxVenda[0]["idVenda"].ToString();

            lblTotal.Text = auxVenda[0]["valorCompra"].ToString();

            lblData.Text = Convert.ToDateTime(auxVenda[0]["vendData"]).ToString("dd/MM/yyyy");

            for(int i = 0; i < auxProdutosVenda.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                int qnt = 0;
                
                for (int j = 0; j <= auxProdutosVenda.Count - 1; j++)
                {
                    if (auxProdutosVenda[i]["prodNome"].ToString() == auxProdutosVenda[j]["prodNome"].ToString())
                    {
                        qnt += 1;
                    }
                }
                
                item.SubItems.Add(auxProdutosVenda[i]["prodNome"].ToString());
                item.SubItems.Add(auxProdutosVenda[i]["prodCodBarras"].ToString());
                item.SubItems.Add(auxProdutosVenda[i]["prodValor"].ToString());
                item.SubItems.Add("");


                item.SubItems.Add(qnt.ToString());
                item.SubItems.Add(Convert.ToDouble(auxVenda[i]["valorCompra"]).ToString("F2"));
                listaVendas.Items.Add(item);
            }


        }
    }
}
