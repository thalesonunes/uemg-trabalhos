using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    class ItemProduto : Produto
    {
        private float precoCusto, precoVenda, margemLucro;
        private bool vendido = false;

        public ItemProduto() { }

        public ItemProduto(string produto, string marca, string tipo, float precoCusto, float precoVenda) : base(produto, marca, tipo)
        {
            this.precoCusto = precoCusto;
            this.precoVenda = precoVenda;
        }

        // precoCusto (get e set)
        public float getPrecoCusto() { return precoCusto; }
        public void setPrecoCusto(float precoCusto) { this.precoCusto = precoCusto; }

        // precoVenda (get e set)
        public float getPrecoVenda() { return precoVenda; }
        public void setPrecoVenda(float precoVenda) 
        { 
            if (precoVenda < this.precoCusto)
            {
                Console.Clear();
                Console.Write("PRECO DE VENDA abaixo do PRECO DE CUSTO! Digite um novo valor: ");
                setPrecoVenda(Convert.ToSingle(Console.ReadLine()));   
            }
            else
            {
                this.precoVenda = precoVenda;
            }
        }

        // margemLucro (get e set)
        public float getMargemLucro() { return margemLucro; }
        public void setMargemLucro(float margemLucro) { this.margemLucro = margemLucro; }

        // vendido (get e set)
        public bool getVendido() { return vendido; }
        public void setVendido(bool vendido) { this.vendido = vendido; }

        float calcularMargemLucro()
        {
            return (Convert.ToSingle(this.precoVenda - this.precoCusto));
        }

        float calcularMargemLucroPorcentagem()
        {
            return (Convert.ToInt32 (((this.precoVenda - this.precoCusto)*100)/this.precoCusto));

        }

        string alteraBoolParaString(bool dado)
        {
            string sim = "Sim";
            string nao = "Nao";
            if (dado) { return sim; } else { return nao; }
        }

        public void mostraDados()
        {
            mostraDadosProduto();
            Console.WriteLine("Preco de Custo: R$ " + precoCusto);
            Console.WriteLine("Preco de Venda: R$ " + precoVenda);
            Console.WriteLine("Margem de Lucro (Moeda): R$ " + calcularMargemLucro());
            Console.WriteLine("Margem de Lucro (Porcentagem): " + calcularMargemLucroPorcentagem() + "%");
            Console.WriteLine("Vendido: " + alteraBoolParaString(vendido));
        }


    }
}
