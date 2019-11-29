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
    public partial class TelaPrincipal : Form
    {
        String Hora = (DateTime.Now.ToString("HH:mm:ss"));
        TelaDeEstoque estoque = new TelaDeEstoque();
        listaDoCaixa caixa = new listaDoCaixa();
        TelaDeRelatorios relatorio = new TelaDeRelatorios();


        public TelaPrincipal()
        {
            InitializeComponent();

            //caixa
            painelPrincipal.Controls.Add(caixa);
            caixa.Visible = false;
            //estoque
            painelPrincipal.Controls.Add(estoque);
            estoque.Visible = false;
            //relatorios
            painelPrincipal.Controls.Add(relatorio);
            relatorio.Visible = false;

        }

        public void mudarEstoque()
        {
            estoque.Visible = !estoque.Visible;
            estoque.carregarListaEstoque();
        }
        public void mudarCaixa()
        {
            caixa.Visible = !caixa.Visible;
        }
        public void mudarRelatorio()
        {
            relatorio.Visible = !relatorio.Visible;
        }

        private void BtRelatorio_Click(object sender, EventArgs e)
        {
            if (estoque.Visible)
            {
                mudarEstoque();
            }
            if (caixa.Visible)
            {
                mudarCaixa();
            }
            relatorio.Visible = true;
        }
        private void BtCaixa_Click(object sender, EventArgs e)
        {
            if (estoque.Visible)
            {
                mudarEstoque();
            }
            if (relatorio.Visible)
            {
                mudarRelatorio();
            }

            caixa.Visible = true;

        }
        private void BtEstoque_Click(object sender, EventArgs e){
            if (caixa.Visible)
            {
                mudarCaixa();
            }
            if (relatorio.Visible)
            {
                mudarRelatorio();
            }

            estoque.Visible = true;
            estoque.carregarListaEstoque();


        }

        //Timer para alterar a label de data e hora
        private void timer1_Tick(object sender, EventArgs e)
        {
           Lab_Hora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
           timer1.Start();
        }
    }
}
