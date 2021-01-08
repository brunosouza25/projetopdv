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
        TelaDoPdv pdv = new TelaDoPdv();
        TelaDeDevolucoes devolucao = new TelaDeDevolucoes();
        public TelaDeVendas()
        {
            InitializeComponent();
            painelPrincipalDeVendas.Controls.Add(vendas);
            vendas.Visible = true;

            painelPrincipalDeVendas.Controls.Add(pdv);
            pdv.Visible = false;

            painelPrincipalDeVendas.Controls.Add(devolucao);
                devolucao.Visible = false;

            if(Global.devolucoes == false)
            {
                devolucao.Visible = false;
                btnDevolucao.Visible = false;
            }
        }

        public TelaDevolucao TelaDevolucao
        {
            get => default;
            set
            {
            }
        }

        public ListaDeVendas ListaDeVendas
        {
            get => default;
            set
            {
            }
        }

        public TelaDoPdv TelaDoPdv
        {
            get => default;
            set
            {
            }
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
            vendas.carregarListaVendas();
            pdv.Visible = false;
            devolucao.Visible = false;
        }

        private void BtnPdv_Click(object sender, EventArgs e)
        {
            vendas.Visible = false;
            devolucao.Visible = false;
            pdv.Visible = true;
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            vendas.Visible = false;
            pdv.Visible = false;
            devolucao.Visible = true;
            devolucao.carregarListaDevolucoes();
        }
    }
}
