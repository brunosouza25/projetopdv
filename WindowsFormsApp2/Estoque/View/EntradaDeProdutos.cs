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
        public EntradaDeProdutos()
        {
            InitializeComponent();
            carregarEntradas();
        }

        public void carregarEntradas()
        {

            listaEntradas.Items.Clear();
            var varEntradas = entradas.retornarEntradas();

            for (int i = 0; i < varEntradas.Count; i++)
            {
                //num entrada, data, funcionario, obs

                //MessageBox.Show("id1: " + varEntradas[j]["idSecundarioItensEntrada"] + "id2: " + varEntradas[i]["idSecundarioItensEntrada"]);

                ListViewItem item = new ListViewItem();
                var auxEntradas = entradas.retornarEntradaPorId(Convert.ToInt32(varEntradas[i]["idSecundarioItensEntrada"]));

                item.SubItems.Add(auxEntradas[i]["idSecundarioItensEntrada"].ToString());
                item.SubItems.Add(Convert.ToDateTime(auxEntradas[i]["dataEntrada"]).ToString("dd/MM/yyyy HH:mm"));
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
    }
}
