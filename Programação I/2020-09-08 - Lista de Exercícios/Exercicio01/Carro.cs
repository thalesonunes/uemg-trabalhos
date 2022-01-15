using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Carro : Brinquedo
    {
        private int aro;

        public Carro() { }

        public override void mover()
        {
            Console.WriteLine("O CARRO movimenta.");
        }

        public override void mover(double velocidade, double aceleracao)
        {
            Console.WriteLine("O CARRO move a uma velocidade de " + velocidade + " com aceleração de " + aceleracao + " por minuto.");
        }

    }
}