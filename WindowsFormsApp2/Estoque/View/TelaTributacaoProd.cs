using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Estoque.View
{
    public partial class TelaTributacaoProd : UserControl
    {
        DadosTableAdapters.ProdutoTableAdapter produtos = new DadosTableAdapters.ProdutoTableAdapter();
        public TelaTributacaoProd()
        {
            InitializeComponent();
        }
        public void Criar_EditarProdTributacao()
        {
            double a, b;

        }
    }
}
