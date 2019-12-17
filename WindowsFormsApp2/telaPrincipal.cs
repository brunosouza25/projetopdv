using System;
using System.Windows.Forms;
using WindowsFormsApp2.Vendas;
namespace WindowsFormsApp2
{
    public partial class TelaPrincipal : Form
    {
        String Hora = (DateTime.Now.ToString("HH:mm:ss"));
        TelaDeEstoque estoque = new TelaDeEstoque();
        TelaDeRelatorios relatorio = new TelaDeRelatorios();
        TelaDeVendas telaDoPdv = new TelaDeVendas();


        public TelaPrincipal()
        {
            InitializeComponent();

            //caixa

            //estoque
            painelPrincipal.Controls.Add(estoque);
            estoque.Visible = false;
            //relatorios
            painelPrincipal.Controls.Add(relatorio);
            relatorio.Visible = false;
            //vendas
            painelPrincipal.Controls.Add(telaDoPdv);
            telaDoPdv.Visible = false;

        }

        public void mudarEstoque()
        {
            estoque.Visible = !estoque.Visible;
            estoque.carregarListaEstoque();
        }
        public void mudarCaixa()
        {
            telaDoPdv.Visible = !telaDoPdv.Visible;
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
            if (telaDoPdv.Visible)
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

            telaDoPdv.Visible = true;

        }
        private void BtEstoque_Click(object sender, EventArgs e){
            if (telaDoPdv.Visible)
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
