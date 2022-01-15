using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            ItemProduto P1 = new ItemProduto();

            
            Console.Write("Produto: ");
            P1.setProduto(Console.ReadLine());
            Console.Clear();

            Console.Write("Marca: ");
            P1.setMarca(Console.ReadLine());
            Console.Clear();

            Console.Write("Tipo: ");
            P1.setTipo(Console.ReadLine());
            Console.Clear();

            Console.Write("Preco de CUSTO: ");
            P1.setPrecoCusto(Convert.ToSingle (Console.ReadLine()));
            Console.Clear();

            Console.Write("Preco de VENDA: ");
            P1.setPrecoVenda(Convert.ToSingle (Console.ReadLine()));
            Console.Clear();
          


            Console.Clear();
            
            P1.mostraDados();

            Console.ReadKey();

        }
    }
}
