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
                if (auxColaboradores[i]["log_in"].ToString() == String.Empty)
                    cbColaborador.Items.Add(auxColaboradores[i]["nomeFunc"].ToString());
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
