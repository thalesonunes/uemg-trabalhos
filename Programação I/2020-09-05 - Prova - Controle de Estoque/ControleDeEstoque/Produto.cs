using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    class Produto
    {
        private string produto, marca, tipo;

        public Produto(){}

        public Produto(string produto, string marca, string tipo)
        {
            this.produto = produto;
            this.marca = marca;
            this.tipo = tipo;
        }

        // PRODUTO (get e set)
        public string getProduto() 
        { 
            return produto; 
        }
        public void setProduto(string produto) 
        {
            this.produto = produto; 
        }

        // MARCA (get e set)
        public string getMarca() 
        { 
            return marca; 
        }
        public void setMarca(string marca) 
        { 
            this.marca = marca; 
        }

        // TIPO (get e set)
        public string getTipo() 
        { 
            return tipo; 
        }
        public void setTipo(string tipo) 
        { 
            this.tipo = tipo; 
        }


        public void mostraDadosProduto()
        {
            Console.WriteLine("Produto: " + produto);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Tipo: " + tipo);
        }

    }
}
