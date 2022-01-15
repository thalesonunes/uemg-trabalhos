using System;
using System.Collections.Generic;
using System.Text;

namespace Tarefa02
{
    class Aluno
    {
     string nome, cpf;

    public Aluno(string nome, string cpf)
            {
            this.nome=nome;
            this.cpf=cpf;
            }

    public void mostraDados()
        {
        Console.WriteLine(nome);
        Console.WriteLine(cpf);
        }



}
}
