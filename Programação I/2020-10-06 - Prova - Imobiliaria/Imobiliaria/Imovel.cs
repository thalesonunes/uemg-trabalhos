using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria
{
    abstract class Imovel
    {
        private int quadra;
        private string lote;
        private double area;
        private string situacao;
        private double valor;
        private Endereco endereco;
        private Cliente cliente;

        public Imovel() { }

        public Imovel(int quadra, string lote, double area, string situacao, double valor, Endereco enderecoNovo, Cliente clienteNovo) 
        {
            this.quadra = quadra;
            this.lote = lote;
            this.area = area;
            this.situacao = situacao;
            this.valor = valor;
            endereco = enderecoNovo;
            cliente = clienteNovo;
        }

        //IMPRIME OS DADOS DO IMÓVEL
        public void mostraDadosImovel()
        {
            //DADOS DO IMOVEL
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("********* DADOS DO IMÓVEL ********");
            Console.WriteLine("QUADRA: " + quadra);
            Console.WriteLine("LOTE: " + lote);
            Console.WriteLine("AREA: " + area);
            Console.WriteLine("SITUAÇÃO: " + (situacao == "1" ? "Disponível" : "Indisponível"));
            Console.WriteLine("VALOR: " + valor);

            //MOSTRA DADOS DO ENDEREÇO ASSOCIADO
            if (getEndereco() != null)
            {
                getEndereco().mostraDadosEndereco();
                //endereco.mostraDadosEndereco();
            }
        }


        //CALCULANDO IPTU
        public abstract double CalcularIPTU();

        //SET E GET QUADRA
        public void setQuadra(int quadra)
        {
            this.quadra = quadra;
        }

        public int getQuadra()
        {
            return quadra;
        }


        //SET E GET LOTE
        public void setLote(string lote)
        {
            this.lote = lote;
        }

        public string getLote()
        {
            return lote;
        }


        //SET E GET AREA
        public void setArea(double area)
        {
            this.area = area;
        }

        public double getArea()
        {
            return area;
        }


        //SET E GET SITUACAO
        public void setSituacao(string situacao)
        {

            this.situacao = situacao;
            /*
            if (this.situacao == "1")
            {
                situacao = "DISPONIVEL";
            }
            else if (this.situacao == "2")
            {
                situacao = "INDISPONIVEL";
            }*/
        }

        public string getSituacao()
        {

            return situacao;
        }
          


        //SET E GET VALOR
        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public double getValor()
        {
            return valor;
        }

        // SET E GET ENDEREÇO DENTRO DE IMÓVEL
        public void setEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }

        public Endereco getEndereco()
        {
            return this.endereco;
        }


        //SET E GET CLIENTE
        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public Cliente getCliente()
        {
            return cliente;
        }






    }





}
