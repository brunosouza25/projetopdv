using System;
using System.Windows.Forms;
using WindowsFormsApp2.Vendas;
using WindowsFormsApp2.Principal.View.Config;
using System.IO;
using System.Linq;

namespace WindowsFormsApp2
{
    public partial class TelaPrincipal : Form
    {
        String Hora = (DateTime.Now.ToString("HH:mm:ss"));

        TelaPrincipalEstoque estoque = new TelaPrincipalEstoque();
        TelaDeRelatorios relatorio = new TelaDeRelatorios();
        TelaDeVendas telaDoPdv = new TelaDeVendas();
        TelaConfig telaDeConfig = new TelaConfig();
        Fiscal fiscal = new Fiscal();

        public TelaPrincipal()
        {
            InitializeComponent();

            //caixa

            //estoque
            if (Global.entradaProdutos == false && Global.saidaProdutos == false && Global.editarProdutos == false && Global.criacaoProduto == false) {
                estoque.Enabled = false;
                estoque.Visible = false;
                BtEstoque.Visible = false;
                lblEstoque.Visible = false;
            }
            if (Global.adm == false)
            {
                telaDeConfig.Enabled = false;
                btnConfig.Visible = false;
                lblConfiguracoes.Visible = false;
            }

            painelPrincipal.Controls.Add(estoque);
            estoque.Visible = false;
                
            //relatorios
            painelPrincipal.Controls.Add(relatorio);
            relatorio.Visible = false;
            //vendas
            
            painelPrincipal.Controls.Add(telaDoPdv);
            telaDoPdv.Visible = false;

            painelPrincipal.Controls.Add(telaDeConfig);
            telaDeConfig.Visible = false;

            if (Global.cancelarVendas == false && Global.lancarVendas == false && Global.sangria == false && Global.devolucoes == false)
            {
                telaDoPdv.Enabled = false;
                telaDoPdv.Visible = false;
                btCaixa.Visible = false;
                lblVendas.Visible = false;
            }
            if (Global.adm == false)
            {
                telaDeConfig.Enabled = false;
                telaDeConfig.Visible = false;
                btnConfig.Visible = false;
            }
        }

        public TelaConfig TelaConfig
        {
            get => default;
            set
            {
            }
        }

        public TelaDeLogin TelaDeLogin
        {
            get => default;
            set
            {
            }
        }

        public void mudarEstoque()
        {
            estoque.Visible = !estoque.Visible;
            estoque.estoque.carregarListaEstoque();
        }
        public void mudarCaixa()
        {
            telaDoPdv.Visible = !telaDoPdv.Visible;
        }
        public void mudarRelatorio()
        {
            relatorio.Visible = !relatorio.Visible;
        }

        public void mudarConfig()
        {
            telaDeConfig.Visible = !telaDeConfig.Visible;
        }

        private void BtRelatorio_Click(object sender, EventArgs e)
        {
            if (estoque.Visible)
            {
                mudarEstoque();
            }
            if (telaDoPdv.Visible)
            {
                mudarCaixa();
            }
            if (telaDeConfig.Visible)
            {
                mudarConfig();
            }
            relatorio.Visible = true;
        }
        private void BtCaixa_Click(object sender, EventArgs e)
        {
            if (estoque.Visible)
            {
                mudarEstoque();
            }
            if (relatorio.Visible)
            {
                mudarRelatorio();
            }
            if (telaDeConfig.Visible)
            {
                mudarConfig();
            }
            telaDoPdv.Visible = true;

        }
        private void BtEstoque_Click(object sender, EventArgs e){
            if (telaDoPdv.Visible)
            {
                mudarCaixa();
            }
            if (relatorio.Visible)
            {
                mudarRelatorio();
            }
            if (telaDeConfig.Visible)
            {
                mudarConfig();
            }
            estoque.Visible = true;
            estoque.estoque.carregarListaEstoque();
        }
        private void BtConfig_Click(object sender, EventArgs e)
        {
            if (telaDoPdv.Visible)
            {
                mudarCaixa();
            }
            if (estoque.Visible)
            {
                mudarEstoque();
            }
            if (relatorio.Visible)
            {
                mudarRelatorio();
            }
            telaDeConfig.Visible = true;
        }

        //Timer para alterar a label de data e hora
        private void timer1_Tick(object sender, EventArgs e)
        {
           Lab_Hora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
           timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // C: \Users\bruno\Desktop\notas\temporario
            DirectoryInfo diretorio = new DirectoryInfo(@"C:\Users\bruno\Desktop\notas\temporario");
            FileInfo[] arquivos = diretorio.GetFiles();

            foreach (FileInfo arquivo in arquivos)
            {
                MessageBox.Show(arquivo.Name);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string path = @"C:\pdv\videos\";
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //Trocar o caminho da imagem
            startInfo.FileName = path;
            System.Diagnostics.Process.Start(startInfo);
        }
    }
}
