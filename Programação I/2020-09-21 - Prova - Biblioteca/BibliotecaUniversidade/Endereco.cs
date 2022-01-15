using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUniversidade
{
    class Endereco
    {
        private string cep;
        private string logradouro;
        private string bairro;
        private string cidade;
        private string estado;
        private int numero;
        private string complemento;


        public Endereco() { }


        public Endereco(string cep, string logradouro, string bairro, string cidade, string estado, int numero, string complemento)
        {
            this.cep = cep;
            this.logradouro = logradouro;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.numero = numero;
            this.complemento = complemento;
        }


        public void mostraDadosEndereco()
        {
            //DADOS DO ENDEREÇO
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO ENDEREÇO*****");
            Console.WriteLine("CEP: " + cep);
            Console.WriteLine("LOGRADOURO: " + logradouro);
            Console.WriteLine("BAIRRO: " + bairro);
            Console.WriteLine("CIDADE: " + cidade);
            Console.WriteLine("ESTADO: " + estado);
            Console.WriteLine("NUMERO: " + numero);
            Console.WriteLine("COMPLEMENTO: " + complemento);
        }

        public void mostraDadosEnderecoImprimir()
        {
            //DADOS DO ENDEREÇO PARA IMPRIMIR NO MENU
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO ENDEREÇO*****");
            Console.WriteLine("CEP: " + cep);
            Console.WriteLine("LOGRADOURO: " + logradouro);
            Console.WriteLine("BAIRRO: " + bairro);
            Console.WriteLine("CIDADE: " + cidade);
            Console.WriteLine("ESTADO: " + estado);
            Console.WriteLine("NUMERO: " + numero);
            Console.WriteLine("COMPLEMENTO: " + complemento);
        }



        //SET E GET CEP
        public void setCep(string cep)
        {
            this.cep = cep;
        }

        public string getCep()
        {
            return cep;
        }


        //SET E GET LOGRADOURO
        public void setLogradouro(string logradouro)
        {
            this.logradouro = logradouro;
        }

        public string getLogradouro()
        {
            return logradouro;
        }


        //SET E GET BAIRRO
        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string getBairro()
        {
            return bairro;
        }


        //SET E GET CIDADE
        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string getCidade()
        {
            return cidade;
        }


        //SET E GET ESTADO
        public void setEstado(string estado)
        {
            this.estado = estado;
        }

        public string getEstado()
        {
            return estado;
        }


        //SET E GET NUMERO
        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public int getNumero()
        {
            return numero;
        }


        //SET E GET COMPLEMENTO
        public void setComplemento(string complemento)
        {
            this.complemento = complemento;
        }

        public string getComplemento()
        {
            return complemento;
        }
    }
}
