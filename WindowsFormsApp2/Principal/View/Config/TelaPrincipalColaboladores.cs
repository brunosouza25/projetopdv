using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Principal.View.Config
{
    public partial class TelaPrincipalColaboladores : UserControl
    {
        TelaColaboladores telaColaboladores = new TelaColaboladores();
        TelaCargos telaCargos = new TelaCargos();


        public TelaPrincipalColaboladores()
        {
            InitializeComponent();

            painelPrincipal.Controls.Add(telaColaboladores);

            painelPrincipal.Controls.Add(telaCargos);
            telaCargos.Visible = false;
        }

        public TelaPrincipal TelaPrincipal
        {
            get => default;
            set
            {
            }
        }

        private void btColaboladores_Click(object sender, EventArgs e)
        {
            telaColaboladores.Visible = true;
            telaCargos.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            telaColaboladores.Visible = false;
            telaCargos.Visible = true;
        }

        private void btnLogins_Click(object sender, EventArgs e)
        {
            TelaCadastroLogins telaLogin = new TelaCadastroLogins();
            telaLogin.ShowDialog();
        }
    }
}
