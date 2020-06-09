using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Principal.View.Config
{
    public partial class TelaCadastroCargo : Form
    {
        DadosTableAdapters.CargoTableAdapter cargos = new DadosTableAdapters.CargoTableAdapter();
        DadosTableAdapters.Permissoes_VendasTableAdapter permissoes_vendas = new DadosTableAdapters.Permissoes_VendasTableAdapter();
        DadosTableAdapters.Permissoes_EstoqueTableAdapter permissoes_estoque = new DadosTableAdapters.Permissoes_EstoqueTableAdapter();
        public TelaCadastroCargo()
        {
            InitializeComponent();
            tipo = true;
        }
        int idCargo;
        Boolean tipo;
        public TelaCadastroCargo(Boolean tipo, int idCargo)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.idCargo = idCargo;
            btnSalvar.Text = "Alterar";
            carregarTela();

        }
        public void carregarTela()
        {
            var auxCargo = cargos.retornarCargoPorId(idCargo);
            var auxVendas = permissoes_vendas.retornarPermissoesVendas(idCargo);
            var auxEstoque = permissoes_estoque.retornarPermissoesEstoque(idCargo);

            cBoxLancarVendas.Checked = Convert.ToBoolean(auxVendas[0]["lancar_vendas"]);
            cBoxCancelarVendas.Checked = Convert.ToBoolean(auxVendas[0]["cancelar_vendas"]);
            cBoxSangria.Checked = Convert.ToBoolean(auxVendas[0]["sangria"]);
            cBoxDevolucoes.Checked = Convert.ToBoolean(auxVendas[0]["devolucoes"]);

            cBoxCriacaoDeProdutos.Checked = Convert.ToBoolean(auxEstoque[0]["criacao_produtos"]);
            cBoxEditarProdutos.Checked = Convert.ToBoolean(auxEstoque[0]["editar_produtos"]);
            cBoxEntradaDeProdutos.Checked = Convert.ToBoolean(auxEstoque[0]["entrada_produtos"]);
            cBoxSaidaDeProdutos.Checked = Convert.ToBoolean(auxEstoque[0]["saida_produtos"]);

            cBoxInativo.Checked = (!Convert.ToBoolean(auxCargo[0]["estadoCargo"]));

            txtCargo.Text = auxCargo[0]["cargoNome"].ToString();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tipo)
            {
                var auxCargo = cargos.verificarDuplicata(txtCargo.Text);
                if (txtCargo.TextLength > 0 && auxCargo.Count < 1)
                {
                    cargos.inserirCargo(txtCargo.Text.ToString(), cBoxInativo.Checked, false);

                    var idcargo = cargos.retornarUltimoIdCargo();

                    permissoes_vendas.inserirPermissoesVendas(cBoxLancarVendas.Checked, cBoxCancelarVendas.Checked
                        , cBoxSangria.Checked, cBoxDevolucoes.Checked, Convert.ToInt32(idcargo[0]["idCargo"]));

                    permissoes_estoque.inserirPermissoesEstoque(cBoxCriacaoDeProdutos.Checked, cBoxEditarProdutos.Checked
                        , cBoxEntradaDeProdutos.Checked, cBoxSaidaDeProdutos.Checked, Convert.ToInt32(idcargo[0]["idCargo"]));
                    Close();

                }
                else
                {
                    MessageBox.Show("Para salvar precisa inserir um nome ou o mesmo já existe");
                }
            }
            else
            {
                cargos.atualizarCargo(txtCargo.Text, !cBoxInativo.Checked,idCargo);
                permissoes_vendas.atualizarPermissoesVendas(cBoxLancarVendas.Checked, cBoxCancelarVendas.Checked
                    , cBoxSangria.Checked, cBoxDevolucoes.Checked, idCargo);

                permissoes_estoque.atualizarPermissoesEstoque(cBoxCriacaoDeProdutos.Checked, cBoxEditarProdutos.Checked
                    , cBoxEntradaDeProdutos.Checked, cBoxSaidaDeProdutos.Checked, idCargo);
                Close();
            }
        }

        private void cBoxVendas_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxVendas.Checked)
            {
                cBoxVendas.Checked = true;
                cBoxLancarVendas.Checked = true;
                cBoxCancelarVendas.Checked = true;
                cBoxSangria.Checked = true;
                cBoxDevolucoes.Checked = true;
            }
            else
            {
                cBoxVendas.Checked = false;
                cBoxLancarVendas.Checked = false;
                cBoxCancelarVendas.Checked = false;
                cBoxSangria.Checked = false;
                cBoxDevolucoes.Checked = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
