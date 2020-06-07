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
    public partial class TelaCadastroLogins : Form
    {
        DadosTableAdapters.FuncionarioTableAdapter colaboradores = new DadosTableAdapters.FuncionarioTableAdapter();

        public TelaCadastroLogins()
        {
            InitializeComponent();
            carregarColaboradores();
        }
        public void carregarColaboradores()
        {
            var auxColaboradores = colaboradores.retornarTodosColaboradores();
            
            for (int i = 0; i < auxColaboradores.Count; i++)
            {
                if (auxColaboradores[i]["log_in"].ToString() == String.Empty || Convert.ToInt32(auxColaboradores[i]["idFuncionario"]) == Global.idColaborador)
                    cbColaborador.Items.Add(auxColaboradores[i]["nomeFunc"].ToString());
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtBoxRepetirSenha.Text && cbColaborador.SelectedItem != "")
            {
                var idColab = colaboradores.verificarFunc(cbColaborador.SelectedItem.ToString());
                colaboradores.cadastrarLogin(txtLogin.Text, txtSenha.Text, Convert.ToInt32(idColab[0]["idFuncionario"]));
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
