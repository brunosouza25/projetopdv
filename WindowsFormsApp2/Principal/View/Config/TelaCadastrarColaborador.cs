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
            tipo = true;
            preencherCargos();
        }
        Boolean tipo;
        int idColaborador;
        public TelaCadastrarColaborador(Boolean tipo, int idColaborador)
        {
            InitializeComponent();

            this.tipo = tipo;
            this.idColaborador = idColaborador;
            preencherCargos();
            carregarTela();
        }
        Colaborador colaborador = new Colaborador();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void carregarTela()
        {
            var auxColab = colaboladores.retornarColaboradorPorId(idColaborador);
            txtNome.Text = auxColab[0]["nomeFunc"].ToString();
            txtEmail.Text = auxColab[0]["email"].ToString();
            txtNasc.Text = auxColab[0]["dataNasc"].ToString();
            var auxCargo = cargos.retornarCargoPorId(Convert.ToInt32(auxColab[0]["idCargo"]));
            cbCargo.SelectedItem = auxCargo[0]["cargoNome"].ToString();
        }
        public void preencherCargos()
        {
            var todosCargos = cargos.retornarTodosCargos();
            for (int i = 0; i < todosCargos.Count; i++)
            {
                cbCargo.Items.Add(todosCargos[i]["cargoNome"].ToString());

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tipo)
            {
                if (txtNome.Text.Length > 0 && txtEmail.Text.Length > 0)
                {
                    int idCargo;
                    if (cbCargo.SelectedIndex == -1)
                    {
                        idCargo = 0;
                    }
                    else
                    {
                        var Cargo = cargos.retornarCargo(cbCargo.SelectedItem.ToString());
                        idCargo = Convert.ToInt32(Cargo[0]["idCargo"]);
                    }
                    DateTime a;

                    colaboladores.cadastrarColaborador(idCargo, txtNome.Text, DateTime.Now.ToString("dd/MM"), Convert.ToByte(!cbInativo.Checked)
                        , DateTime.Now.ToString("HH:mm"), txtEmail.Text);


                    Close();

                }
                else
                {
                    MessageBox.Show("Nome e e-mail são obrigatórios");

                }
            }
            else
            {
                int idCargo;


                    var Cargo = cargos.retornarCargo(cbCargo.SelectedItem.ToString());
                    idCargo = Convert.ToInt32(Cargo[0]["idCargo"]);

                DateTime a;
                if (!DateTime.TryParse(txtNasc.Text, out a))
                {
                    a = new DateTime(1111, 11, 11);
                }
                colaboladores.atualizarColaborador(idCargo, txtNome.Text, Convert.ToByte(!cbInativo.Checked), txtEmail.Text, idColaborador);
                Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public TelaColaboladores TelaColaboladores
        {
            get => default;
            set
            {
            }
        }

        internal Colaborador Colaborador
        {
            get => default;
            set
            {
            }
        }
    }
}
