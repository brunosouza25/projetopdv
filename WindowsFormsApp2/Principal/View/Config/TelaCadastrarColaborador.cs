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
    public partial class TelaCadastrarColaborador : Form
    {
        DadosTableAdapters.FuncionarioTableAdapter colaboladores = new DadosTableAdapters.FuncionarioTableAdapter();
        DadosTableAdapters.
        public TelaCadastrarColaborador()
        {

            InitializeComponent();
        }
        Colaborador colaborador = new Colaborador();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Length > 0 || txtEmail.Text.Length > 0)
            {
                colaboladores.criarColaborador()
            }
            else
            {
                MessageBox.Show("Nome e e-mail são obrigatórios");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
