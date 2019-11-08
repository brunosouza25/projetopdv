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
    public partial class listaDoCaixa : UserControl
    {
        //criar uma lista com produtos pré inseridos
        //a partir do text box vou fazer uma pesquisa do produto na lista
        //se houver produto ele vai me retornar na list view, senão ele exibe um erro
        //atualizar o total
        //se clicar em finalizar venda, os produtos da list view e o valor total devem ser carregados para a tela de pagamento
        // se o valor inserido for abatido pelo valor total da compra, libera o botão finalizar
        //clicando em finalizar, será salvo as informações de valor da compra, horario, se der os itens da venda
        // retornar para a tela de venda e limpa a list view e o valor total

        public listaDoCaixa()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pesquisaProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void pesquisaProd_Enter(object sender, EventArgs e)
        {

        }

        private void listaDoCaixa_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
