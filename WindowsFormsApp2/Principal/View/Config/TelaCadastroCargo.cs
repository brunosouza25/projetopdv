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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCargo.TextLength > 0)
            {
                cargos.inserirCargo(txtCargo.Text.ToString(), cBoxInativo.Checked);

                var idcargo = cargos.retornarUltimoIdCargo();

                permissoes_vendas.inserirPermissoesVendas(cBoxVendas.Checked, cBoxLancarVendas.Checked, cBoxCancelarVendas.Checked
                    , cBoxSangria.Checked, cBoxDevolucoes.Checked, Convert.ToInt32(idcargo[0]["idCargo"]));

                permissoes_estoque.inserirPermissoesEstoque(cBoxEstoque.Checked, cBoxCriacaoDeProdutos.Checked, cBoxEditarProdutos.Checked
                    , cBoxEntradaDeProdutos.Checked, cBoxSaidaDeProdutos.Checked, Convert.ToInt32(idcargo[0]["idCargo"]));
                Close();

            }
            else
            {
                MessageBox.Show("Para salvar precisa inserir um nome");
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
