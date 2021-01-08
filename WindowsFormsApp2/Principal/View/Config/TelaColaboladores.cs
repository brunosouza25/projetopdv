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
    public partial class TelaColaboladores : UserControl
    {
        DadosTableAdapters.FuncionarioTableAdapter colaboradores = new DadosTableAdapters.FuncionarioTableAdapter();
        DadosTableAdapters.CargoTableAdapter cargos = new DadosTableAdapters.CargoTableAdapter();
        public TelaColaboladores()
        {
            InitializeComponent();
            carregarColaboradores();
        }

        public TelaConfig TelaConfig
        {
            get => default;
            set
            {
            }
        }

        public TelaCadastroLogins TelaCadastroLogins
        {
            get => default;
            set
            {
            }
        }

        public TelaCargos TelaCargos
        {
            get => default;
            set
            {
            }
        }

        public void carregarColaboradores()
        {
            var auxColaboradores = colaboradores.retornarTodosColaboradores();
            listaColaboradores.Items.Clear();
            for (int i = 0; i < auxColaboradores.Count; i++)
            {
                
                ListViewItem item = new ListViewItem();

                item.SubItems.Add(auxColaboradores[i]["nomeFunc"].ToString());

                var auxCargos = cargos.retornarCargoPorId(Convert.ToInt32(auxColaboradores[i]["idCargo"]));

                item.SubItems.Add(auxCargos[0]["cargoNome"].ToString());

                if (Convert.ToBoolean(auxColaboradores[i]["funcEstado"]))
                {
                    item.SubItems.Add("Ativo");
                }
                else
                {
                    item.SubItems.Add("Inativo");
                }
                item.SubItems.Add(auxColaboradores[i]["idFuncionario"].ToString());
                if(Global.nomeColaborador != auxColaboradores[i]["nomeFunc"].ToString())
                    listaColaboradores.Items.Add(item);
            }
        }

        private void btCadastrarColaborador(object sender, EventArgs e)
        {
            TelaCadastrarColaborador telaCadastrarColaborador = new TelaCadastrarColaborador();

            telaCadastrarColaborador.ShowDialog();
            carregarColaboradores();
        }

        private void Bt_Editar_Prod_Click(object sender, EventArgs e)
        {
            if(listaColaboradores.SelectedItems.Count > 0)
            {
                TelaCadastrarColaborador telaCadastrarColaborador = new TelaCadastrarColaborador(false, Convert.ToInt32(listaColaboradores.SelectedItems[0].SubItems[4].Text));
                telaCadastrarColaborador.ShowDialog();
                carregarColaboradores();
            }
            else
            {
                MessageBox.Show("Não foi selecionado nenhum colaborador");
            }
        }
    }
}
