using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Vendas.View;

namespace WindowsFormsApp2.Vendas
{
    
    public partial class TelaDeVendas : UserControl
    {
        ListaDeVendas vendas = new ListaDeVendas();
        listaDoCaixa pdv = new listaDoCaixa();
        public TelaDeVendas()
        {
            InitializeComponent();
            painelPrincipalDeVendas.Controls.Add(vendas);
            vendas.Visible = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            vendas.Visible = true;
        }
    }
}
