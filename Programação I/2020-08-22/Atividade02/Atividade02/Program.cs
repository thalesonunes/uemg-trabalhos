using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Instruções da Atividade02
Considerando os slides 08 e 09, elabore :
1 - Classe Aluno com nome e CPF, crie os métodos de acesso
2-  Classe Professor com nome, CPF e área, crie os métodos de acesso
3 - Classe TCC com os atributos título, resumo, área e com um objeto da classe Aluno e um da classe Professor.
4 - Elabore uma classe principal para demonstrar o uso da Classe TCC. */

namespace Atividade02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // PROFESSORES -----------------------------------

            // CHAMANDO CLASSE CONSTRUTORA ENVIANDO PARÂMETROS
            Professor p1 = new Professor("Joao", "111.111.111-11", "Computacao Grafica");
            Professor p2 = new Professor("Otavio", "222.222.222-22", "Desenvolvimento Web");
            Professor p3 = new Professor("Marlon", "333.333.333-33", "Metodologia de Projeto");

            // CHAMANDO O MÉTODO QUE IMPRIME OS DADOS
            Console.WriteLine("_______________________________");
            p1.imprimeDados();
            p2.imprimeDados();
            p3.imprimeDados();
            


            // ALUNOS -----------------------------------

            // CHAMANDO CLASSE CONSTRUTORA ENVIANDO PARÂMETROS
            Aluno a1 = new Aluno("Thales Nunes", "444.444.444-44");
            Aluno a2 = new Aluno("Fabricio Teixeira", "555.555.555-55");
            Aluno a3 = new Aluno("Emerson Eller", "666.666.666-66");

            // CHAMANDO O MÉTODO QUE IMPRIME OS DADOS
            Console.WriteLine("_______________________________");
            a1.imprimeDados();
            a2.imprimeDados();
            a3.imprimeDados();

  

            // TCC -----------------------------------

            // CHAMANDO CLASSE CONSTRUTORA ENVIANDO PARÂMETROS
            TCC t1 = new TCC("Design e artesanato", "Uma experiência com a produção de cerâmica local", "Cerâmicas");
            TCC t2 = new TCC("Política e educação", "Projeto editorial e gráfico de um livro infantil", "Educação");
            TCC t3 = new TCC("Tênis para skate", "Projeto para o fim do ciclo de vida", "Calçado");

            // CHAMANDO O MÉTODO QUE IMPRIME OS DADOS
            Console.WriteLine("_______________________________");
            t1.imprimeDados();
            t2.imprimeDados();
            t3.imprimeDados();

            Console.ReadKey(); // SIMILAR AO SYSTEM PAUSE
        }
    }
}
