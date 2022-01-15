using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria
{
    class Pessoa
    {
        private string nome; 
        private string cpf;
        private Endereco endereco;


        public Pessoa() { }

        public Pessoa(string nome, string cpf, Endereco enderecoNovo)
        {
            this.nome = nome;
            this.cpf = cpf;
            endereco = enderecoNovo;
        }

        // IMPRIME OS DADOS
        public void mostraDadosPessoa()
        {
            //DADOS DA PESSOA
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("********** DADOS PESSOAIS ********");
            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("CPF: " + cpf);

            //MOSTRA DADOS DO ENDEREÇO ASSOCIADO
            if (getEndereco() != null)
            {
                endereco.mostraDadosEndereco();
            }
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


        //SET E GET CPF
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCpf()
        {
            return cpf;
        }


        // SET E GET ENDEREÇO DENTRO DE PESSOA
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
