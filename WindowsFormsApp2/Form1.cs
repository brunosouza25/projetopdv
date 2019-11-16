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
        String Hora = (DateTime.Now.ToString("HH:mm:ss"));
        TelaDeEstoque estoque = new TelaDeEstoque();
        listaDoCaixa caixa = new listaDoCaixa();
        TelaDeRelatorios relatorio = new TelaDeRelatorios();


        public Form1()
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
        }
        public void mudarCaixa()
        {
            caixa.Visible = !caixa.Visible;
        }
        public void mudarRelatorio()
        {
            relatorio.Visible = !relatorio.Visible;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        //Timer para alterar a label de data e hora
        private void timer1_Tick(object sender, EventArgs e)
        {
           Lab_Hora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
           timer1.Start();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
