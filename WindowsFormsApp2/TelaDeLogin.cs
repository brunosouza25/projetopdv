using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void TxtBoxUser_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtBoxPass_Enter(object sender, EventArgs e)
        {

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
