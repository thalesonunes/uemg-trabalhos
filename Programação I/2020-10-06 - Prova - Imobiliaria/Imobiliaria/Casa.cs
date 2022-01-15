using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria
{
    class Casa : Imovel
    {
        private double areaconstruida;
        private Endereco endereco;
        private Cliente cliente;

    
        public Casa() {}

        public Casa(int quadra, string lote, double area, string situacao, double valor, Endereco enderecoNovo, Cliente clienteNovo, double areaconstruida) : base(quadra, lote, area, situacao, valor, enderecoNovo, clienteNovo)
        {
            this.areaconstruida = areaconstruida;
            endereco = enderecoNovo;
            cliente = clienteNovo;
        }

        //IMPRIME OS DADOS DA CASA
        public void mostraDadosCasa()
        {
            //DADOS DA CASA
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("********** DADOS DA CASA *********");
            Console.WriteLine("QUADRA: " + getQuadra());
            Console.WriteLine("LOTE: " + getLote());
            Console.WriteLine("AREA: " + getArea());
            Console.WriteLine("SITUAÇÃO: " + (getSituacao() == "1" ? "Disponível" : "Indisponível")); 
            Console.WriteLine("VALOR: " + getValor());
            Console.WriteLine("AREA CONSTRUÍDA: " + areaconstruida);
            Console.WriteLine("IPTU: " + CalcularIPTU());


            //MOSTRA DADOS DO ENDEREÇO ASSOCIADO
            if (getEndereco() != null)
            {
                //getEndereco().mostraDadosEndereco();
                endereco.mostraDadosEndereco();
            }

            //MOSTRA DADOS DO CLIENTE ASSOCIADO
            if (getCliente() != null)
            {
                cliente.mostraDadosCliente();
            }

        }


        //CADASTRA OS DADOS DA CASA
        public void cadastroCasa(Casa casaNova, List<Casa> listaDeCasas, Endereco enderecoNovo, Cliente clienteNovo)
        {
            //USUÁRIO INSERINDO DADOS DA CASA
            Console.Write("***********************\n");
            Console.Write("INSIRA OS DADOS DA CASA\n");
            Console.Write("***********************\n");
            Console.WriteLine("QUADRA: ");
            casaNova.setQuadra(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("LOTE: ");
            casaNova.setLote(Console.ReadLine());
            Console.WriteLine("AREA: ");
            casaNova.setArea(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("SITUAÇÃO  [1] DISPONÍVEL    [2] INDISPONÍVEL: ");
            casaNova.setSituacao(Console.ReadLine());
            Console.WriteLine("VALOR: ");
            casaNova.setValor(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("AREA CONSTRUÍDA: ");
            casaNova.setAreaConstruida(Convert.ToDouble(Console.ReadLine()));

        }

     
        //SET E GET ÁREA CONSTRUÍDA
        public void setAreaConstruida(double areaconstruida)
        {
            this.areaconstruida = areaconstruida;
        }

        public double getAreaConstruida()
        {
            return areaconstruida;
        }



        // SET E GET ENDEREÇO DENTRO DE CASA
        public void setEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }

        public Endereco getEndereco()
        {
            return this.endereco;
        }


        // SET E GET CLIENTE DENTRO DE CASA
        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public Cliente getCliente()
        {
            return this.cliente;
        }

        
        //CALCULANDO IPTU - HERANÇA
        public override double CalcularIPTU()
        {
            return (getValor() * 0.05);
        }
        
 
    }
}
