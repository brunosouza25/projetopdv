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
    public partial class TelaConfigFiscal : Form
    {
        DadosTableAdapters.Config_SistemaTableAdapter config = new DadosTableAdapters.Config_SistemaTableAdapter();

        public TelaConfigFiscal()
        {
            InitializeComponent();
            carregarDadosFiscais();
        }
        public void salvarConfigFiscal()
        {
            if (ckBoxFiscal.Checked)
            {
                travar_LiberarFiscal(true);
                if (cBoxRegimeTributario.SelectedItem != null && txtBoxCnpjEmpresa.Text != "" && txtBoxIE.Text != "" && txtBoxSenhaSat.Text != "" && rTxtBoxCodSat.Text != "")

                {

                    ulong b;
                    if (ulong.TryParse(txtBoxCnpjEmpresa.Text.Trim(), out b) && ulong.TryParse(txtBoxIE.Text.Trim(), out b) && ulong.TryParse(txtBoxSenhaSat.Text.Trim(), out b) && ulong.TryParse(txtBoxIE.Text.Trim(), out b))
                    {
                        config.attFiscal(true);
                        config.attDadosFiscais(txtBoxCnpjEmpresa.Text.Trim(), txtBoxIE.Text.Trim(), txtCnpjSH.Text.Trim(), txtBoxSenhaSat.Text.Trim(), rTxtBoxCodSat.Text.Trim(), cBoxRegimeTributario.SelectedItem.ToString());
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Dados inválidos");
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, preencher todos os dados");
                }
            }
            else
            {
                config.attFiscal(false);
                travar_LiberarFiscal(false);
            }
        }
        public void travar_LiberarFiscal(bool travar)
        {
            txtBoxCnpjEmpresa.Enabled = travar;
            txtBoxIE.Enabled = travar;
            txtBoxSenhaSat.Enabled = travar;
            txtCnpjSH.Enabled = false;
            rTxtBoxCodSat.Enabled = travar;
            cBoxRegimeTributario.Enabled = travar;
        }
        public void carregarDadosFiscais()
        {
            var auxConfig = config.retornarConfig();
            if (Convert.ToBoolean(auxConfig[0]["fiscal"]) == true)
            {
                travar_LiberarFiscal(true);
                txtBoxCnpjEmpresa.Text = auxConfig[0]["cnpjEmpresa"].ToString();
                txtBoxIE.Text = auxConfig[0]["inscricaoEstadual"].ToString();
                txtBoxSenhaSat.Text = auxConfig[0]["senhaSat"].ToString();
                txtCnpjSH.Text = auxConfig[0]["cnpjSoftwareHouse"].ToString();
                rTxtBoxCodSat.Text = auxConfig[0]["assinaturaAC"].ToString();
            }
            else
            {
                travar_LiberarFiscal(false);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvarConfigFiscal();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            config.attFiscal(ckBoxFiscal.Checked);
            travar_LiberarFiscal(ckBoxFiscal.Checked);
        }
    }
}
