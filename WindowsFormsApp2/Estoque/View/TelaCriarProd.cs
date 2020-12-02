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
        TelaInformacaoGeralProd TelaGeral = new TelaInformacaoGeralProd();

        public TelaCriarProd(Boolean tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            BtnSalvar.Text = "Criar";

            PainelPrincipal.Controls.Add(TelaGeral);
            TelaGeral.criarProd(tipo);
        }
        public TelaCriarProd(Boolean tipo, int codigoProd)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.codigoProd = codigoProd;
            BtnSalvar.Text = "Alterar";
            PainelPrincipal.Controls.Add(TelaGeral);
            TelaGeral.criarProd(tipo);
        }

        

        private void BtnGeral_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TelaGeral.Criar_EditarProd();
            Close();
        }
    }
}