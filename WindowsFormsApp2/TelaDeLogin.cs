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

        public void validar(string login, string senha)
        {
            if (login == "admin" && senha == "admin")
            {
                this.Visible = false;
                tela.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Login ou senha errados");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            validar(TxtBoxPass.Text, TxtBoxUser.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }




        private void TxtBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validar(TxtBoxPass.Text, TxtBoxUser.Text);
            }
        }
    }
}
