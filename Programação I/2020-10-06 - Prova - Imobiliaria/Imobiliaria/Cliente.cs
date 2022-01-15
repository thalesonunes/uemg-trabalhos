using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria
{
    class Cliente : Pessoa
    {
        private bool liberado;
        private Endereco endereco;

        public Cliente() { }

        public Cliente(string nome, string cpf, Endereco enderecoNovo, bool liberado) : base(nome, cpf, enderecoNovo)
        {
            this.liberado = liberado;
            endereco = enderecoNovo;
        }


        //IMPRIME OS DADOS CLIENTE
        public void mostraDadosCliente()
        {
            //DADOS DA PESSOA(HERANÇA)
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("********* DADOS DO CLIENTE *******");
            Console.WriteLine("NOME: " + getNome());
            Console.WriteLine("CPF: " + getCpf());
            //DADOS CLIENTES
            Console.WriteLine("LIBERADO: " + (liberado ? "Sim" : "Não")); // USO DE TERNÁRIO (Se liberado for verdadeiro, retorna SIM, senao retorna NÃO

            //MOSTRA DADOS DO ENDEREÇO ASSOCIADO
            if (getEndereco() != null)
            {
                endereco.mostraDadosEndereco();
            }

        }


        //CADASTRA OS DADOS CLIENTE
        public void cadastroCliente(Cliente clienteNovo, List<Cliente> listaDeClientes, Endereco enderecoNovo)
        {

            //USUÁRIO INSERINDO DADOS DO CLIENTE
            Console.WriteLine("**************************");
            Console.WriteLine("INSIRA OS DADOS DO CLIENTE");
            Console.WriteLine("**************************");
            Console.WriteLine("NOME: ");
            clienteNovo.setNome(Console.ReadLine());
            Console.WriteLine("CPF: ");
            clienteNovo.setCpf(Console.ReadLine());

            // LIBERADO (CASO ESPECIAL)
            Console.WriteLine("LIBERADO [Sim] ou [Não]: ");
            string liberadoAux = (Console.ReadLine());
            if (liberadoAux == "sim" || liberadoAux == "Sim" || liberadoAux == "SIM")
            {
                clienteNovo.setLiberado(true);
            }
            else
            {
                clienteNovo.setLiberado(false);
            }

        }


        //SET E GET LIBERADO
        public void setLiberado(bool liberado)
        {
            this.liberado = liberado;
        }

        public bool getLiberado()
        {
            return liberado;
        }


        // SET E GET ENDEREÇO DENTRO DE CLIENTE
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
