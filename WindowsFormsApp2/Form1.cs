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
                private void BtEstoque_Click(object sender, EventArgs e)
        {
            TelaDeEstoque estoque = new TelaDeEstoque();
            painelPrincipal.Controls.Add(estoque);

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
    }
}
