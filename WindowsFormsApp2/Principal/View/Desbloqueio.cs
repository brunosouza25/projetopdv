using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Principal.View
{
    public partial class Desbloqueio : Form
    {
        DadosTableAdapters.Config_SistemaTableAdapter config = new DadosTableAdapters.Config_SistemaTableAdapter();
        
        public Desbloqueio()
        {
            InitializeComponent();
        }



        private void painelPrincipal_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            var configSistema = config.retornarConfig();
            if(txtBoxSenha.Text.Trim() == configSistema[0]["senha"].ToString())
            {
                config.alterarConfig(0);
                MessageBox.Show("Sistema liberado!");
                config.attData(DateTime.Now.ToString("01/MM/yyyy"));
                Close();
            }
            else
            {
                MessageBox.Show("Senha errada");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
