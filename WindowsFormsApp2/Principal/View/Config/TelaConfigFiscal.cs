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
                /*                travar_LiberarFiscal(true);
                if (cBoxRegimeTributario.SelectedItem != null && txtBoxCnpjEmpresa.Text != "" && txtBoxIE.Text != "" && txtBoxSenhaSat.Text != "" 
                    && rTxtBoxCodSat.Text != "" && txtBoxRazaoSocial.Text != "" && txtBoxNomeFantasia.Text != "" && txtBoxTelefone.Text != "" && txtBoxCep.Text != "" 
                    && txtBoxLogradouro.Text != "" && txtBoxNumero.Text != "" && txtBoxBairro.Text != "" && txtBoxCidade.Text != "" && txtBoxCodCidade.Text != "" && txtBoxUf.Text != "")
*/              bool cnpjOk = false;
                if(txtBoxCnpjEmpresa.Text.Length == 11)
                {
                    cnpjOk = true;
                }
                else if(txtBoxCnpjEmpresa.Text.Length == 14) {
                    cnpjOk = true;
                }
                travar_LiberarFiscal(true);
                if (cBoxRegimeTributario.SelectedItem != null && cnpjOk && txtBoxIE.Text.Length == 9 && txtBoxRazaoSocial.Text.Length >= 2 && txtBoxNomeFantasia.Text.Length >= 2 && txtBoxTelefone.Text.Length >= 11 && txtBoxCep.Text.Length == 8
                    && txtBoxLogradouro.Text.Length >= 2 && txtBoxNumero.Text != "" && txtBoxBairro.Text.Length >= 2 && txtBoxCidade.Text.Length >= 2 && txtBoxCodCidade.Text.Length == 7 && txtBoxUf.Text != "")

                {

                    ulong b;
                    if (ulong.TryParse(txtBoxCnpjEmpresa.Text.Trim(), out b) && ulong.TryParse(txtBoxIE.Text.Trim(), out b)
                        && ulong.TryParse(txtBoxIE.Text.Trim(), out b))
                    {
                        config.attFiscal(true);
                        config.attDadosFiscais(
                              txtBoxCnpjEmpresa.Text.Trim(), txtBoxIE.Text.Trim(), cBoxRegimeTributario.SelectedItem.ToString()
                            , txtBoxRazaoSocial.Text.Trim(), txtBoxNomeFantasia.Text.Trim(), txtBoxTelefone.Text.Trim()
                            , txtBoxCep.Text.Trim(), txtBoxLogradouro.Text.Trim(), txtBoxNumero.Text.Trim(), txtBoxBairro.Text.Trim()
                            , txtBoxCidade.Text.Trim(), txtBoxCodCidade.Text.Trim(), txtBoxUf.Text.Trim());
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
                travar_LiberarFiscal(false);
            }
        }
        public void travar_LiberarFiscal(bool travar)
        {
            txtBoxCnpjEmpresa.Enabled = travar;
            txtBoxIE.Enabled = travar;
            //txtBoxSenhaSat.Enabled = travar;
            //txtCnpjSH.Enabled = false;
            //rTxtBoxCodSat.Enabled = travar;
            cBoxRegimeTributario.Enabled = travar;
            txtBoxRazaoSocial.Enabled = travar;
            txtBoxNomeFantasia.Enabled = travar;
            txtBoxTelefone.Enabled = travar;
            txtBoxCep.Enabled = travar;
            txtBoxLogradouro.Enabled = travar;
            txtBoxNumero.Enabled = travar;
            txtBoxBairro.Enabled = travar;
            txtBoxCidade.Enabled = travar;
            txtBoxCodCidade.Enabled = travar;
            txtBoxUf.Enabled = travar;
        }
        public void carregarDadosFiscais()
        {
            var auxConfig = config.retornarConfig();
            if (Convert.ToBoolean(auxConfig[0]["fiscal"]) == true)
            {
                travar_LiberarFiscal(true);
                txtBoxCnpjEmpresa.Text = auxConfig[0]["cnpjEmpresa"].ToString();
                txtBoxIE.Text = auxConfig[0]["inscricaoEstadual"].ToString();
                //txtBoxSenhaSat.Text = auxConfig[0]["senhaSat"].ToString();
                //txtCnpjSH.Text = auxConfig[0]["cnpjSoftwareHouse"].ToString();
                //rTxtBoxCodSat.Text = auxConfig[0]["assinaturaAC"].ToString();
                txtBoxRazaoSocial.Text = auxConfig[0]["razaoSocial"].ToString();
                txtBoxNomeFantasia.Text = auxConfig[0]["nomeFantasia"].ToString();
                txtBoxTelefone.Text = auxConfig[0]["telefone"].ToString();
                txtBoxCep.Text = auxConfig[0]["cep"].ToString();
                txtBoxLogradouro.Text = auxConfig[0]["logradouro"].ToString();
                txtBoxNumero.Text = auxConfig[0]["numero"].ToString(); ;
                txtBoxBairro.Text = auxConfig[0]["bairro"].ToString();
                txtBoxCidade.Text = auxConfig[0]["cidade"].ToString();
                txtBoxCodCidade.Text = auxConfig[0]["codigoCidade"].ToString();
                txtBoxUf.Text = auxConfig[0]["uf"].ToString();
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
