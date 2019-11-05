using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Produto
    {
        public int idProduto { get; set; }
        public string prodNome { get; set; }
        public double prodValor { get; set; }
        public double prodCusto { get; set; }
        public int prodQuantidade { get; set; }
        public string prodCodBarras { get; set; }

        public Produto(int idProduto, string prodNome, double prodValor, double prodCusto, int prodQuantidade, string prodCodBarras)
        {
            this.idProduto = idProduto;
            this.prodNome = prodNome;
            this.prodValor = prodValor;
            this.prodCusto = prodCusto;
            this.prodQuantidade = prodQuantidade;
            this.prodCodBarras = prodCodBarras;
        }

        public void criarProd()
        {
                                
        }
        public void adicionarProd()
        {
           
        }
        public void retirarProd()
        {

        }

    }
}
