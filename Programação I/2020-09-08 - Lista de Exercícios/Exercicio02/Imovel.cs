using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Imovel
    {
        private string endereco { get; set; }
        private double preco { get; set; }

        public Imovel ()
        { }

        public void ImprimePreco()
        {
            Console.WriteLine("O valor do imóvel é " + this.preco + ".");
        }

    }
}
