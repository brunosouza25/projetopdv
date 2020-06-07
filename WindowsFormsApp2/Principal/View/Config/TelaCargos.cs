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
    public partial class TelaCargos : UserControl
    {
        DadosTableAdapters.CargoTableAdapter cargos = new DadosTableAdapters.CargoTableAdapter();

        public TelaCargos()
        {
            InitializeComponent();
            carregarListaCargos();
        }

        private void btnCadastrarCargo_Click(object sender, EventArgs e)
        {
            TelaCadastroCargo telaCargos = new TelaCadastroCargo();
            telaCargos.ShowDialog();
            carregarListaCargos();
        }
        public void carregarListaCargos()
        {
            listaCargos.Items.Clear();
            var auxCargos = cargos.retornarTodosCargos();
   

            for (int i = 2; i < auxCargos.Count; i++)
            {
                ListViewItem item = new ListViewItem();
              
                /*MessageBox.Show(Convert.ToInt32(auxCargos[0]["estadoCargo"]).ToString());
                if (!Convert.ToBoolean(auxCargos[i]["estadoCargo"]))
                {
                    item.BackColor = System.Drawing.Color.Gray;
                }*/
                item.SubItems.Add(auxCargos[i]["cargoNome"].ToString());
                item.SubItems.Add(auxCargos[i]["idCargo"].ToString());

                /*if (Convert.ToBoolean(auxCargos[i]["estadoCargo"]))
                {
                    item.SubItems.Add("Ativo");
                }
                item.SubItems.Add("Inativo");*/
                listaCargos.Items.Add(item);
            }
        }

        private void btnEditarCargos_Click(object sender, EventArgs e)
        {
            if (listaCargos.SelectedItems.Count > 0)
            {
                TelaCadastroCargo telaEditarCargo = new TelaCadastroCargo(false, Convert.ToInt32(listaCargos.SelectedItems[0].SubItems[2].Text));
                telaEditarCargo.ShowDialog();
                carregarListaCargos();
            }
            else
            {
                MessageBox.Show("Nenhum cargo selecionado");
            }
        }
        
    }
}
