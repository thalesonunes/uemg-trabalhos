using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02
{
    class Aluno
    {
        string nome, cpf;

        public Aluno(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public void imprimeDados()
        {
            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("");
        }
    }
}
