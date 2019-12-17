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
        int codVenda;
        public TelaDetalhesDaVenda(int codVenda)
        {
            InitializeComponent();
            this.codVenda = codVenda;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
