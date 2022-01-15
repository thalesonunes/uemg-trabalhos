using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUniversidade
{
    class Curso
    {

        private string nome;
        private string area;
        private double valorMensalidade;


        public Curso() { }

        public Curso(string nome, string area, double valorMensalidade)
        {
            this.nome = nome;
            this.area = area;
            this.valorMensalidade = valorMensalidade;
        }

        public void mostraDadosCurso()
        {
            //DADOS DO CURSO
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO CURSO*****");
            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("ÁREA: " + area);
            Console.WriteLine("VALOR DA MENSALIDADE: " + valorMensalidade);
        }

        public void mostraDadosCursoImprimir()
        {
            //DADOS DO CURSO PARA IMPRIMIR NO MENU
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO CURSO*****");
            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("ÁREA: " + area);
            Console.WriteLine("VALOR DA MENSALIDADE: " + valorMensalidade);
        }

        //SET E GET NOME
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }


        //SET E GET AREA
        public void setArea(string area)
        {
            this.area = area;
        }

        public string getArea()
        {
            return area;
        }


        //SET E GET VALOR DA MENSALIDADE
        public void setValorMensalidade(double valorMensalidade)
        {
            this.valorMensalidade = valorMensalidade;
        }

        public double getValorMensalidade()
        {
            return valorMensalidade;
        }


    }
}
