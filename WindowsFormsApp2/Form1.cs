using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Label2_Click(object sender, EventArgs e)
        {

        }


        private void BtCaixa_Click(object sender, EventArgs e)
        {
            listaDoCaixa lista = new listaDoCaixa();
            painelPrincipal.Controls.Add(lista);
        }

        private void PainelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
