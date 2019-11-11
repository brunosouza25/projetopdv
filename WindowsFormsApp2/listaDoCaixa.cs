using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        List<Produto> produtos = new List<Produto>();
        int quantidade;
        private string pesquisaListaCaixa(string pesquisa)
        {
            string caminho = @"c:\arquivos";
            string[] arquivo;
            try
            {
                IEnumerable<string> arquivos = Directory.EnumerateFiles(caminho, "*.txt", SearchOption.AllDirectories);
                Console.WriteLine(arquivos);
                foreach (string prod in arquivos)
                {
                    arquivo = File.ReadAllLines(prod);
                    if (arquivo[0] == pesquisa.Trim())  
                    {
                        TxtBoxPesquisaProd.Text = "";
                        ListViewItem item = new ListViewItem();
                        for (int i = 0; i < arquivo.Length; i++)
                        {
                            item.SubItems.Add(arquivo[i]);
                        }
                        listaCaixa.Items.Add(item);
                    }
                }
            }
            catch (IOException er)
            {
                Console.WriteLine("Tivemos um erro ");
                Console.WriteLine(er.Message);
            }
            return "0";
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

        private void TxtBoxPesquisaProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisaListaCaixa(TxtBoxPesquisaProd.Text);
            }
        }

        private void Bt_Cancelar_Venda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                listaCaixa.Items.Clear();
        }

        private void Bt_Add_Prod_Click(object sender, EventArgs e)
        {
            pesquisaListaCaixa(TxtBoxPesquisaProd.Text);
        }

        private void listaCaixa_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void Bt_Remover_Prod_Click(object sender, EventArgs e)
        {
           if (listaCaixa.SelectedItems.Count > 0)
                for(int i = listaCaixa.SelectedItems.Count; i >= 1; i--)
                    listaCaixa.Items.Remove(listaCaixa.SelectedItems[i-1]);
            else
                MessageBox.Show("Não tem nenhum item selecionado!");
            /* o trecho de  código sendo comentado aqui está dando problema, estou comentando
             * para tentar entender melhor o porque
            if (listaCaixa.SelectedItems.Count > 0)
                for (int i = 0; i <= listaCaixa.SelectedItems.Count; i++)
                    listaCaixa.Items.Remove(listaCaixa.SelectedItems[i]);
            else
                MessageBox.Show("Não tem nenhum item selecionado!");
                */
        }

        private void TxtBoxPesquisaProd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
