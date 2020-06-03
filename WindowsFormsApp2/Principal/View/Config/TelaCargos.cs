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
        TelaCadastroCargo cargos = new TelaCadastroCargo();
        public TelaCargos()
        {
            InitializeComponent();
        }

        private void Bt_Criar_Prod_Click(object sender, EventArgs e)
        {
            cargos.ShowDialog();
        }
    }
}
