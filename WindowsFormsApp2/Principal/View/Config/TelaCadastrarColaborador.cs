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
        DadosTableAdapters.CargoTableAdapter cargos = new DadosTableAdapters.CargoTableAdapter();
        public TelaCadastrarColaborador()
        {

            InitializeComponent();
        }
        Colaborador colaborador = new Colaborador();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void preencher_cargos() {
            var todosCargos = cargos.retornarTodosCargos();
            for(int i = 0; i >= todosCargos.Count; i++)
            {
                cbCargo.Items.Add(todosCargos[i]["cargoNome"].ToString());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Length > 0 && txtEmail.Text.Length > 0)
            {
                int idCargo;
                if(cbCargo.SelectedItem.ToString() == "")
                {
                    idCargo = 0;
                }
                else
                {
                    var Cargo = cargos.retornarCargo(cbCargo.SelectedItem.ToString());
                    idCargo = Convert.ToInt32(Cargo[0]["idCargo"]);
                }
                colaboladores.criarColaborador(idCargo, txtNome.Text,txtNasc.Text, Convert.ToByte(cbSexo.SelectedItem)
                    , DateTime.Now.ToString("dd:MM"), DateTime.Now.ToString("HH:mm"), Convert.ToByte(cbInativo.Checked), txtEmail.Text);

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
