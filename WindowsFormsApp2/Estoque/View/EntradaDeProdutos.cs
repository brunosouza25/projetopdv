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
        public EntradaDeProdutos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntrarProd_Click(object sender, EventArgs e)
        {
            TelaDeEntradaProduto telaEntrada = new TelaDeEntradaProduto();
            telaEntrada.ShowDialog();
        }
    }
}
