using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TelaDeLogin : Form
    {
        public TelaDeLogin()
        {
            InitializeComponent();
        }
        DadosTableAdapters.FuncionarioTableAdapter colaborador = new DadosTableAdapters.FuncionarioTableAdapter();
        DadosTableAdapters.Permissoes_EstoqueTableAdapter permissoesEstoque = new DadosTableAdapters.Permissoes_EstoqueTableAdapter();
        DadosTableAdapters.Permissoes_VendasTableAdapter permissoesVendas = new DadosTableAdapters.Permissoes_VendasTableAdapter();
        DadosTableAdapters.CargoTableAdapter cargo = new DadosTableAdapters.CargoTableAdapter();
        public void validar(string login, string senha)
        {

            var colab = colaborador.logar(login);

            string pass;
            if (colab.Count > 0)
            {
                Global.idCargo = Convert.ToInt32(colab[0]["idCargo"]);
                Global.idColaborador = Convert.ToInt32(colab[0]["idFuncionario"]);
                Global.nomeColaborador = colab[0]["nomeFunc"].ToString();

                pass = colab[0]["senha"].ToString();
                if (senha == pass && Convert.ToInt32(colab[0]["funcEstado"]) == 1 && Convert.ToInt32(colab[0]["idCargo"]) != 0)
                {
                    this.Visible = false;
                    carregarPermissoes();
                    TelaPrincipal tela = new TelaPrincipal();
                    tela.ShowDialog();
                    Close();
                }
                else
                    MessageBox.Show("Não foi possível fazer o Login, login ou senha podem estar errados ou usuário inativo ou sem cargo");
            }
            else
                MessageBox.Show("Não foi possível fazer o Login, login ou senha podem estar errados ou usuário inativo ou sem cargo");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            validar(TxtBoxUser.Text, TxtBoxPass.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void carregarPermissoes()
        {

            var auxVenda = permissoesVendas.retornarPermissoesVendas(Global.idCargo);
            var auxEstoque = permissoesEstoque.retornarPermissoesEstoque(Global.idCargo);

            Global.lancarVendas = Convert.ToBoolean(auxVenda[0]["lancar_vendas"]);
            Global.cancelarVendas = Convert.ToBoolean(auxVenda[0]["cancelar_vendas"]);
            Global.sangria = Convert.ToBoolean(auxVenda[0]["sangria"]);
            Global.devolucoes = Convert.ToBoolean(auxVenda[0]["devolucoes"]);

            Global.criacaoProduto = Convert.ToBoolean(auxEstoque[0]["criacao_produtos"]);
            Global.editarProdutos = Convert.ToBoolean(auxEstoque[0]["editar_produtos"]);
            Global.entradaProdutos = Convert.ToBoolean(auxEstoque[0]["entrada_produtos"]);
            Global.saidaProdutos = Convert.ToBoolean(auxEstoque[0]["saida_produtos"]);

            var colab = colaborador.verificarFunc(Global.nomeColaborador);
            var adm = cargo.retornarCargoPorId(Convert.ToInt32(colab[0]["idCargo"]));

            Global.adm = Convert.ToBoolean(adm[0]["adm"]);
            
            

        }


        private void TxtBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validar(TxtBoxUser.Text, TxtBoxPass.Text);
            }
        }
    }
}
