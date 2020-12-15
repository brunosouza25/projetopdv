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
        public void criarFiscal(bool tipo)
        {
            this.tipo = tipo;

            ckboxFiscal.Checked = false;
            permitirFiscal();
        }
        public void editarFiscal(bool tipo, int codigoProduto)
        {
            this.tipo = tipo;
            this.idProduto = codigoProduto;
            permitirFiscal();
            carregarTela();
        }
       

        public void permitirFiscal()
        {
            if (!ckboxFiscal.Checked) {
                mTxtCest.Enabled = false;
                mTxtCfop.Enabled = false;
                mTxtCofins.Enabled = false;
                mTxtCsosn.Enabled = false;
                mTxtCst.Enabled = false;
                mTxtIcms.Enabled = false;
                mTxtNcm.Enabled = false;
                mTxtOrigem.Enabled = false;
                mTxtPCofins.Enabled = false;
                mTxtPis.Enabled = false;
                mTxtPPis.Enabled = false;
            }
            else
            {
                mTxtCest.Enabled = true;
                mTxtCfop.Enabled = true;
                mTxtCofins.Enabled = true;
                mTxtCsosn.Enabled = true;
                mTxtCst.Enabled = true;
                mTxtIcms.Enabled = true;
                mTxtNcm.Enabled = true;
                mTxtOrigem.Enabled = true;
                mTxtPCofins.Enabled = true;
                mTxtPis.Enabled = true;
                mTxtPPis.Enabled = true;
            }
        }
        /*
        public void Criar_EditarProdTributacao(bool tipo, int codigoProduto)
        {
            this.tipo = tipo;
            double pPis, pCofins;
            int pis, cofins, icms, ncm, cest, origem, cfop, cst, csosn;
            carregarTela(codigoProduto);

            if (tipo)
            {
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


                int a;
                if (mTxtPis.Text.Trim() == "" && int.TryParse(mTxtPis.Text.Trim(), out a))
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
                var auxIdProd = produtos.retornarUltimoIdProduto();
                int idProd = Convert.ToInt32(auxIdProd[0]["idProduto"]);
                produtos.inserirAlterarDadosTributacao(pPis, pCofins, pis, cofins, csosn, cst, Convert.ToString(ncm), Convert.ToString(cest), origem, cfop, icms,idProd );
            }
            else
            {
              //  produtos.inserirAlterarDadosTributacao(pPis, pCofins, pis, cofins, csosn, cst, Convert.ToString(ncm), Convert.ToString(cest), origem, cfop, icms, codigoProduto);
            }*/
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

    }
    }*/

        public bool SalvarTributacao(bool tipo, int codigoProduto)
        {
            if (ckboxFiscal.Checked)
            {
                double pPis = -1, pCofins = -1;
                int pis = -1, cofins = -1, icms = -1, ncm = -1, cest = -1, origem = -1, cfop = -1, cst = -1, csosn = -1;
                int a;
                double b;
                bool salvar = false;
                if (mTxtPPis.Text.Trim() != "" && mTxtPCofins.Text.Trim() != "" && mTxtPis.Text.Trim() != "" && mTxtCofins.Text.Trim() != "" && mTxtIcms.Text != "" && mTxtNcm.Text != "" && mTxtCest.Text != ""
                    && mTxtOrigem.Text != "" && mTxtCfop.Text != "" && mTxtCfop.Text != "" && mTxtCst.Text != "" && mTxtCsosn.Text != "")
                {
                    if (double.TryParse(mTxtPPis.Text.Trim(), out b))
                    {
                        pPis = Convert.ToDouble(mTxtPPis.Text);
                        salvar = true;
                    }
                    else
                    {
                        MessageBox.Show("Porcentagem Pis inválido");
                        salvar = false;
                    }



                    if (double.TryParse(mTxtPCofins.Text.Trim(), out b))
                    {
                        pCofins = Convert.ToDouble(mTxtPCofins.Text);
                        salvar = true;
                    }
                    else
                    {
                        salvar = false;
                        MessageBox.Show("Porcentagem Cofins inválido");
                    }



                    if (int.TryParse(mTxtPis.Text.Trim(), out a))
                    {
                        pis = Convert.ToInt32(mTxtPis.Text);
                        salvar = true;
                    }
                    else
                    {
                        salvar = false;
                        MessageBox.Show("PIS inválido");
                    }



                    if (int.TryParse(mTxtCofins.Text.Trim(), out a))
                    {
                        cofins = Convert.ToInt32(mTxtCofins.Text);
                        salvar = true;
                    }
                    else
                    {

                        salvar = false;
                        MessageBox.Show("Cofins inválido");
                    }




                    if (int.TryParse(mTxtIcms.Text.Trim(), out a))
                    {
                        icms = Convert.ToInt32(mTxtIcms.Text);
                        salvar = true;
                    }
                    else
                    {
                        salvar = false;
                        MessageBox.Show("Icms inválido");
                    }



                    if (int.TryParse(mTxtNcm.Text.Trim(), out a))
                    {
                        ncm = Convert.ToInt32(mTxtNcm.Text);
                        salvar = true;
                    }
                    else
                    {
                        salvar = false;
                        MessageBox.Show("Ncm inválido");
                    }



                    if (int.TryParse(mTxtCest.Text.Trim(), out a))
                    {
                        cest = Convert.ToInt32(mTxtCest.Text);
                        salvar = true;
                    }
                    else
                    {
                        salvar = false;
                        MessageBox.Show("Cest inválido");
                    }



                    if (int.TryParse(mTxtOrigem.Text.Trim(), out a))
                    {
                        origem = Convert.ToInt32(mTxtOrigem.Text);
                        salvar = true;
                    }
                    else
                    {
                        salvar = false;
                        MessageBox.Show("Origem inválido");
                    }



                    if (int.TryParse(mTxtCfop.Text.Trim(), out a))
                    {
                        cfop = Convert.ToInt32(mTxtCfop.Text);
                        salvar = true;
                    }
                    else
                    {
                        salvar = false;
                        MessageBox.Show("Cfop inválido");
                    }



                    if (int.TryParse(mTxtCst.Text.Trim(), out a))
                    {
                        cst = Convert.ToInt32(mTxtCst.Text);
                        salvar = true;
                    }
                    else
                    {
                        salvar = false;
                        MessageBox.Show("Cst inválido");
                    }

                    if (int.TryParse(mTxtCsosn.Text.Trim(), out a))
                    {
                        csosn = Convert.ToInt32(mTxtCsosn.Text);
                        salvar = true;
                    }
                    else
                    {
                        salvar = false;
                        MessageBox.Show("Csosn inválido");
                    }
                    if (salvar)
                    {
                        if (tipo)
                        {
                            var auxIdProd = produtos.retornarUltimoIdProduto();
                            int idProd = Convert.ToInt32(auxIdProd[0]["idProduto"]);
                            produtos.inserirAlterarDadosTributacao(pPis, pCofins, pis, cofins, csosn, cst, Convert.ToString(ncm), Convert.ToString(cest), origem, cfop, icms, true, idProd );
                     
                            return true;
                        }
                        else
                        {
                            produtos.attDadosTributacao(pPis, pCofins, pis, cofins, cfop, csosn, cst, Convert.ToString(ncm), Convert.ToString(cest), origem, icms, ckboxFiscal.Checked, codigoProduto);
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }

                else
                {
                    MessageBox.Show("Favor, preencher todos os campos para emissao da nota");
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        public void carregarTela()
        {
            var auxProd = produtos.retornarProdutoPorId(idProduto);
            carregarFiscal();
            if (Convert.ToBoolean(auxProd[0]["fiscal"])) {
                carregarFiscal();
                carregarPPis();
                carregarPis(false);
                carregarCofins(false);
                carregarIcms(false);
                carregarNcm_Cest(false);
                carregarOrigem(false);
                carregarCfop(false);
                carregarCst(false);
                carregarCsosn(false);
            }
            else
            {
                ckboxFiscal.Checked = false;
            }
        }


        public void carregarPPis()
        {
            var auxProd = produtos.retornarProdutoPorId(idProduto);
            mTxtPis.Text = auxProd[0]["pPis"].ToString();
            mTxtCofins.Text = auxProd[0]["pCofins"].ToString();
        }
        public void carregarFiscal()
        {

            var auxProd = produtos.retornarProdutoPorId(idProduto);
            ckboxFiscal.Checked = Convert.ToBoolean(auxProd[0]["fiscal"]);
        }
        public void carregarPis(bool edit_proc)
        {
            int idPis;


                var auxProd = produtos.retornarProdutoPorId(idProduto);
                idPis = Convert.ToInt32(auxProd[0]["idPis"]);


            mTxtPis.Text = idPis.ToString();

            var auxPis = pis_cofins.retornarPis_CofinsPorId(idPis);
            if(auxPis.Count < 1)
            {
                lblPis.Text = "Nenhum Pis selecionado";
            }
            else
            {
                lblPis.Text = auxPis[0]["descricao"].ToString();
            }
            
        }

        public void carregarCofins(bool edit_proc)
        {
            int idCofins;

            var auxProd = produtos.retornarProdutoPorId(idProduto);
            idCofins = Convert.ToInt32(auxProd[0]["idCofins"]);

            mTxtCofins.Text = idCofins.ToString();
            var auxCofins = pis_cofins.retornarPis_CofinsPorId(idCofins);
            if (auxCofins.Count < 1)
            {
                lblCofins.Text = "Nenhum Cofins selecionado";
            }
            else
            {
                lblCofins.Text = auxCofins[0]["descricao"].ToString();

            }

        }
        public void carregarIcms(bool edit_proc)
        {
            int idIcms;

            var auxProd = produtos.retornarProdutoPorId(idProduto);
            idIcms = Convert.ToInt32(auxProd[0]["idIcms"]);
            mTxtIcms.Text = idIcms.ToString();
            var auxIcms = icms.retornarIcmsPorId(idIcms);
            if (auxIcms.Count < 1)
            {
                lblIcms.Text = "Nenhum Icms selecionado";
            }
            else
            {
                lblIcms.Text = auxIcms[0]["descricao"].ToString();
            }

        }

        public void carregarNcm_Cest(bool edit_proc)
        {
            int idNcm, idCest;

            var auxProd = produtos.retornarProdutoPorId(idProduto);
            idNcm = Convert.ToInt32(auxProd[0]["ncm"]);
            idCest = Convert.ToInt32(auxProd[0]["cest"]);
            mTxtNcm.Text = idNcm.ToString();
            mTxtCest.Text = idCest.ToString();
            var auxNcm = ncm.retornarNcmECestPorId(idNcm.ToString(), idCest.ToString());
            if (auxNcm.Count < 1)
            {
                lblNcm.Text = "Nenhum NCM ou Cest selecionados";
            }
            else
            {
                lblNcm.Text = auxNcm[0]["descricao"].ToString();
            }

        }

        public void carregarOrigem(bool edit_proc)
        {
            int idOrigem;
            var auxProd = produtos.retornarProdutoPorId(idProduto);
            idOrigem = Convert.ToInt32(auxProd[0]["IdOrigem"]);
            mTxtOrigem.Text = idOrigem.ToString();

            var auxOrigem = origem.retornarOrigemPorId(idOrigem);
            if (auxOrigem.Count < 1)
            {
                lblOrigem.Text = "Nenhum Origem selecionado";
            }
            else
            {
                lblOrigem.Text = auxOrigem[0]["descricao"].ToString();
            }

        }

        public void carregarCfop(bool edit_proc)
        {
            int idCfop;
            var auxProd = produtos.retornarProdutoPorId(idProduto);
            idCfop = Convert.ToInt32(auxProd[0]["idCfop"]);
            mTxtCfop.Text = idCfop.ToString();

            var auxCfop = cfop.retornarCfopPorId(idCfop);
            if (auxCfop.Count < 1)
            {
                lblCfop.Text = "Nenhum Cfop selecionado";
            }
            else
            {
                lblCfop.Text = auxCfop[0]["desc_cfop"].ToString();
            }

        }
        public void carregarCst(bool edit_proc)
        {
            var auxProd = produtos.retornarProdutoPorId(idProduto);
            int idCst = Convert.ToInt32(auxProd[0]["idCst"]);

            mTxtCst.Text = idCst.ToString();
            var auxCst = cst.retornarCstPorId(idCst);
            if (auxCst.Count < 1)
            {
                lblCst.Text = "Nenhum Cst selecionado";
            }
            else
            {
                lblCst.Text = auxCst[0]["descricao"].ToString();
            }

        }
        public void carregarCsosn(bool edit_proc)
        {
            int idCsosn;
            var auxProd = produtos.retornarProdutoPorId(idProduto);
            idCsosn = Convert.ToInt32(auxProd[0]["idCsosn"]);
            mTxtCsosn.Text = idCsosn.ToString();

            var auxCsosn = csosn.retornarCsosnPorId(idCsosn);
            if (auxCsosn.Count < 1)
            {
                lblCsosn.Text = "Nenhum Csosn selecionado";
            }
            else
            {
                lblCsosn.Text = auxCsosn[0]["descricao"].ToString();
            }

        }

        private void ckboxFiscal_CheckedChanged(object sender, EventArgs e)
        {
            permitirFiscal();
        }
    }
}
