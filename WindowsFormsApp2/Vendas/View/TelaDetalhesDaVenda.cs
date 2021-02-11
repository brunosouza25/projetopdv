using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp2.Vendas.View
{
    public partial class TelaDetalhesDaVenda : Form
    {
        DadosTableAdapters.DataRelatorioTableAdapter detalheVenda = new DadosTableAdapters.DataRelatorioTableAdapter();
        DadosTableAdapters.ProdutoTableAdapter dadosProdutos = new DadosTableAdapters.ProdutoTableAdapter();
        DadosTableAdapters.Itens_DevolucaoTableAdapter devolucao = new DadosTableAdapters.Itens_DevolucaoTableAdapter();
        DadosTableAdapters.FuncionarioTableAdapter colaborador = new DadosTableAdapters.FuncionarioTableAdapter();
        DadosTableAdapters.VendaTableAdapter vendas = new DadosTableAdapters.VendaTableAdapter();

        int codVenda;
        int idDin = -1, idCredVista = -1, idDeb = -1, idCredParc = -1;
        List<Produto> listaProduto = new List<Produto>();

        DadosTableAdapters.fiscalTableAdapter fiscal = new DadosTableAdapters.fiscalTableAdapter();


        public TelaDetalhesDaVenda(int codVenda)
        {
            InitializeComponent();
            this.codVenda = codVenda;
            carregarTela();
            if (Global.cancelarVendas == false)
            {
                btnCancelarVenda.Visible = false;
            }
        }

        public ListaDeVendas ListaDeVendas
        {
            get => default;
            set
            {
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {

            if (devolucao.verificarDevolucao(codVenda).Count < 1)
            {
                if (MessageBox.Show("Tem certeza?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DadosTableAdapters.Vendas_CanceladasTableAdapter cancelamento = new DadosTableAdapters.Vendas_CanceladasTableAdapter();
                    DadosTableAdapters.CaixaTableAdapter caixa = new DadosTableAdapters.CaixaTableAdapter();
                    int aux = 0;
                    int idprod;
                    for (int i = 0; i < listaProduto.Count; i++)
                    {
                        var aux2 = dadosProdutos.PegaQuantidadePorCod(listaProduto[i].prodCodBarras);
                        aux = Convert.ToInt32(aux2[0]["prodQuantidade"]) + listaProduto[i].prodQuantidade;
                        dadosProdutos.AttQuantidade(aux, Convert.ToInt32(aux2[0]["idProduto"]));
                    }
                    detalheVenda.cancelarVenda(Convert.ToByte(0), codVenda);
                    var venda = detalheVenda.retornarVendaPorId(codVenda);
                    cancelamento.InserirCancelamento(codVenda, venda[0]["vendData"].ToString(), DateTime.Now.ToString("dd/MM/yyyy")
                    , DateTime.Now.ToString("HH:mm"), Convert.ToDouble(venda[0]["valorCompra"]) - Convert.ToDouble(txtBoxDesc.Text));
                    var idCaixa = caixa.pegarIDUltimoCaixa();
                    var caixaAtual = caixa.pegarCaixaPorID(Convert.ToInt32(idCaixa[0]["idCaixa"]));
                    var valorPago = cancelamento.retornarVendaCanceladaPorId(codVenda);
                    caixa.attValorAtual(Convert.ToDouble(caixaAtual[0]["valorAtual"]) - Convert.ToDouble(valorPago[0]["valorDaVenda"]), Convert.ToInt32(idCaixa[0]["idCaixa"]));
                }
            }
            else
            {
                MessageBox.Show("Não foi possível cancelar esta venda, pois a mesma tem itens devolvidos, devolva o restante para simular um cancelamento!");
            }
            Close();
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimirSegundaVia_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!Directory.Exists(@"C:\pdv\fiscal\entrada\"))
                {
                    Directory.CreateDirectory(@"C:\pdv\fiscal\entrada\");
                }
                StreamWriter x;
                string caminho = @"C:\pdv\fiscal\entrada\enviar.txt";

                x = File.CreateText(caminho);
                var auxFiscal = fiscal.segundaVia(codVenda);
                //MessageBox.Show("NFe.CriarNFe(" + auxFiscal[0]["caminhoXml"].ToString() + ",1)");
                x.WriteLine("NFe.CriarNFe("+auxFiscal[0]["caminhoXml"].ToString()+",1)");
                
                x.Close();
                Thread.Sleep(1000);
            }
            catch (Exception er)
            {
                MessageBox.Show("Encontramos um erro, favor contatar o suporte");
                MessageBox.Show(er.Message);
            }
            try
            {
                StreamWriter x;
                if (!Directory.Exists(@"C:\pdv\fiscal\entrada\"))
                {
                    Directory.CreateDirectory(@"C:\pdv\fiscal\entrada\");
                }

                if (!Directory.Exists("C:\\pdv\\fiscal\\temporario\\"))
                {
                    Directory.CreateDirectory("C:\\pdv\\fiscal\\temporario\\");
                }

                if (!Directory.Exists(@"C:\pdv\fiscal\xmls\"))
                {
                    Directory.CreateDirectory(@"C:\pdv\fiscal\xmls\");
                }
                string caminho = @"C:\pdv\fiscal\entrada\enviar.txt";
                // C: \Users\bruno\Desktop\notas\temporario
                DirectoryInfo diretorio = new DirectoryInfo(@"C:\pdv\fiscal\temporario");
                FileInfo[] arquivos = diretorio.GetFiles();

                foreach (FileInfo arquivo in arquivos)
                {
                    x = File.CreateText(caminho);
                    x.WriteLine("NFE.ImprimirDanfe(\"C:\\pdv\\fiscal\\temporario\\" + arquivo.Name + "\", \"\"Doro PDF Writer\",\"1\",\"\",\"\",\"\",\"\",\"\")");
                    x.Close();
                    Thread.Sleep(1000);
                    MessageBox.Show("cupom emitido com sucesso!");
                    File.Delete("C:\\pdv\\fiscal\\temporario\\" + arquivo.Name);

                    Thread.Sleep(1000);

                }

                MessageBox.Show("cupom emitido com sucesso!");
            }
            catch (Exception er)
            {
                MessageBox.Show("Encontramos um erro, favor contatar o suporte");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
                string auxObs;
            if (txtBoxObs.Text.Length < 300)
            {
                auxObs = txtBoxObs.Text;
                detalheVenda.attObs(auxObs, codVenda);
            }
            else
            {
                MessageBox.Show("O limite de caracteres no campo observação é maior de 300, será cortado o restante");
                auxObs = txtBoxObs.Text.Substring(0, 299);
                detalheVenda.attObs(auxObs, codVenda);
            }
            Close();
        }
        private void carregarTela()
        {
            var auxVenda = detalheVenda.retornarVendaPorId(codVenda);
            var auxProdutosVenda = detalheVenda.retornarItensDaVenda(codVenda);
            var pagamentosVenda = detalheVenda.pagamentosVenda(codVenda);
            var venda = vendas.retornarVendaPorId(codVenda);
            var auxColaborador = colaborador.retornarColaboradorPorId(Convert.ToInt32(venda[0]["idColaborador"]));
            txtFuncionario.Text = auxColaborador[0]["nomeFunc"].ToString();
            txtBoxObs.Text = auxVenda[0]["observacoes"].ToString();
            if (Convert.ToByte(auxVenda[0]["vendaEstado"]) == 0)
                btnCancelarVenda.Enabled = false;
            List<string> tipos = new List<string>();
            for (int i = 0; i < pagamentosVenda.Count; i++)
            {
                tipos.Add(pagamentosVenda[i]["pagamentoTipo"].ToString());
                if (tipos[i] == "DINHEIRO")
                    idDin = i;
                if (tipos[i] == "CREDITO A VISTA")
                    idCredVista = i;
                if (tipos[i] == "CREDITO PARCELADO")
                    idCredParc = i;
                if (tipos[i] == "DEBITO")
                    idDeb = i;
            }

            txtBoxDesc.Text = Convert.ToDouble(pagamentosVenda[0]["valorDesconto"]).ToString("F2");

            if (idDin >= 0)
            {
                txtBoxDin.Text = Convert.ToDouble(pagamentosVenda[idDin]["PagValor"]).ToString("F2");

            }
            if (idCredVista >= 0)
                txtBoxCredVista.Text = Convert.ToDouble(pagamentosVenda[idCredVista]["PagValor"]).ToString("F2");
            if (idCredParc >= 0)
                txtBoxCredParc.Text = Convert.ToDouble(pagamentosVenda[idCredParc]["PagValor"]).ToString("F2");
            if (idDeb >= 0)
                txtBoxDebt.Text = Convert.ToDouble(pagamentosVenda[idDeb]["PagValor"]).ToString("F2");

            lblNumVenda.Text = auxVenda[0]["idVenda"].ToString();

            lblTotal.Text = Convert.ToDouble(auxVenda[0]["valorCompra"]).ToString("F2");

            lblData.Text = Convert.ToDateTime(auxVenda[0]["vendData"]).ToString("dd/MM/yyyy");
            lblHora.Text = auxVenda[0]["vendHora"].ToString().Substring(0,5);
           
            for (int i = 0; i < auxProdutosVenda.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                /*int qnt = 0;
                
                for (int j = 0; j <= auxProdutosVenda.Count - 1; j++)
                {
                    if (auxProdutosVenda[i]["prodNome"].ToString() == auxProdutosVenda[j]["prodNome"].ToString())
                    {
                        qnt += 1;
                    }
                }
                */
                Produto prod = new Produto();
                prod.prodNome = auxProdutosVenda[i]["prodNome"].ToString();
                prod.prodCodBarras = auxProdutosVenda[i]["codBarras"].ToString();
                prod.prodValor = Convert.ToDouble(auxProdutosVenda[i]["valorDeVenda"]);
                //prod.prodValor = Convert.ToDouble(auxProdutosVenda[i]["prodValor"]);
                prod.prodQuantidade = Convert.ToInt32(auxProdutosVenda[i]["itensQtd"]);

                item.SubItems.Add(prod.prodNome);
                item.SubItems.Add(prod.prodCodBarras);
                item.SubItems.Add(prod.prodValor.ToString("F2"));
                item.SubItems.Add("");
                item.SubItems.Add(prod.prodQuantidade.ToString());
                bool achou = false;

                for (int j = 0; j < listaProduto.Count; j++)
                {
                    if (listaProduto[j].prodNome == prod.prodNome)
                    {
                        achou = true;
                        listaProduto[j].prodQuantidade = prod.prodQuantidade + listaProduto[j].prodQuantidade;
                    }
                }
                if (!achou)
                {
                    listaProduto.Add(prod);
                }
                double aux = Convert.ToDouble(auxVenda[i]["prodValor"]) * Convert.ToInt32(auxProdutosVenda[i]["itensQtd"]);
                item.SubItems.Add(aux.ToString("F2"));
                listaVendas.Items.Add(item);
            }
        }

        private void listaVendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
