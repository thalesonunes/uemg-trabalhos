using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria
{
    class Apartamento : Imovel
    {

        private string condominio;
        private int andar;
        private Endereco endereco;
        private Cliente cliente;

     

        public Apartamento() { }

        public Apartamento(int quadra, string lote, double area, string situacao, double valor, Endereco enderecoNovo, Cliente clienteNovo, string condominio, int andar) : base(quadra, lote, area, situacao, valor, enderecoNovo, clienteNovo) //VERIFICAR VARIAVEL INTEGER
        {
            this.condominio = condominio;
            this.andar = andar;
            endereco = enderecoNovo;
            cliente = clienteNovo;
        }


        //IMPRIME OS DADOS DO APARTAMENTO
        public void mostraDadosApartamento()
        {
            //DADOS DO APARTAMENTO
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("****** DADOS DO APARTAMENTO ******");
            Console.WriteLine("QUADRA: " + getQuadra());
            Console.WriteLine("LOTE: " + getLote());
            Console.WriteLine("AREA: " + getArea());
            Console.WriteLine("SITUAÇÃO: " + (getSituacao() == "1" ? "Disponível" : "Indisponível"));
            Console.WriteLine("VALOR: " + getValor());
            Console.WriteLine("CONDOMÍNIO: " + condominio);
            Console.WriteLine("ANDAR: " + andar);
            Console.WriteLine("IPTU: " + CalcularIPTU());

            //MOSTRA DADOS DO ENDEREÇO ASSOCIADO
            if (getEndereco() != null)
            {
                getEndereco().mostraDadosEndereco();
                //endereco.mostraDadosEndereco();
            }

        }


        //CADASTRA OS DADOS DO APARTAMENTO
        public void cadastroApartamento(Apartamento apartamentoNovo, List<Apartamento> listaDeApartamentos, Endereco enderecoNovo, Cliente clienteNovo)
        {
            //USUÁRIO INSERINDO DADOS DO APARTAMENTO
            Console.Write("******************************\n");
            Console.Write("INSIRA OS DADOS DO APARTAMENTO\n");
            Console.Write("******************************\n");
            Console.WriteLine("QUADRA: ");
            apartamentoNovo.setQuadra(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("LOTE: ");
            apartamentoNovo.setLote(Console.ReadLine());
            Console.WriteLine("AREA: ");
            apartamentoNovo.setArea(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("SITUAÇÃO  [1] DISPONÍVEL    [2] INDISPONÍVEL: ");
            apartamentoNovo.setSituacao(Console.ReadLine());
            Console.WriteLine("VALOR: ");
            apartamentoNovo.setValor(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("CONDOMÍNIO: ");
            apartamentoNovo.setCondominio(Console.ReadLine());
            Console.WriteLine("ANDAR: ");
            apartamentoNovo.setAndar(Convert.ToInt32(Console.ReadLine()));

            
        }


        //SET E GET CONDOMÍNIO
        public void setCondominio(string condominio)
        {
            this.condominio = condominio;
        }

        public string getCondominio()
        {
            return condominio;
        }


        //SET E GET ANDAR
        public void setAndar(int andar)//VERIFICAR VARIAVEL INTEGER
        {
            this.andar = andar;
        }

        public int getAndar()//VERIFICAR VARIAVEL INTEGER
        {
            return andar;
        }


        // SET E GET ENDEREÇO DENTRO DE APARTAMENTO
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

        //CALCULANDO IPTU - HERANÇA
        public override double CalcularIPTU()
        {
            return (getValor() * 0.03);
        }

    }
}
