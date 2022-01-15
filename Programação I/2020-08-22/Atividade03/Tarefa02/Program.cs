using System;

namespace Tarefa02
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p1 = new Professor("Vania", "123.456.789.10", "ProgramaçãoI");
            Professor p2 = new Professor("Mailson", "987.654.321.10", "AEDIII");
            Professor p3 = new Professor("Rafael", "741.8852.963.12", "Calculo");
         
            p1.mostraDados();
            p2.mostraDados();
            p3.mostraDados();
            Console.WriteLine("");


            Aluno a1 = new Aluno("Nayara", "777.888.999.44");
            Aluno a2 = new Aluno("Marcus", "444.555.666.11");
            Aluno a3 = new Aluno("Aurora", "333.222.111.55");

            a1.mostraDados();
            a2.mostraDados();
            a3.mostraDados();
            Console.WriteLine("");



            TCC t1 = new TCC("Segurança Digital", "Trata da segurança de dados na realidade atual", "Dados");
            TCC t2 = new TCC("Realidade Aumentada", "Trata da integração de elementos ou informações virtuais, visualizações do mundo real através de uma câmera e com o uso de sensores de movimento", "IHM");
            

            t1.mostraDados();
            t2.mostraDados();
            Console.ReadKey();

        }
    }
}
