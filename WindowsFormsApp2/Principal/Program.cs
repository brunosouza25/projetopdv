using System;
using WindowsFormsApp2.Principal.View;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    /**************************************************************************************
    versão 1.0
    **************************************************************************************/
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*
            DadosTableAdapters.Config_SistemaTableAdapter config = new DadosTableAdapters.Config_SistemaTableAdapter();
            var configSistema = config.retornarConfig();

            string mesHoje = DateTime.Now.ToString("MM");
            string mesBloqueio = Convert.ToDateTime(configSistema[0]["dataUltimoBloqueio"]).ToString("MM");


            if (mesHoje != mesBloqueio 
                && configSistema[0]["bloqueado"].ToString() == "0")
            {
                criptografrar();

                config.alterarConfig(1);
                Desbloqueio telaDesbloqueio = new Desbloqueio();
                telaDesbloqueio.ShowDialog();
            }
            var configSistema2 = config.retornarConfig();

            if (configSistema2[0]["bloqueado"].ToString() == "0")
            {
                TelaDeLogin login = new TelaDeLogin();
                Application.Run(new TelaDeLogin());
                //Application.Run(new TelaPrincipal());
            }

            void criptografrar()
            {
                DateTime data = Convert.ToDateTime(configSistema[0]["dataUltimoBloqueio"]);

                data = data.AddMonths(1);
                
                string senha = "brunosouza", senha2 = "";
                int num;
                int dia = Convert.ToInt32(data.ToString("dd"));

                int mes = Convert.ToInt32(data.ToString("MM"));

                int ano = Convert.ToInt32(data.ToString("yyyy"));

                int chave = (dia + mes + ano)%26;

                for(int i = 0; i < senha.Length; i++)
                {
                    num = (Convert.ToInt16(senha[i]) + chave);
                    if (num > 122)
                        num = num - 26;
                    senha2 += Convert.ToChar(num);
                }
                config.attSenha(senha2);
            }

    */
            TelaDeLogin login = new TelaDeLogin();
            Application.Run(new TelaDeLogin());
        }

    }
}
