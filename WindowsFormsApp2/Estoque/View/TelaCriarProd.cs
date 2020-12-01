using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp2.Estoque.View;

namespace WindowsFormsApp2
{
    public partial class TelaCriarProd : Form
    {
        byte checkbox;
        Boolean tipo;
        int codigoProd;
        String caminho;
        string quantidade;
        private Produto prod = new Produto();
        DadosTableAdapters.ProdutoTableAdapter dadosProdutos = new DadosTableAdapters.ProdutoTableAdapter();
        
        public TelaCriarProd()
        {
            TelaInformacaoGeralProd TelaGeral = new TelaInformacaoGeralProd();
        }
        public TelaCriarProd(Boolean tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            BtnSalvar.Text = "Criar";
            TelaInfor
        }
        public TelaCriarProd(Boolean tipo, int codigoProd)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.codigoProd = codigoProd;
            BtnSalvar.Text = "Alterar";
            carregarTela();

        }

        private void BtnGeral_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}