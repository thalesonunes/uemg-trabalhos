using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUniversidade
{
    class Funcionario : Pessoa
    {
        private int codigo;
        private string cargo;
        private DateTime dataAdmissao;
        private double salario;

        public Funcionario() { }

        public Funcionario(int codigo, string cargo, DateTime dataAdmissao, double salario)
        {
            this.codigo = codigo;
            this.cargo = cargo;
            this.dataAdmissao = dataAdmissao;
            this.salario = salario;
        }

        public void mostraDadosFuncionario()
        {
            //DADOS DO FUNCIOCIONÁRIO
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO FUNCIONÁRIO*****");
            Console.WriteLine("CÓDIGO: " + codigo);
            Console.WriteLine("CARGO: " + cargo);
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

        public void mostraDadosFuncionarioImprimir()
        {
            //DADOS DO FUNCIOCIONÁRIO PARA IMPRIMIR NO MENU
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO FUNCIONÁRIO*****");
            Console.WriteLine("CÓDIGO: " + codigo);
            Console.WriteLine("CARGO: " + cargo);
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

        //SET E GET CARGO
        public void setCargo(string cargo)
        {
            this.cargo = cargo;
        }

        public string getCargo()
        {
            return cargo;
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
