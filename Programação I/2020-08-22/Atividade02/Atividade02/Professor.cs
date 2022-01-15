using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02
{
    class Professor
    {
        string nome, cpf, area;

        public Professor(string nome, string cpf, string area)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.area = area;
        }

        public void imprimeDados()
        {
            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("ÁREA: " + area);
            Console.WriteLine("");
        }
    }
}
