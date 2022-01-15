using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUniversidade
{
    class Pessoa
    {
        protected string cpf;
        protected string nome;
        protected string rg;
        protected DateTime dataNascimento;
        protected string telefone;
        protected string email;
        protected bool liberado;
        protected Endereco endereco;


        public Pessoa() { }


        public Pessoa(string cpf, string nome, string rg, DateTime dataNascimento, string telefone, string email, bool liberado, Endereco endereco)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.rg = rg;
            this.dataNascimento = dataNascimento;
            this.telefone = telefone;
            this.email = email;
            this.liberado = liberado;
            this.endereco = endereco;
        }


        public void mostraDadosPessoa()
        {
            //DADOS DA PESSOA
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS PESSOAIS*****");
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("RG: " + rg);
            Console.WriteLine("DATA DE NASCIMENTO: " + dataNascimento);
            Console.WriteLine("TELEFONE: " + telefone);
            Console.WriteLine("EMAIL: " + email);
            Console.WriteLine("LIBERADO: " + (convertBoolToString(liberado)));

            //ASSOCIAÇÃO ENDEREÇO
            endereco.mostraDadosEndereco();
        }

        public void mostraDadosPessoaImprimir()
        {
            //DADOS DA PESSOA PARA IMPRIMIR NO MENU
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS PESSOAIS*****");
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("RG: " + rg);
            Console.WriteLine("DATA DE NASCIMENTO: " + dataNascimento);
            Console.WriteLine("TELEFONE: " + telefone);
            Console.WriteLine("EMAIL: " + email);
            Console.WriteLine("LIBERADO: " + (convertBoolToString(liberado)));
        }



        public string convertBoolToString(bool dados)
        {
            string boolConvertido;

            if (dados)
            {
                boolConvertido = "Sim";
            }
            else
            {
                boolConvertido = "Nao";
            }

            return boolConvertido;
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


        //SET E GET NOME
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }


        //SET E GET RG
        public void setRg(string rg)
        {
            this.rg = rg;
        }

        public string getRg()
        {
            return rg;
        }


        //SET E GET DATA DE NASCIMENTO
        public void setDataNascimento(DateTime dataNascimento)
        {
            this.dataNascimento = dataNascimento;
        }

        public DateTime getDataNascimento()
        {
            return dataNascimento;
        }


        //SET E GET TELEFONE
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string getTelefone()
        {
            return telefone;
        }


        //SET E GET EMAIL
        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEmail()
        {
            return email;
        }


        //SET E GET LIBERADO
        public void setLiberado(string liberado)
        {
            bool stringConvertido = false;

            if (liberado == "Sim" || liberado == "SIM" || liberado == "sim")
            {
                stringConvertido = true;
            }
            else
            {
                stringConvertido = false;
            }

            this.liberado = stringConvertido;
        }

        public bool getLiberado()
        {
            return liberado;
        }


        // SET E GET ENDERECO DENTRO DE PESSOA

        public void setEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }

        public Endereco getEndereco()
        {
            return endereco;
        }
    }
}
