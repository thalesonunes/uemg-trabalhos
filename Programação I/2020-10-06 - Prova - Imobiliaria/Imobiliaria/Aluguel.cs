using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria
{
    class Aluguel : Contrato
    {
        private double mensal;
        private int qtdMeses;
        private Imovel imovel;
        private Funcionario funcionario;
        private Cliente cliente;


        public Aluguel() { }

        public Aluguel(double mensal, int qtdMeses, Imovel imovelNovo, Funcionario funcionarioNovo, Cliente clienteNovo)
        {
            this.mensal = mensal;
            this.qtdMeses = qtdMeses;
            imovel = imovelNovo;
            funcionario = funcionarioNovo;
            cliente = clienteNovo;
        }


        // IMPRIME OS DADOS
        public void mostraDadosAluguel()
        {
            //DADOS DA VENDA
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("********* DADOS DO ALUGUEL *******");
            Console.WriteLine("MENSALIDADE: " + mensal);
            Console.WriteLine("QTD MESES: " + qtdMeses);


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
        }


        //CADASTRA OS DADOS DO ALUGUEL
        public void cadastroAluguel(Aluguel aluguelNovo, List<Aluguel> listaDeAluguel, Imovel imovelNovo, Cliente clienteNovo, Funcionario funcionarioNovo)
        {
            //USUÁRIO INSERINDO DADOS DA VENDA
            Console.Write("**************************\n");
            Console.Write("INSIRA OS DADOS DO ALUGUEL\n");
            Console.Write("**************************\n");
            Console.WriteLine("VALOR MENSAL: ");
            aluguelNovo.setMensal(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("QUANTIDADE DE MESES: ");
            aluguelNovo.setQtdMeses(Convert.ToInt32(Console.ReadLine()));
        }


        public void gerarContrato()
        {
            //CONTRATO
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("*********** CONSTRATO ************\n");
            Console.WriteLine("Pelo presente instrumento particular de compromisso de locação,");
            Console.WriteLine("de um lado, " + funcionario.getNome() + ", nacionalidade brasileira,");
            Console.WriteLine("estado civil solteiro(a), CPF " + funcionario.getCpf() + ", residente");
            Console.WriteLine("a rua " + funcionario.getEndereco().getLogradouro() + ", numero " + funcionario.getEndereco().getNumero());
            Console.WriteLine("do bairro " + funcionario.getEndereco().getBairro() + ", na cidade de " + funcionario.getEndereco().getCidade() + " " + funcionario.getEndereco().getEstado());
            Console.WriteLine("de ora em diante chamado simplesmente de LOCADOR.");

            Console.WriteLine("do outro lado, " + cliente.getNome() + ", nacionalidade brasileira,");
            Console.WriteLine("estado civil solteiro(a), CPF " + cliente.getCpf() + ", residente");
            Console.WriteLine("a rua " + cliente.getEndereco().getLogradouro() + ", numero " + cliente.getEndereco().getNumero());
            Console.WriteLine("do bairro " + cliente.getEndereco().getBairro() + ", na cidade de " + cliente.getEndereco().getCidade() + " " + cliente.getEndereco().getEstado());
            Console.WriteLine("de ora em diante chamado simplesmente de LOCATÁRIO.");

            Console.WriteLine("têm, entre si, como justo e contratado o que se segue: ");
            Console.WriteLine("\n+ As cláusulas foram ocultadas...");
        }


        //SET E GET MENSAL
        public void setMensal(double mensal)
        {
            this.mensal = mensal;
        }

        public double getMensal()
        {
            return mensal;
        }

        //SET E GET QUANTIDADE DE MESES
        public void setQtdMeses(int qtdMeses)
        {
            this.qtdMeses = qtdMeses;
        }

        public int getQtdMeses()
        {
            return qtdMeses;
        }


        //SET E GET IMOVEL DENTRO DE ALUGUEL
        public void setImovel(Imovel imovel)
        {
            this.imovel = imovel;
        }

        public Imovel getImovel()
        {
            return imovel;
        }

        //SET E GET CLIENTE DENTRO DE ALUGUEL
        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public Cliente getCliente()
        {
            return cliente;
        }

        //SET E GET FUNCIONARIO  DENTRO DE ALUGUEL
        public void setFuncionario(Funcionario funcionario)
        {
            this.funcionario = funcionario;
        }

        public Funcionario getFuncionario()
        {
            return funcionario;
        }

    }
}
