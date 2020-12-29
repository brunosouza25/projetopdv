using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    class Fiscal
    {
        DadosTableAdapters.Config_SistemaTableAdapter sistema = new DadosTableAdapters.Config_SistemaTableAdapter();
        public void escreverIniNfce()
        {
            var auxFiscal = sistema.retornarConfig();
            string cnpjEmpresa = auxFiscal[0]["cnpjEmpresa"].ToString();
            string txtBoxIE = auxFiscal[0]["inscricaoEstadual"].ToString();
            string txtBoxSenhaSat = auxFiscal[0]["senhaSat"].ToString();
            string txtCnpjSH = auxFiscal[0]["cnpjSoftwareHouse"].ToString();
            string rTxtBoxCodSat = auxFiscal[0]["assinaturaAC"].ToString();
            string txtBoxRazaoSocial = auxFiscal[0]["razaoSocial"].ToString();
            string txtBoxNomeFantasia = auxFiscal[0]["nomeFantasia"].ToString();
            string txtBoxTelefone = auxFiscal[0]["telefone"].ToString();
            string txtBoxCep = auxFiscal[0]["cep"].ToString();
            string txtBoxLogradouro = auxFiscal[0]["logradouro"].ToString();
            string txtBoxNumero = auxFiscal[0]["numero"].ToString(); ;
            string txtBoxBairro = auxFiscal[0]["bairro"].ToString();
            string txtBoxCidade = auxFiscal[0]["cidade"].ToString();
            string txtBoxCodCidade = auxFiscal[0]["codigoCidade"].ToString();
            string txtBoxUf = auxFiscal[0]["uf"].ToString();

            StreamWriter x;
            string caminho = "C:\\Users\\bruno\\Desktop\\notas\\enviar\\nota.ini";

            x = File.CreateText(caminho);
            x.WriteLine("[infNFe]");
            x.WriteLine("versao = 4.00");

            x.WriteLine("[Identificacao]");
            x.WriteLine("natOp = 5.101 Venda de producao do estabelecimento");
            x.WriteLine("nNF=000001402");
            x.WriteLine("dhEmi = 26/07/2018 08:36:02");
            x.WriteLine("");

            x.WriteLine("[Emitente]");
            x.WriteLine("CNPJ=49952677000119");
            x.WriteLine("IE=142552396537");
            x.WriteLine("Razao=PROJETO ACBR");
            x.WriteLine("Fantasia=PROJETO ACBR");
            x.WriteLine("Fone=(11)5096-1201");
            x.WriteLine("CEP=04615000");
            x.WriteLine("Logradouro=Rua Cel Aureliano Camargo");
            x.WriteLine("Numero=973");
            x.WriteLine("Bairro = Centro");
            x.WriteLine("CidadeCod=3554003");
            x.WriteLine("Cidade=Tatui");
            x.WriteLine("UF=SP");
            x.WriteLine("");

            x.WriteLine("[Produto001]");
            x.WriteLine("CFOP=5102");
            x.WriteLine("Codigo=77902N");
            x.WriteLine("Descricao=KIT INDIVIDUAL");
            x.WriteLine("NCM=84719012");
            x.WriteLine("Unidade=UND");
            x.WriteLine("Quantidade=1");
            x.WriteLine("ValorUnitario=100");
            x.WriteLine("ValorTotal=100");
            x.WriteLine("ValorDesconto=0,00");
            x.WriteLine("");

            x.WriteLine("[ICMS001]");
            x.WriteLine("orig=0");
            x.WriteLine("");


            x.WriteLine("[PIS001]");
            x.WriteLine("ValorBase=0,00");
            x.WriteLine("Aliquota=0,00");
            x.WriteLine("Valor=0,00");
            x.WriteLine("");

            x.WriteLine("[COFINS001]");
            x.WriteLine("ValorBase=0,00");
            x.WriteLine("Aliquota=0,00");
            x.WriteLine("Valor=0,00");
            x.WriteLine("");

            x.WriteLine("[Total]");
            x.WriteLine("BaseICMS=100");
            x.WriteLine("ValorICMS=10");
            x.WriteLine("ValorProduto=100");
            x.WriteLine("ValorNota=100");


            x.WriteLine("[PAG001]");
            x.WriteLine("tPag=01");
            x.WriteLine("vPag=100");
            x.WriteLine("");
            x.Close();
            //quebra linha:\r\n 
            enviarNfe();
        }
            public void escreverIniNfe()
        {
            StreamWriter x;
            string caminho = "C:\\Users\\bruno\\Desktop\\notas\\enviar\\nota.ini";

            x = File.CreateText(caminho);
            x.WriteLine("[infNFe]");
            x.WriteLine("versao = 4.00");

            x.WriteLine("[Identificacao]");
            x.WriteLine("cNF = 4050");
            x.WriteLine("natOp = 5.101 Venda de producao do estabelecimento");
            x.WriteLine("mod = 55");
            x.WriteLine("serie = 1");
            x.WriteLine("nNF = 4050");
            x.WriteLine("dhEmi = 26/07/2018 08:36:02");
            x.WriteLine("dhSaiEnt =");
            x.WriteLine("tpNF = 1");
            x.WriteLine("idDest = 1");
            x.WriteLine("tpImp = 1");
            x.WriteLine("tpEmis = 1");
            x.WriteLine("finNFe = 1");
            x.WriteLine("indFinal = 0");
            x.WriteLine("indPres = 1");
            x.WriteLine("procEmi = 0");
            x.WriteLine("verProc = 3.1.0");
            x.WriteLine("dhCont =");
            x.WriteLine("xJust =");
            x.WriteLine("");

            x.WriteLine("[Emitente]");
            x.WriteLine("CNPJCPF = 03850874000126");
            x.WriteLine("xNome = JAIRO - SIMPLES - COM CERTFICADO");
            x.WriteLine("xFant = JAIRO - NOME FANTASIA");
            x.WriteLine("IE = 0860299430");
            x.WriteLine("IEST =");
            x.WriteLine("IM =");
            x.WriteLine("CNAE = 4789099");
            x.WriteLine("CRT = 1");
            x.WriteLine("xLgr = RUA PINHEIRO MACHADO");
            x.WriteLine("nro = 545");
            x.WriteLine("xCpl =");
            x.WriteLine("xBairro = INDUSTRIAL");
            x.WriteLine("cMun = 4313409");
            x.WriteLine("xMun = NOVO HAMBURGO");
            x.WriteLine("UF = RS");
            x.WriteLine("CEP = 93320490");
            x.WriteLine("cPais = 1058");
            x.WriteLine("xPais = BRASIL");
            x.WriteLine("Fone = 5135821451");
            x.WriteLine("cUF = 43");
            x.WriteLine("cMunFG =");
            x.WriteLine("");

            x.WriteLine("[Destinatario]");
            x.WriteLine("CNPJCPF = 89184238000128");
            x.WriteLine("xNome = 1 A_DIMAQX COMERCIO DE PECAS E MAQUINAS AGRICOLAS");
            x.WriteLine("xLgr = RUA PRESIDENTE LUCENA");
            x.WriteLine("nro = 4");
            x.WriteLine("xBairro = DAS ROSAS");
            x.WriteLine("xMun = ESTANCIA VELHA");
            x.WriteLine("UF = RS");
            x.WriteLine("");

            x.WriteLine("[Produto001]");
            x.WriteLine("cProd = 1");
            x.WriteLine("cEAN = SEM GTIN");
            x.WriteLine("xProd = ALMOCO LIVRE - EMPRESA1 -");
            x.WriteLine("ncm = 82013000");
            x.WriteLine("CEST = 1708400");
            x.WriteLine("CFOP = 5101");
            x.WriteLine("uCom = RL");
            x.WriteLine("qCom = 10.0000");
            x.WriteLine("vUnCom = 10.00000000");
            x.WriteLine("vProd = 100.00");
            x.WriteLine("cEANTrib = SEM GTIN");
            x.WriteLine("uTrib = RL");
            x.WriteLine("qTrib = 10.0000");
            x.WriteLine("vUnTrib = 10.00000000");
            x.WriteLine("vFrete = 0.00");
            x.WriteLine("vSeg = 0.00");
            x.WriteLine("vDesc = 0.00");
            x.WriteLine("vOutro = 0.00");
            x.WriteLine("indTot = 1");
            x.WriteLine("vTotTrib = 26.60");
            x.WriteLine("");

            x.WriteLine("[ICMS001]");
            x.WriteLine("orig = 0");
            x.WriteLine("CST =");
            x.WriteLine("CSOSN = 400");
            x.WriteLine("modBC = 3");
            x.WriteLine("pRedBC = 0.00");
            x.WriteLine("vBC = 0.00");
            x.WriteLine("pICMS = 0.00");
            x.WriteLine("vICMS = 0.00");
            x.WriteLine("modBCST = 5");
            x.WriteLine("pMVAST = 0.00");
            x.WriteLine("pRedBCST = 0.00");
            x.WriteLine("vBCST = 0.00");
            x.WriteLine("pICMSST = 0.00");
            x.WriteLine("vICMSST = 0.00");
            x.WriteLine("vBCSTRet = 0");
            x.WriteLine("vICMSSTRet = 0");
            x.WriteLine("pCredSN = 0.00");
            x.WriteLine("vCredICMSSN = 0.00");
            x.WriteLine("vICMSOp = 0.00");
            x.WriteLine("pDif = 0.000");
            x.WriteLine("vICMSDif = 0.00");
            x.WriteLine("");

            x.WriteLine("[IPI001]");
            x.WriteLine("CST = 53");
            x.WriteLine("cEnq = 999");
            x.WriteLine("pIPI = 0");
            x.WriteLine("vIPI = 0");
            x.WriteLine("");

            x.WriteLine("[PIS001]");
            x.WriteLine("CST = 99");
            x.WriteLine("vBC = 0");
            x.WriteLine("pPIS = 0");
            x.WriteLine("qBCProd = 0");
            x.WriteLine("vAliqProd = 0");
            x.WriteLine("vPIS = 0");
            x.WriteLine("");

            x.WriteLine("[COFINS001]");
            x.WriteLine("CST = 99");
            x.WriteLine("vBC = 0");
            x.WriteLine("pCOFINS = 0");
            x.WriteLine("qBCProd = 0");
            x.WriteLine("vAliqProd = 0");
            x.WriteLine("vCOFINS = 0");
            x.WriteLine("");

            x.WriteLine("[Total]");
            x.WriteLine("vBC = 0");
            x.WriteLine("vICMS = 0");
            x.WriteLine("vICMSDeson = 0");
            x.WriteLine("vBCST = 0");
            x.WriteLine("vST = 0");
            x.WriteLine("vProd = 100");
            x.WriteLine("vFrete = 0");
            x.WriteLine("vSeg = 0");
            x.WriteLine("vDesc = 0");
            x.WriteLine("vII = 0");
            x.WriteLine("vIPI = 0");
            x.WriteLine("vPIS = 0");
            x.WriteLine("vCOFINS = 0");
            x.WriteLine("vOutro = 0");
            x.WriteLine("vNF = 100");
            x.WriteLine("vTotTrib = 26.6");
            x.WriteLine("vFCP = 0");
            x.WriteLine("vFCPST = 0");
            x.WriteLine("vFCPSTRet = 0");
            x.WriteLine("vIPIDevol = 0");
            x.WriteLine("");

            x.WriteLine("[Fatura]");
            x.WriteLine("nFat = NF 4050");
            x.WriteLine("vOrig = 100.00");
            x.WriteLine("vDesc = 0.00");
            x.WriteLine("vLiq = 100.00");
            x.WriteLine("[Duplicata001]");
            x.WriteLine("nDup = 001");
            x.WriteLine("dVenc = 25/08/2018");
            x.WriteLine("vDup = 33.33");
            x.WriteLine("[Duplicata002]");
            x.WriteLine("nDup = 002");
            x.WriteLine("dVenc = 28/08/2018");
            x.WriteLine("vDup = 33.33");
            x.WriteLine("[Duplicata003]");
            x.WriteLine("nDup = 003");
            x.WriteLine("dVenc = 31/08/2018");
            x.WriteLine("vDup = 33.34");
            x.WriteLine("");

            x.WriteLine("[PAG001]");
            x.WriteLine("tpag = 15");
            x.WriteLine("vPag = 100");
            x.WriteLine("indPag = 1");
            x.WriteLine("vTroco = 0");
            x.WriteLine("");
            x.Close();
            //quebra linha:\r\n 
            enviarNfe();
        }
        public void enviarNfe()
        {
            StreamWriter x;
            string caminho = @"C:\Users\bruno\Desktop\notas\entrada\\enviar.txt";

            x = File.CreateText(caminho);
            x.WriteLine("NFe.CriarNFe(\"C:\\Users\\bruno\\desktop\\notas\\enviar\\nota.ini\\,1)");
            //x.WriteLine("NFE.ImprimirDanfe(\"C:\\Users\bruno\\Desktop\\sat c#\\xml.xml\", \"\"Doro PDF Writer\",\"1\")");
            x.Close();



        }
    }
}
