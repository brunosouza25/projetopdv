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
        TelaInformacaoGeralProd telaGeral = new TelaInformacaoGeralProd();
        TelaTributacaoProd telaTributacao = new TelaTributacaoProd();

        public TelaCriarProd(Boolean tipo)
        {

            InitializeComponent();
            this.tipo = tipo;
            BtnSalvar.Text = "Criar";
            PainelPrincipal.Controls.Add(telaGeral);
            telaTributacao.Visible = false;
            PainelPrincipal.Controls.Add(telaTributacao);
            telaTributacao.criarFiscal(tipo);
            telaGeral.criarProd(tipo);
        }
        public TelaCriarProd(Boolean tipo, int codigoProd)
        {

            InitializeComponent();
            this.tipo = tipo;
            this.codigoProd = codigoProd;
            BtnSalvar.Text = "Alterar";
            PainelPrincipal.Controls.Add(telaTributacao);
            telaTributacao.Visible = false;
            PainelPrincipal.Controls.Add(telaGeral);
            telaTributacao.editarFiscal(tipo, codigoProd);
            telaGeral.editarProd(tipo, codigoProd);
        }

        internal Produto Produto
        {
            get => default;
            set
            {
            }
        }

        private void BtnGeral_Click(object sender, EventArgs e)
        {
            telaTributacao.Visible = false;
            telaGeral.Visible = true;
            
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            /*bug que fica criando produto sem fiscal se errar algum dado fiscal e insistir em salvar*/
            bool fechar1 = false;
            bool fechar2 = false;

            fechar1 = telaGeral.verificar();
            fechar2 = telaTributacao.verificar();

            if (tipo && fechar1 && fechar2)
            {
                telaGeral.Criar_EditarProd();
                fechar2 = telaTributacao.SalvarTributacao(true, 0);    
            }
            else if(!tipo && fechar1 && fechar2)
            {
                telaGeral.Criar_EditarProd();
                fechar2 = telaTributacao.SalvarTributacao(true, 0);
            }
            else
            {
                MessageBox.Show("faltam preencher todos os campos fiscais e não fiscais");
            }

            if (fechar1 && fechar2)
            {
                Close();
            }
        }

        private void BtnTributacao_Click(object sender, EventArgs e)
        {
            telaGeral.Visible = false;
            telaTributacao.Visible = true;

        }
    }
}