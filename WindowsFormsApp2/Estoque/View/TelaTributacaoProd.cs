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
        DadosTableAdapters.Pis_CofinsTableAdapter pis_cofins = new DadosTableAdapters.Pis_CofinsTableAdapter();
        DadosTableAdapters.IcmsTableAdapter icms = new DadosTableAdapters.IcmsTableAdapter();
        DadosTableAdapters.NcmTableAdapter ncm = new DadosTableAdapters.NcmTableAdapter(); //cest está junto do ncm
        DadosTableAdapters.OrigemTableAdapter origem = new DadosTableAdapters.OrigemTableAdapter();
        DadosTableAdapters.CfopTableAdapter cfop = new DadosTableAdapters.CfopTableAdapter();
        DadosTableAdapters.CstTableAdapter cst = new DadosTableAdapters.CstTableAdapter();
        DadosTableAdapters.CsosnTableAdapter csosn = new DadosTableAdapters.CsosnTableAdapter();
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
        public void carregarTela(int codigoProduto)
        {
            this.idProduto = codigoProduto;
            var auxProd = produtos.retornarProdutoPorId(codigoProduto);
            mTxtOrigem.Text(auxProd[0]["idOrigem"].ToString());
            mTxtOrigem.

        }

        public void carregarPis()
        {
            var auxProd = produtos.retornarProdutoPorId(idProduto);
            int idPis = Convert.ToInt32(auxProd[0]["idPis"]);
            var auxPis = pis_cofins.retornarPis_CofinsPorId(idPis);
            if(auxPis.Count < 1)
            {
                lblPis.Text = "Nenhum Pis selecionado";
            }
            else
            {
                lblPis.Text = auxPis[0]["idPis"].ToString().Substring(0, 20);
            }
            
        }

        public void carregarCofins()
        {
            var auxProd = produtos.retornarProdutoPorId(idProduto);
            int idPis = Convert.ToInt32(auxProd[0]["id"]);
            var auxPis = pis_cofins.retornarPis_CofinsPorId(idPis);
            if (auxPis.Count < 1)
            {
                lblCofins.Text = "Nenhum Cofins selecionado";
            }
            else
            {
                lblCofins.Text = auxPis[0]["id"].ToString().Substring(0, 20);

            }

        }
        public void carregarIcms()
        {
            var auxProd = produtos.retornarProdutoPorId(idProduto);
            int idIcms = Convert.ToInt32(auxProd[0]["id"]);
            var auxIcms = icms.retornarIcmsPorId(idIcms);    
            if (auxIcms.Count < 1)
            {
                lblPis.Text = "Nenhum Icms selecionado";
            }
            else
            {
                lblIcms.Text = auxIcms[0]["id"].ToString().Substring(0, 20);
            }

        }

        public void carregarNcm_Cest()
        {
            var auxProd = produtos.retornarProdutoPorId(idProduto);
            string idNcm = auxProd[0]["ncm"].ToString();
            string idCest = auxProd[0]["cest"].ToString();
            var auxNcm = ncm.retornarNcmECestPorId(idNcm, idCest);
            if (auxNcm.Count < 1)
            {
                lblNcm.Text = "Nenhum NCM ou Cest selecionados";
            }
            else
            {
                lblNcm.Text = auxNcm[0]["idNcm"].ToString().Substring(0, 20);
            }

        }

        public void carregarIcms()
        {
            var auxProd = produtos.retornarProdutoPorId(idProduto);
            int idIcms = Convert.ToInt32(auxProd[0]["idIcms"]);
            var auxIcms = icms.retornarIcmsPorId(idIcms);
            if (auxIcms.Count < 1)
            {
                lblPis.Text = "Nenhum Icms selecionado";
            }
            else
            {
                lblPis.Text = auxIcms[0]["idIcms"].ToString().Substring(0, 20);
            }

        }

        public void carregarIcms()
        {
            var auxProd = produtos.retornarProdutoPorId(idProduto);
            int idIcms = Convert.ToInt32(auxProd[0]["idIcms"]);
            var auxIcms = icms.retornarIcmsPorId(idIcms);
            if (auxIcms.Count < 1)
            {
                lblPis.Text = "Nenhum Icms selecionado";
            }
            else
            {
                lblPis.Text = auxIcms[0]["idIcms"].ToString().Substring(0, 20);
            }

        }
        public void carregarIcms()
        {
            var auxProd = produtos.retornarProdutoPorId(idProduto);
            int idIcms = Convert.ToInt32(auxProd[0]["idIcms"]);
            var auxIcms = icms.retornarIcmsPorId(idIcms);
            if (auxIcms.Count < 1)
            {
                lblPis.Text = "Nenhum Icms selecionado";
            }
            else
            {
                lblPis.Text = auxIcms[0]["idIcms"].ToString().Substring(0, 20);
            }

        }
        public void carregarIcms()
        {
            var auxProd = produtos.retornarProdutoPorId(idProduto);
            int idIcms = Convert.ToInt32(auxProd[0]["idIcms"]);
            var auxIcms = icms.retornarIcmsPorId(idIcms);
            if (auxIcms.Count < 1)
            {
                lblPis.Text = "Nenhum Icms selecionado";
            }
            else
            {
                lblPis.Text = auxIcms[0]["idIcms"].ToString().Substring(0, 20);
            }

        }
    }
}
