using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Brinquedo Br1 = new Brinquedo();
            Br1.mover();

            Carro c1 = new Carro();
            c1.mover();

            Barco b1 = new Barco();
            b1.mover();

            Aviao a1 = new Aviao();
            a1.mover();

            Console.WriteLine("------------------------------------------------------");

            double vel;
            double ace;

            Brinquedo Br2 = new Brinquedo();
            Console.WriteLine("Digite a velocidade do BRINQUEDO: ");
            vel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a aceleracao do BRINQUEDO: ");
            ace = Convert.ToDouble(Console.ReadLine());
            Br2.mover(vel, ace);

            Console.WriteLine("------------------------------------------------------");

            Carro c2 = new Carro();
            Console.WriteLine("Digite a velocidade e aceleração: ");
            c2.mover((Convert.ToDouble(Console.ReadLine())), (Convert.ToDouble(Console.ReadLine())));

            Console.WriteLine("------------------------------------------------------");

            int turbina;
            Aviao a2 = new Aviao();
            
            Console.WriteLine("Digite a quantidade de turbina do avião");
            turbina = Convert.ToInt32(Console.ReadLine());
            a2.setQtTurbina(turbina);
            Console.WriteLine("O avião tem " + (Convert.ToInt32(a2.getQtTurbina())) + " turbinas.");
            
            Console.ReadKey();
 
        }
    }
}
