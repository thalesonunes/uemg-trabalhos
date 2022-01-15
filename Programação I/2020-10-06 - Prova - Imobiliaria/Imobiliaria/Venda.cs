using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria
{
    class Venda : Contrato
    {
        private double valorTotal;
        private string formaPgto;
        private int totalParcelas;
        private double comissao;
        private Imovel imovel;
        private Cliente cliente;
        private Funcionario funcionario;


        public void gerarContrato()
        {
            //DADOS DA VENDA
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("*********** CONSTRATO ************\n");
            Console.WriteLine("Pelo presente instrumento particular de compromisso de compra e venda,");
            Console.WriteLine("de um lado, " + funcionario.getNome() + ", nacionalidade brasileira,");
            Console.WriteLine("estado civil solteiro(a), CPF " + funcionario.getCpf() + ", residente");
            Console.WriteLine("a rua " + funcionario.getEndereco().getLogradouro() + ", numero " + funcionario.getEndereco().getNumero());
            Console.WriteLine("do bairro " + funcionario.getEndereco().getBairro() + ", na cidade de " + funcionario.getEndereco().getCidade() + " " + funcionario.getEndereco().getEstado());
            Console.WriteLine("de ora em diante chamado simplesmente de VENDEDOR.");

            Console.WriteLine("do outro lado, " + cliente.getNome() + ", nacionalidade brasileira,");
            Console.WriteLine("estado civil solteiro(a), CPF " + cliente.getCpf() + ", residente");
            Console.WriteLine("a rua " + cliente.getEndereco().getLogradouro() + ", numero " + cliente.getEndereco().getNumero());
            Console.WriteLine("do bairro " + cliente.getEndereco().getBairro() + ", na cidade de " + cliente.getEndereco().getCidade() + " " + cliente.getEndereco().getEstado());
            Console.WriteLine("de ora em diante chamado simplesmente de COMPRADOR.");

            Console.WriteLine("têm, entre si, como justo e contratado o que se segue: ");
            Console.WriteLine("\n+ As cláusulas foram ocultadas...");



            /*
             têm, entre si, como justo e contratado o que se segue:
              +valorTotal);
            

            Console.WriteLine("FORMA PAGAMENTO: " + formaPgto);
            Console.WriteLine("TOTAL DE PARCELAS: " + totalParcelas);
            Console.WriteLine("COMISSÃO: " + comissao);

            //imovel.mostraDadosImovel();
            //cliente.mostraDadosCliente();
            //funcionario.mostraDadosFuncionario();


            //MOSTRA DADOS DO IMOVEL ASSOCIADO
            if (getImovel() != null)
            {
                imovel.mostraDadosImovel();
            }

            //MOSTRA DADOS DO CLIENTE ASSOCIADO
            if (getCliente() != null)
            {
                cliente.mostraDadosCliente();
            }

            //MOSTRA DADOS DO FUNCIONÁRIO ASSOCIADO
            if (getCliente() != null)
            {
                funcionario.mostraDadosFuncionario();
            }

            */
        }

        public Venda() { }


        public Venda(double valorTotal, string formaPgto, int totalParcelas, double comissao, Imovel imovelNovo, Cliente clienteNovo, Funcionario funcionarioNovo)
        {
            this.valorTotal = valorTotal;
            this.formaPgto = formaPgto;
            this.totalParcelas = totalParcelas;
            this.comissao = comissao;
            imovel = imovelNovo;
            cliente = clienteNovo;
            funcionario = funcionarioNovo;
        }


        // IMPRIME OS DADOS
        public void mostraDadosVenda()
        {
            //DADOS DA VENDA
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("********* DADOS DA VENDA *********");
            Console.WriteLine("VALOR TOTAL: " + valorTotal);
            Console.WriteLine("FORMA PAGAMENTO: " + formaPgto);
            Console.WriteLine("TOTAL DE PARCELAS: " + totalParcelas);
            Console.WriteLine("COMISSÃO: " + calcularComissao());

            //imovel.mostraDadosImovel();
            //cliente.mostraDadosCliente();
            //funcionario.mostraDadosFuncionario();


            //MOSTRA DADOS DO IMOVEL ASSOCIADO
            if (getImovel() != null)
            {
                imovel.mostraDadosImovel();
            }

            //MOSTRA DADOS DO CLIENTE ASSOCIADO
            if (getCliente() != null)
            {
                cliente.mostraDadosCliente();
            }

            //MOSTRA DADOS DO FUNCIONÁRIO ASSOCIADO
            if (getCliente() != null)
            {
                funcionario.mostraDadosFuncionario();
            }

            gerarContrato();


        }

        //CADASTRA OS DADOS DA VENDA
        public void cadastroVenda(Venda vendaNova, List<Venda> listaDeVendas, Imovel imovelNovo, Cliente clienteNovo, Funcionario funcionarioNovo)
        {

            //USUÁRIO INSERINDO DADOS DA VENDA
            Console.Write("********************************\n");
            Console.Write("INSIRA OS DADOS DA VENDA\n");
            Console.Write("********************************\n");
            Console.WriteLine("VALOR TOTAL: ");
            vendaNova.setValorTotal(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("FORMA PAGAMENTO: ");
            vendaNova.setFormaPgto(Console.ReadLine());
            Console.WriteLine("TOTAL DE PARCELAS: ");
            vendaNova.setTotalParcelas(Convert.ToInt32(Console.ReadLine()));
            //Console.WriteLine("COMISSÃO: ");//USUARIO NÃO DIGITA A COMISSÃO, PEGA O PERCENTUAL DE COMISSÃO NA CLASSE FUNCIONÁRIO
            //vendaNova.setComissao(Convert.ToInt32(Console.ReadLine()));
          
            // funcionario.calcularComissao(valorTotal)

            /*
            if (comissao != null)
            {
                funcionario.setPercComissao(((valorTotal / 100) * comissao));
            }
            */
        }


        //SET E GET VALOR TOTAL

        public void setValorTotal(double valorTotal)
        {
            this.valorTotal = valorTotal;
        }

        public double getValorTotal()
        {
            return valorTotal;
        }


        //SET E GET FORMA DE PAGAMENTO
        public void setFormaPgto(string formaPgto)
        {
            this.formaPgto = formaPgto;
        }

        public string getFormaPgto()
        {
            return formaPgto;
        }

        //SET E GET TOTAL PARCELAS
        public void setTotalParcelas(int totalParcelas)
        {
            this.totalParcelas = totalParcelas;
        }

        public int getTotalParcelas()
        {
            return totalParcelas;
        }


        //SET E GET COMISSAO
        public void setComissao(double comissao)
        {
            this.comissao = comissao;
        }

        public double getComissao()
        {
            return comissao;
        }


        //SET E GET DE IMÓVEL DENTRO DE VENDA
        public void setImovel(Imovel imovel)
        {
            this.imovel = imovel;
        }

        public Imovel getImovel()
        {
            return imovel;
        }


        //SET E GET CLIENTE DENTRO DE VENDA
        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public Cliente getCliente()
        {
            return cliente;
        }

        //SET E GET FUNCIONARIO DENTRO DE VENDA
        public void setFuncionario(Funcionario funcionario)
        {
            this.funcionario = funcionario;
        }

        public Funcionario getFuncionario()
        {
            return funcionario;
        }


        public double calcularComissao()
        { 
            return getFuncionario().getPerc_Comissao() * getValorTotal();
        }

    }
}

