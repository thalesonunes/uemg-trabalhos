using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Aviao : Brinquedo
    {
        private int qtTurbina;

        public Aviao() { }

        public override void mover()
        {
            Console.WriteLine("O AVIAO voa.");
        }

        public void setQtTurbina(int qtTurbina)
        {
            this.qtTurbina = qtTurbina;
        }

        public int getQtTurbina()
        {
            return qtTurbina;
        }
    }
}
