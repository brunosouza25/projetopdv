﻿using System;
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
        DadosTableAdapters.ProdutoTableAdapter dadosProdutos = new DadosTableAdapters.ProdutoTableAdapter();
        Produto prod = new Produto();
        List<Produto> produtos = new List<Produto>();

        string pesquisa;
        double total = 0;
        public string[,] itensDaLista { get; set; }
        private void pesquisaListaCaixa()
        {
            var varPesquisa1 = dadosProdutos.pegarBanco(pesquisa, pesquisa);
            //var varPesquisa2 = dadosProdutos.pegarBancoCodigoBarras(pesquisa);
            if (varPesquisa1.Count < 1 || Convert.ToInt32(varPesquisa1[0]["prodEstado"]) == 1)
                MessageBox.Show("Não existe esse produto no estoque ou este produto está inativo");
            else
            { 
                prod.prodNome = varPesquisa1[0]["prodNome"].ToString();
                prod.prodValor = Convert.ToDouble(varPesquisa1[0]["prodValor"]);
                prod.prodCodBarras = varPesquisa1[0]["prodCodBarras"].ToString();
                prod.idProduto = Convert.ToInt32(varPesquisa1[0]["idProduto"]);

                ListViewItem item = new ListViewItem();
                item.SubItems.Add(prod.prodNome);
                item.SubItems.Add(prod.prodCodBarras);
                item.SubItems.Add(prod.prodValor.ToString());
                item.SubItems.Add(prod.idProduto.ToString());
                total += prod.prodValor;
                listaCaixa.Items.Add(item);
            }/*else if(varPesquisa2.Count > 0){
                prod.prodNome = varPesquisa2[0]["prodNome"].ToString();
                prod.prodValor = Convert.ToDouble(varPesquisa2[0]["prodValor"]);
                prod.prodCodBarras = varPesquisa2[0]["prodCodBarras"].ToString();
                prod.idProduto = Convert.ToInt32(varPesquisa2[0]["idProduto"]);

                ListViewItem item = new ListViewItem();
                item.SubItems.Add(prod.prodNome);
                item.SubItems.Add(prod.prodCodBarras);
                item.SubItems.Add(prod.prodValor.ToString());
                item.SubItems.Add(prod.idProduto.ToString());
                total += prod.prodValor;
                listaCaixa.Items.Add(item);
            }*/
            LblTotal.Text = "R$: " + total.ToString("F2");

            TxtBoxPesquisaProd.Text = "";

        }

        private void listaDoCaixa_Load(object sender, EventArgs e)
        {
            TxtBoxPesquisaProd.Select();
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
                pesquisa = TxtBoxPesquisaProd.Text;
                pesquisaListaCaixa();
            }
        }

        private void Bt_Cancelar_Venda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listaCaixa.Items.Clear();
                LblTotal.Text = "R$: 0,00";
                total = 0;
            }
            TxtBoxPesquisaProd.Select();
        }

        private void Bt_Add_Prod_Click(object sender, EventArgs e)
        {
            pesquisa = TxtBoxPesquisaProd.Text;
            pesquisaListaCaixa();
            TxtBoxPesquisaProd.Select();
        }

        private void listaCaixa_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void Bt_Remover_Prod_Click(object sender, EventArgs e)
        {
            if (listaCaixa.SelectedItems.Count > 0)
                for (int i = listaCaixa.SelectedItems.Count; i >= 1; i--)
                {
                    ListViewItem item = new ListViewItem();
                    item = listaCaixa.SelectedItems[i - 1];
                    listaCaixa.Items.Remove(listaCaixa.SelectedItems[i - 1]);
                    total -= Convert.ToDouble(item.SubItems[3].Text);
                    LblTotal.Text = "R$: " + total.ToString("F2");
                }
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
            TxtBoxPesquisaProd.Select();
        }

        private void TxtBoxPesquisaProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnFinalizarVenda_Click(object sender, EventArgs e)
        {

        
        }

        private void BtnFinalizarVenda_Click_1(object sender, EventArgs e)
        {
            if (listaCaixa.Items.Count > 0)
            {
                if (total > 0)
                {
                    itensDaLista = new string[this.listaCaixa.Items.Count, 5];
                    Console.WriteLine(listaCaixa.Items[0].SubItems[4].Text + "oi");
                    for (int i = 0; i < this.listaCaixa.Items.Count; i++)
                    {
                        for (int j = 0; j <= 4; j++)
                        {
                            itensDaLista[i, j] = listaCaixa.Items[i].SubItems[j].Text;
                        }
                    }
                    TelaDePagamento telaDePagamento = new TelaDePagamento(itensDaLista, total);
                    telaDePagamento.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Não tem itens na venda");
            }
            TxtBoxPesquisaProd.Select();

        }
    }
}
