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
        public double prodCusto { get; set; }
        public double prodValor { get; set; }
        public int prodQuantidade { get; set; }
        public string prodCodBarras { get; set; }

        public Produto()
         {

        }

        public Produto(int idProduto, string prodNome, double prodValor, double prodCusto, int prodQuantidade, string prodCodBarras)
        {
            this.idProduto = idProduto;
            this.prodNome = prodNome;
            this.prodCusto = prodCusto;
            this.prodValor = prodValor;
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
        public override string ToString()
        {
            return this.prodNome + "\n" + this.prodCusto + "\n" + this.prodValor + "\n" + this.prodCodBarras + "\n" + this.prodQuantidade;
        }

    }
}
