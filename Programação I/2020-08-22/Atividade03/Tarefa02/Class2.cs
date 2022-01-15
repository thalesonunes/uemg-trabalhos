using System;
using System.Collections.Generic;
using System.Text;

namespace Tarefa02
{
    class Professor
    {
     string nome, cpf;
     string area;

     public Professor(string nome, string cpf, string area)
            {
            this.nome = nome;
            this.cpf = cpf;
            this.area = area;
            }

    public void mostraDados()
             {
              Console.WriteLine(nome);
              Console.WriteLine(cpf);
              Console.WriteLine(area);
              }

}
}
