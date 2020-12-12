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
        bool tipo = false;
        int idProduto;

        public TelaTributacaoProd()
        {
            InitializeComponent();
        }
        public void Criar_EditarProdTributacao(bool tipo, int codigoProduto)
        {
            double pPis, pCofins;
            int pis, cofins, icms, ncm, cest, origem, cfop, cst, csosn;

            if (mTxtPPis.Text.Trim() == "" || mTxtPPis.Text.Trim() == ",")
            {
                pPis = 0;
            }
            else
            {
                pPis = Convert.ToDouble(mTxtPPis.Text);
            }



            if (mTxtPCofins.Text.Trim() == "" || mTxtPCofins.Text.Trim() == ",")
            {
                pCofins = 0;
            }
            else
            {
                pCofins = Convert.ToDouble(mTxtPCofins.Text);
            }


            if (mTxtPis.Text.Trim() == "")
            {
                pis = -1;
            }
            else
            {
                pis = Convert.ToInt32(mTxtPis.Text);
            }



            if (mTxtCofins.Text.Trim() == "")
            {
                cofins = -1;
            }
            else
            {

                cofins = Convert.ToInt32(mTxtCofins.Text);
            }




            if (mTxtIcms.Text == "")
            {
                icms = -1;
            }
            else
            {
                icms = Convert.ToInt32(mTxtIcms.Text);
            }



            if (mTxtNcm.Text == "")
            {
                ncm = -1;
            }
            else
            {
                ncm = Convert.ToInt32(mTxtNcm.Text);
            }



            if (mTxtCest.Text == "")
            {
                cest = -1;
            }
            else
            {
                cest = Convert.ToInt32(mTxtCest.Text);
            }



            if (mTxtOrigem.Text == "")
            {
                origem = -1;
            }
            else
            {
                origem = Convert.ToInt32(mTxtOrigem.Text);
            }



            if (mTxtCfop.Text == "")
            {
                cfop = -1;
            }
            else
            {
                cfop = Convert.ToInt32(mTxtCfop.Text);
            }



            if (mTxtCst.Text == "")
            {
                cst = -1;
            }
            else
            {
                cst = Convert.ToInt32(mTxtCst.Text);
            }



            if (mTxtCsosn.Text == "")
            {
                csosn = -1;
            }
            else
            {
                csosn = Convert.ToInt32(mTxtCsosn.Text);
            }

            if (tipo)
            {
                var auxIdProd = produtos.retornarUltimoIdProduto();
                int idProd = Convert.ToInt32(auxIdProd[0]["idProduto"]);
                produtos.inserirAlterarDadosTributacao(pPis, pCofins, pis, cofins, csosn, cst, Convert.ToString(ncm), Convert.ToString(cest), origem, cfop, idProd);
            }
            else
            {
                produtos.inserirAlterarDadosTributacao(pPis, pCofins, pis, cofins, csosn, cst, Convert.ToString(ncm), Convert.ToString(cest), origem, cfop, codigoProduto);
            }
            /*
        private void carregarTela()
        {
            Console.WriteLine(this.codigoProd);
            var varProd = dadosProdutos.GetDataById(this.codigoProd);

            TxtBoxNome.Text = varProd[0]["prodNome"].ToString();
            TxtBoxCusto.Text = varProd[0]["prodCusto"].ToString();
            TxtBoxValor.Text = varProd[0]["prodValor"].ToString();
            TxtBoxCodBarras.Text = varProd[0]["prodCodBarras"].ToString();
            ckboxInativo.Checked = Convert.ToBoolean(varProd[0]["prodEstado"]);

        }*/
        }
    }
}
