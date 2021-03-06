﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TelaEntrarProd : Form
    {


        int prodCodigo;
        Boolean tipo;
        DadosTableAdapters.ProdutoTableAdapter dadosProdutos = new DadosTableAdapters.ProdutoTableAdapter();
        public TelaEntrarProd(int prodCodigo, Boolean tipo)
        {
            InitializeComponent();
            this.prodCodigo = prodCodigo;
            this.tipo = tipo;

        }

        private void valida()
        {
            int a;

            if (int.TryParse(TxtBoxQuant.Text.Trim(), out a))
            {
                if (Convert.ToInt32(TxtBoxQuant.Text) < 1)
                {
                    MessageBox.Show("Não permitida a entrada de valores negativos");
                    TxtBoxQuant.Text = "";
                }
                else
                    addArquivos();
            }
            else
            {
                MessageBox.Show("Número invalido");
            }


            Close();
        }
        private void addArquivos()
        {
            if (tipo)
            {
                int aux = Convert.ToInt32(TxtBoxQuant.Text);

                var aux2 = dadosProdutos.PegaQuantidade(prodCodigo);

                aux += Convert.ToInt32(aux2[0]["prodQuantidade"]);

                dadosProdutos.AttQuantidade(aux, prodCodigo);
            }
            else
            {
                int aux = Convert.ToInt32(TxtBoxQuant.Text);

                var aux2 = dadosProdutos.PegaQuantidade(prodCodigo);
                if (aux > Convert.ToInt32(aux2[0]["prodQuantidade"]))
                {
                    MessageBox.Show("Você está retirando um valor maior do que o contido em estoque");
                }
                else
                {
                    aux = Convert.ToInt32(aux2[0]["prodQuantidade"]) - aux;
                    dadosProdutos.AttQuantidade(aux, prodCodigo);
                }

            }
            Close();
        }

        private void TelaEntrarProd_Load(object sender, EventArgs e)
        {
            if (tipo)
                this.Text = "Entrada de Produtos";
            else
                this.Text = "Retirada de Produtos";
            TxtBoxQuant.Select();

        }

        private void TxtBoxQuant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                valida();
                Close();
            }

        }

        private void digitouAlgo(object sender, KeyEventArgs e)
        {
            valida();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtEntrarQuant_Click(object sender, EventArgs e)
        {
            valida();

        }
    }
}
