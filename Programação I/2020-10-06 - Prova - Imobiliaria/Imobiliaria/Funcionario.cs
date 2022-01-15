using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria
{
    class Funcionario : Pessoa, Comissao
    {
        private double salario;
        private double perc_Comissao;
        private Endereco endereco;

        public double calcularComissao(double valor) // onde ele for setado (em VENDA) será necessário passar o valor da venda como parametro //tem que fazer uma busca?
        {
            return getPerc_Comissao() * valor;
        }

        public Funcionario() 
        {
            
        }

        public Funcionario(string nome, string cpf, Endereco enderecoNovo, double salario, double perc_Comissao) : base (nome, cpf, enderecoNovo)
        {
            this.salario = salario;
            this.perc_Comissao = perc_Comissao;
            endereco = enderecoNovo;
        }


        // IMPRIME OS DADOS FUNCIONÁRIO
        public void mostraDadosFuncionario()
        {
 
            //DADOS DA PESSOA(HERANÇA)
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("********* DADOS DO FUNCIONÁRIO *******");
            Console.WriteLine("NOME: " + getNome());
            Console.WriteLine("CPF: " + getCpf());
            //FUNCIONARIO
            Console.WriteLine("SALÁRIO: " + salario);
            Console.WriteLine("PERCENTUAL COMISSÃO: " + perc_Comissao);

            //MOSTRA DADOS DO ENDEREÇO ASSOCIADO
            if (getEndereco() != null)
            {
                endereco.mostraDadosEndereco();
            }

        }

        // IMPRIME SALÁRIO FUNCIONÁRIO SEM COMISSÃO
        public void mostraSalarioSemCom()
        {

            //DADOS DA PESSOA(HERANÇA)
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("********* DADOS DO FUNCIONÁRIO *******");
            Console.WriteLine("NOME: " + getNome());
             //FUNCIONARIO
            Console.WriteLine("SALÁRIO: " + salario);
      
        }



        //CADASTRA OS DADOS FUNCIONÁRIO
        public void cadastroFuncionario(Funcionario funcionarioNovo, List<Funcionario> listaDeFuncionarios, Endereco enderecoNovo)
        {

            //USUÁRIO INSERINDO DADOS DO FUNCIONARIO
            Console.Write("******************************\n");
            Console.Write("INSIRA OS DADOS DO FUNCIONARIO\n");
            Console.Write("******************************\n");
            Console.WriteLine("NOME: ");
            funcionarioNovo.setNome(Console.ReadLine());
            Console.WriteLine("CPF: ");
            funcionarioNovo.setCpf(Console.ReadLine());
            Console.WriteLine("SALARIO: ");
            funcionarioNovo.setSalario(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("PERCENTUAL DE COMISSAO: ");
            funcionarioNovo.setPerc_Comissao(Convert.ToDouble(Console.ReadLine()));
        }

       

        // GET E SET SALARIO
        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }


        // GET E SET PERCENTUAL COMISSAO

        public void setPerc_Comissao(double perc_Comissao)
        {
            this.perc_Comissao = perc_Comissao;// + percComissao;
        }

        public double getPerc_Comissao()
        {

            return perc_Comissao;
           /* if(perc_Comissao() <= 0)//Thales pode testar
            {
                perc_Comissao = 5;
                return perc_Comissao;
            }
            else
            {
                return perc_Comissao;*/
                   
        }


        // SET E GET ENDEREÇO DENTRO DE FUNCIONÁRIO
        public void setEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }

        public Endereco getEndereco()
        {
            return this.endereco;
        }

    }
}
