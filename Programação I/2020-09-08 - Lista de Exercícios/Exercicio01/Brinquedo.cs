using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Brinquedo
    {
        private double velocidade;
        private double aceleracao;

        public Brinquedo() { }

        public Brinquedo(double velocidade, double aceleracao)
        {
            this.velocidade = velocidade;
            this.aceleracao = aceleracao;
        }

        public virtual void mover()
        {
            Console.WriteLine("O brinquedo move.");
        }
        

        public virtual void mover(double velocidade, double aceleracao)
        {
            Console.WriteLine("O brinquedo move a uma velocidade de " + velocidade + " com aceleração de " + aceleracao + " por minuto." );
        }

        public double getVelocidade()
        {
            return velocidade * aceleracao;
        }
    }
}
