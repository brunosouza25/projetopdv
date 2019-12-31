using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TelaPrincipalEstoque : UserControl
    {
        public TelaDeEstoque estoque = new TelaDeEstoque();
        EntradaDeProdutos entrada = new EntradaDeProdutos();
        SaidaDeProdutos saida = new SaidaDeProdutos();
        public TelaPrincipalEstoque()
        {
            InitializeComponent();
            painelPrincipalDoEstoque.Controls.Add(estoque);

            entrada.Visible = false;
            painelPrincipalDoEstoque.Controls.Add(entrada);

            saida.Visible = false;
            painelPrincipalDoEstoque.Controls.Add(saida);

        }

        private void mudarEntrada()
        {
            entrada.Visible = !entrada.Visible;
        }

        private void mudarSaida()
        {
            saida.Visible = !saida.Visible;
        }

        private void mudarEstoque()
        {
            estoque.Visible = !estoque.Visible;
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            if (entrada.Visible)
            {
                mudarEntrada();
            }
            if (saida.Visible)
            {
                mudarSaida();
            }

            mudarEstoque();
            estoque.carregarListaEstoque();
        }

        private void btnEntradaProduto_Click(object sender, EventArgs e)
        {
            if (estoque.Visible)
            {
                mudarEstoque();
            }
            if (saida.Visible)
            {
                mudarSaida();
            }
            mudarEntrada();
        }

        private void btnSaidaProduto_Click(object sender, EventArgs e)
        {
            if (entrada.Visible)
            {
                mudarEntrada();
            }
            if (estoque.Visible)
            {
                mudarEstoque();
            }
            mudarSaida();
        }
    }
}
