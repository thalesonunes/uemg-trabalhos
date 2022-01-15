using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria
{
    class Terreno : Imovel
    {

        private Endereco endereco;
        private Cliente cliente;


        public Terreno() { }

        public Terreno(int quadra, string lote, double area, string situacao, double valor, Endereco enderecoNovo, Cliente clienteNovo) : base(quadra, lote, area, situacao, valor, enderecoNovo, clienteNovo)
        {
            endereco = enderecoNovo;
            cliente = clienteNovo;
        }


        //IMPRIME OS DADOS DO TERRENO
        public void mostraDadosTerreno()
        {
            //DADOS DO TERRENO
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("****** DADOS DO TERRENO ******");
            Console.WriteLine("QUADRA: " + getQuadra());
            Console.WriteLine("LOTE: " + getLote());
            Console.WriteLine("AREA: " + getArea());
            Console.WriteLine("SITUAÇÃO: " + (getSituacao() == "1" ? "Disponível" : "Indisponível"));
            Console.WriteLine("VALOR: " + getValor());
            Console.WriteLine("IPTU: " + CalcularIPTU());

            //MOSTRA DADOS DO ENDEREÇO ASSOCIADO
            if (getEndereco() != null)
            {
                getEndereco().mostraDadosEndereco();
                //endereco.mostraDadosEndereco();
            }

        }


        //CADASTRA OS DADOS DO TERRENO
        public void cadastroTerreno(Terreno terrenoNovo, List<Terreno> listaDeTerrenos, Endereco enderecoNovo, Cliente clienteNovo)
        {
                        
            //USUÁRIO INSERINDO DADOS DO TERRENO
            Console.Write("**************************\n");
            Console.Write("INSIRA OS DADOS DO TERRENO\n");
            Console.Write("**************************\n");
            Console.WriteLine("QUADRA: ");
            terrenoNovo.setQuadra(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("LOTE: ");
            terrenoNovo.setLote(Console.ReadLine());
            Console.WriteLine("AREA: ");
            terrenoNovo.setArea(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("SITUAÇÃO  [1] DISPONÍVEL    [2] INDISPONÍVEL: ");
            terrenoNovo.setSituacao(Console.ReadLine());
            Console.WriteLine("VALOR: ");
            terrenoNovo.setValor(Convert.ToDouble(Console.ReadLine()));

            Console.ReadKey();
        }


        // SET E GET ENDEREÇO DENTRO DE TERRENO
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

        public Cliente GetCliente()
        {
            return this.cliente;
        }

        public override double CalcularIPTU()
        {
            return (getValor() * 0.02);
        }

    }
}
