using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUniversidade
{
    class Professor : Pessoa
    {
        private int codigo;
        private string graduacao;
        private DateTime dataAdmissao;
        private double salario;

        public Professor() { }

        public Professor(int codigo, string graduacao, DateTime dataAdmissao, double salario)
        {
            this.codigo = codigo;
            this.graduacao = graduacao;
            this.dataAdmissao = dataAdmissao;
            this.salario = salario;
        }

        public void mostraDadosProfessor()
        {
            //DADOS DO PROFESSOR
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO PROFESSOR*****");
            Console.WriteLine("CÓDIGO: " + codigo);
            Console.WriteLine("GRADUAÇÃO: " + graduacao);
            Console.WriteLine("DATA DE ADMISSÃO: " + dataAdmissao);
            Console.WriteLine("SALÁRIO: " + salario);

            //HERANÇA PESSOA
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS PESSOAIS*****");
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("RG: " + rg);
            Console.WriteLine("DATA DE NASCIMENTO: " + dataNascimento);
            Console.WriteLine("TELEFONE: " + telefone);
            Console.WriteLine("EMAIL: " + email);
            Console.WriteLine("LIBERADO: " + (convertBoolToString(liberado)));
            endereco.mostraDadosEndereco();
        }

        public void mostraDadosProfessorImprimir()
        {
            //DADOS DO PROFESSOR PARA IMPRIMIR NO MENU
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO PROFESSOR*****");
            Console.WriteLine("CÓDIGO: " + codigo);
            Console.WriteLine("GRADUAÇÃO: " + graduacao);
            Console.WriteLine("DATA DE ADMISSÃO: " + dataAdmissao);
            Console.WriteLine("SALÁRIO: " + salario);
        }

            //SET E GET CÓDIGO
            public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public int getCodigo()
        {
            return codigo;
        }

        //SET E GET GRADUAÇÃO
        public void setGraduacao(string graduacao)
        {
            this.graduacao = graduacao;
        }

        public string getGraduacao()
        {
            return graduacao;
        }

        //SET E GET DATA DE ADMISSÃO
        public void setDataAdmissao(DateTime dataAdmissao)
        {
            this.dataAdmissao = dataAdmissao;
        }

        public DateTime getDataAdmissao()
        {
            return dataAdmissao;
        }


        //SET E GET SALÁRIO
        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }

    }
}
