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
        TelaPrincipal tela = new TelaPrincipal();
        DadosTableAdapters.FuncionarioTableAdapter funcionario = new DadosTableAdapters.FuncionarioTableAdapter();
        public void validar(string login, string senha)
        {
            
            var func = funcionario.verificarFunc(login);

            
            string login2, pass;
            if (func.Count > 0)
            {
                pass = func[0]["senha"].ToString();
                if (senha == pass)
                {
                    this.Visible = false;
                    tela.ShowDialog();
                    Close();
                }
                else
                    MessageBox.Show("Login ou senha errados");
            }
            else
                MessageBox.Show("Login ou senha errados");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            validar(TxtBoxUser.Text, TxtBoxPass.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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
