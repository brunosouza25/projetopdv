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
                ListViewItem item = new ListViewItem();
                //num entrada, data, funcionario, obs

                item.SubItems.Add(varEntradas[i]["idItensEntrada"].ToString());
                item.SubItems.Add(Convert.ToDateTime(varEntradas[i]["dataEntrada"]).ToString("dd/MM/yyyy HH:mm"));
                item.SubItems.Add("Funcionario padrão");
                if(varEntradas[i]["observacoes"].ToString().Length >= 69)
                    item.SubItems.Add(varEntradas[i]["observacoes"].ToString().Substring(0,69));
                else
                    item.SubItems.Add(varEntradas[i]["observacoes"].ToString());
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
        }

        private void listaEntradas_DoubleClick(object sender, EventArgs e)
        {
            TelaDeEntradaProduto tela = new TelaDeEntradaProduto(false, Convert.ToInt32(listaEntradas.SelectedItems[0].SubItems[1].Text));
            tela.ShowDialog();
        }
    }
}
