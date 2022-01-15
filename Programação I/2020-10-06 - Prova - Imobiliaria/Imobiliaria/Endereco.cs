using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria
{
    class Endereco
    {
        
        private string logradouro;
        private int numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
        private string complemento;

        public Endereco() { }

        public Endereco(string logradouro, int numero, string bairro, string cidade, string estado, string cep, string complemento)
        {
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.cep = cep;
            this.complemento = complemento;
        }


        public void mostraDadosEndereco()
        {
            //DADOS DO ENDEREÇO
            Console.WriteLine("----------------------------------");
            Console.WriteLine("******** DADOS DO ENDEREÇO *******");
            Console.WriteLine("NUMERO: " + numero);
            Console.WriteLine("LOGRADOURO: " + logradouro);
            Console.WriteLine("BAIRRO: " + bairro);
            Console.WriteLine("CIDADE: " + cidade);
            Console.WriteLine("ESTADO: " + estado);
            Console.WriteLine("CEP: " + cep);
            Console.WriteLine("COMPLEMENTO: " + complemento);
        }

     
        public void cadastroEndereco(Endereco enderecoNovo, List<Endereco> listaDeEnderecos)
        {
            //DADOS DO ENDEREÇO
            Console.Write("***************************\n");
            Console.Write("INSIRA OS DADOS DO ENDEREÇO\n");
            Console.Write("***************************\n");
            Console.WriteLine("NUMERO: ");
            enderecoNovo.setNumero(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("LOGRADOURO: ");
            enderecoNovo.setLogradouro(Console.ReadLine());
            Console.WriteLine("BAIRRO: ");
            enderecoNovo.setBairro(Console.ReadLine());
            Console.WriteLine("CIDADE: ");
            enderecoNovo.setCidade(Console.ReadLine());
            Console.WriteLine("ESTADO: ");
            enderecoNovo.setEstado(Console.ReadLine());
            Console.WriteLine("CEP: ");
            enderecoNovo.setCep(Console.ReadLine());
            Console.WriteLine("COMPLEMENTO: ");
            enderecoNovo.setComplemento(Console.ReadLine());


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


        //SET E GET NUMERO
        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public int getNumero()
        {
            return numero;
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


        //SET E GET CEP
        public void setCep(string cep)
        {
            this.cep = cep;
        }

        public string getCep()
        {
            return cep;
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
