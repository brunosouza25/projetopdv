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
            preencherCargos();
        }
        Colaborador colaborador = new Colaborador();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void preencherCargos() {
            var todosCargos = cargos.retornarTodosCargos();
            for(int i = 0; i < todosCargos.Count; i++)
            {
                cbCargo.Items.Add(todosCargos[i]["cargoNome"].ToString());

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Length > 0 && txtEmail.Text.Length > 0)
            {
                int idCargo;
                MessageBox.Show(cbCargo.SelectedIndex.ToString());
                if(cbCargo.SelectedIndex == -1)
                {
                    idCargo = 0;
                }
                else
                {
                    var Cargo = cargos.retornarCargo(cbCargo.SelectedItem.ToString());
                    idCargo = Convert.ToInt32(Cargo[0]["idCargo"]);
                }
                colaboladores.cadastrarColaborador(idCargo, txtNome.Text, txtNasc.Text, Convert.ToByte(cbSexo.SelectedItem)
                    , DateTime.Now.ToString("dd:MM"),  Convert.ToByte(cbInativo.Checked)
                    , DateTime.Now.ToString("HH:mm"), txtEmail.Text);

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
