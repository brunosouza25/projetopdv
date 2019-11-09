using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class TelaDeEstoque : UserControl
    {
        public TelaDeEstoque()
        {
            InitializeComponent();

        }


        private Boolean criar = false;
        Produto produtos = new Produto();
        private void Bt_Criar_Prod_Click(object sender, EventArgs e)
        {
            //AINDA NÃO CONCLUIDO "TENTANDO BLOQUEAR PARA EXIBIR APENAS UM POR VEZ"
            TelaCriarProd telaCriar = new TelaCriarProd();

            if (!telaCriar.criado)
            {
                
                telaCriar.Visible = true;
                telaCriar.criado = true;
            }

        }

        private void Bt_Entrar_Prod_Click_1(object sender, EventArgs e)
        {

        }

        private void TelaDeEstoque_Load(object sender, EventArgs e)
        {
            string caminho = @"c:\arquivos\arquivo.txt";
            string[] arquivo;
            try
            {
                arquivo = File.ReadAllLines(caminho);

                foreach (string linhas in arquivo)
                {
                    listaProdutos.Items.Add(arquivo[1]);
                }
            }
            catch (IOException er)
            {
                Console.WriteLine("Tivemos um erro ");
                Console.WriteLine(er.Message);
            }

        }

    }
}
