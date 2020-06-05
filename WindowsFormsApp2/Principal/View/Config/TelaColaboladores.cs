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

        public void carregarColaboradores()
        {
            var auxColaboradores = colaboradores.retornarTodosColaboradores();

            for(int i = 0; i < auxColaboradores.Count; i++)
            {
                listaColaboradores.Items.Clear();
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

                listaColaboradores.Items.Add(item);
            }
        }

        private void btCadastrarColaborador(object sender, EventArgs e)
        {
            TelaCadastrarColaborador telaCadastrarColaborador = new TelaCadastrarColaborador();

            telaCadastrarColaborador.ShowDialog();
            carregarColaboradores();
        }
    }
}
