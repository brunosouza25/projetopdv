﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Vendas.View
{
    public partial class TelaDevolucao : Form
    {
        DadosTableAdapters.VendaTableAdapter listaDeVendas = new DadosTableAdapters.VendaTableAdapter();
        List<Produto> listaProduto = new List<Produto>();
        int quantidade;
        DadosTableAdapters.DataRelatorioTableAdapter detalheVenda = new DadosTableAdapters.DataRelatorioTableAdapter();
        DadosTableAdapters.ProdutoTableAdapter dadosProdutos = new DadosTableAdapters.ProdutoTableAdapter();

        DadosTableAdapters.Itens_DevolucaoTableAdapter devolucao = new DadosTableAdapters.Itens_DevolucaoTableAdapter();

        string deData, ateData;
        int codVenda, idDevolucao;
        public TelaDevolucao()
        {
            InitializeComponent();
        }

        private void listaVendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool valida()
        {
            bool ok = false;
            quantidade = Convert.ToInt32(txtBoxQnt.Text);
            if (listaVendas.SelectedItems.Count > 0 && quantidade >= Convert.ToInt32(listaVendas.SelectedItems[0].SubItems[4].Text))
            {
                ok = true;
            }
            return ok;
        }
        private void TxtBoxPesquisaProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int pesquisa;
                if (Int32.TryParse(TxtBoxPesquisaProd.Text.Trim(), out pesquisa))
                {
                    TxtBoxPesquisaProd.Select();
                    listaVendas.Items.Clear();
                    codVenda = pesquisa;
                    carregarTela();

                }
                else
                {
                    MessageBox.Show("Este campo não aceita letras, somente número");
                    TxtBoxPesquisaProd.Text = "";
                    TxtBoxPesquisaProd.Select();
                }
            }

        }

        private void carregarTela()
        {
            var auxVenda = detalheVenda.retornarVendaPorId(codVenda);
            var auxProdutosVenda = detalheVenda.retornarItensDaVenda(codVenda);
            var pagamentosVenda = detalheVenda.pagamentosVenda(codVenda);
            if (auxVenda.Count > 0)
            {
                if (Convert.ToByte(auxVenda[0]["vendaEstado"]) == 1)
                {

                    List<string> tipos = new List<string>();
                    for (int i = 0; i < auxProdutosVenda.Count; i++)
                    {
                        ListViewItem item = new ListViewItem();
                        /*int qnt = 0;

                        for (int j = 0; j <= auxProdutosVenda.Count - 1; j++)
                        {
                            if (auxProdutosVenda[i]["prodNome"].ToString() == auxProdutosVenda[j]["prodNome"].ToString())
                            {
                                qnt += 1;
                            }
                        }
                        */
                        Produto prod = new Produto();
                        prod.prodNome = auxProdutosVenda[i]["prodNome"].ToString();
                        prod.prodCodBarras = auxProdutosVenda[i]["prodCodBarras"].ToString();
                        //prod.prodValor = Convert.ToDouble(auxProdutosVenda[i]["prodValor"]);
                        prod.prodQuantidade = Convert.ToInt32(auxProdutosVenda[i]["itensQtd"]);
                        prod.idProduto = Convert.ToInt32(auxProdutosVenda[i]["idProduto"]);

                        if (Convert.ToByte(auxProdutosVenda[i]["estadoDevolucao"]) == 1)
                        {
                            item.BackColor = System.Drawing.Color.Gray;
                        }

                        item.SubItems.Add(codVenda.ToString());
                        item.SubItems.Add(auxProdutosVenda[i]["vendData"].ToString());
                        item.SubItems.Add(prod.prodNome);
                        //item.SubItems.Add(prod.prodCodBarras);
                        //item.SubItems.Add(prod.prodValor.ToString("F2"));
                        //item.SubItems.Add("");
                        item.SubItems.Add(prod.prodQuantidade.ToString());
                        bool achou = false;

                        for (int j = 0; j < listaProduto.Count; j++)
                        {
                            if (listaProduto[j].prodNome == prod.prodNome)
                            {
                                achou = true;
                                listaProduto[j].prodQuantidade = prod.prodQuantidade + listaProduto[j].prodQuantidade;
                            }
                        }
                        if (!achou)
                        {
                            listaProduto.Add(prod);
                        }
                        //double aux = Convert.ToDouble(auxVenda[i]["prodValor"]) * Convert.ToInt32(auxProdutosVenda[i]["itensQtd"]);
                        //item.SubItems.Add(aux.ToString("F2"));
                        item.SubItems.Add(prod.idProduto.ToString());
                        item.SubItems.Add(auxProdutosVenda[i]["idItens"].ToString());
                        listaVendas.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Esta venda foi cancelada");
                }
            }
            else
                MessageBox.Show("Esta venda não existe ou já passou dos 30 dias de devolução");

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                int aux;
                if (MessageBox.Show("Tem certeza?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var auxProdutosVenda = detalheVenda.retornarItensDaVenda(codVenda);
                    int aux3 = 0;
                    if (auxProdutosVenda[0]["quantidadeRetirada"] == null)
                    {
                        aux = Convert.ToInt32(auxProdutosVenda[0]["quantidadeRetirada"]);
                    }
                    if (Convert.ToInt32(auxProdutosVenda[0]["itensQtd"]) >= Convert.ToInt32(txtBoxQnt.Text) +
                        aux3){


                        detalheVenda.attItensVenda(1, Convert.ToInt32(txtBoxQnt.Text), Convert.ToInt32(listaVendas.SelectedItems[0].SubItems[6].Text));
                        var auxDevolucao = devolucao.retornarUltimoIdDevolucao();
                        devolucao.inserirDevolucao(Convert.ToInt32(auxDevolucao[0]["idItensDevolucao"]) + 1, codVenda
                        , Convert.ToInt32(listaVendas.SelectedItems[0].SubItems[5].Text), Convert.ToInt32(txtBoxQnt.Text)
                        , DateTime.Now.Date.ToString("dd/MM/yyyy"));



                        var aux2 = dadosProdutos.PegaQuantidade(Convert.ToInt32(listaVendas.SelectedItems[0].SubItems[5].Text));
                        MessageBox.Show(aux2[0]["prodQuantidade"].ToString());
                        aux = Convert.ToInt32(aux2[0]["prodQuantidade"]) + quantidade;
                        dadosProdutos.AttQuantidade(aux, Convert.ToInt32(aux2[0]["idProduto"]));
                    }
                    else
                    {
                        MessageBox.Show("A quantidade de item a ser devolvida é maior do que a quantidade que foi vendida");
                    }
                    
                }
            }
        }

    }
}