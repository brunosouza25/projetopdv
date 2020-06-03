﻿using System;
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
    public partial class TelaConfig : UserControl
    {
        TelaPrincipalColaboladores principalColaboladores = new TelaPrincipalColaboladores();
        public TelaConfig()
        {
            
            InitializeComponent();
            painelMainConfig.Controls.Add(principalColaboladores);
        }

        private void btColaboladores_Click(object sender, EventArgs e)
        {
            principalColaboladores.Visible = true;
        }
    }
}
