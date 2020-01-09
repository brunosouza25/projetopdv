using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2.Vendas.View
{
    public partial class TelaDetalhesDaVenda : Form
    {
        DadosTableAdapters.DataRelatorioTableAdapter detalheVenda = new DadosTableAdapters.DataRelatorioTableAdapter();

        int codVenda;
        int idDin = -1, idCredVista = -1, idDeb = -1, idCredParc = -1;

        public TelaDetalhesDaVenda(int codVenda)
        {
            InitializeComponent();
            this.codVenda = codVenda;
            carregarTela();

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
            List<string> tipos = new List<string>();
            for(int i = 0; i < pagamentosVenda.Count; i++)
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

            if(idDin >=0)
            {
                txtBoxDin.Text = Convert.ToDouble(pagamentosVenda[idDin]["PagValor"]).ToString("F2");

            }
            if(idCredVista >= 0)
                txtBoxCredParc.Text = Convert.ToDouble(pagamentosVenda[idCredParc]["PagValor"]).ToString("F2"); 
            if(idCredParc >= 0)
                txtBoxCredVista.Text = Convert.ToDouble(pagamentosVenda[idCredVista]["PagValor"]).ToString("F2");
            if(idDeb >= 0)
                txtBoxDebt.Text = Convert.ToDouble(pagamentosVenda[idDeb]["PagValor"]).ToString("F2");

            lblNumVenda.Text = auxVenda[0]["idVenda"].ToString();

            lblTotal.Text = Convert.ToDouble(auxVenda[0]["valorCompra"]).ToString("F2");

            lblData.Text = Convert.ToDateTime(auxVenda[0]["vendData"]).ToString("dd/MM/yyyy HH:mm");

            for(int i = 0; i < auxProdutosVenda.Count; i++)
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
                item.SubItems.Add(auxProdutosVenda[i]["prodNome"].ToString());
                item.SubItems.Add(auxProdutosVenda[i]["prodCodBarras"].ToString());
                item.SubItems.Add(auxProdutosVenda[i]["prodValor"].ToString());
                item.SubItems.Add("");
                item.SubItems.Add(auxProdutosVenda[i]["itensQtd"].ToString());

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
