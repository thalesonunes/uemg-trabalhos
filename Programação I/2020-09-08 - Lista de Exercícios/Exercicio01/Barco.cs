using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Barco : Brinquedo
    {
        private string tipo;
        public Barco() { }

        public override void mover()
        {
            Console.WriteLine("O BARCO navega.");
        }
    }
}
