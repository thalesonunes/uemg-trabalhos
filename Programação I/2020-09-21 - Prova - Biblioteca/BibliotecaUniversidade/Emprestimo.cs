using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUniversidade
{
    class Emprestimo
    {
        private int codigo;
        private DateTime dataEmprestimo;
        private DateTime dataDevolucao;
        private double valorMulta;
        private Exemplar exemplar;
        private Pessoa pessoa;


        public Emprestimo() { }

        public Emprestimo(int codigo, DateTime dataEmprestimo, DateTime dataDevolucao, double valorMulta, Exemplar exemplar, Pessoa pessoa)
        {
            this.codigo = codigo;
            this.dataEmprestimo = dataEmprestimo;
            this.dataDevolucao = dataDevolucao;
            this.valorMulta = valorMulta;
            this.exemplar = exemplar;
            this.pessoa = pessoa;
        }

        public void mostraDadosEmprestimo()
        {
            //DADOS DO EMPRESTIMO
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO EMPRÉSTIMO*****");
            Console.WriteLine("CODIGO: " + codigo);
            Console.WriteLine("DATA DO EMPRÉSTIMO: " + dataEmprestimo);
            Console.WriteLine("DATA DA DEVOLUÇÃO: " + dataDevolucao);
            Console.WriteLine("VALOR DA MULTA: " + valorMulta);
                        
            //ASSOCIAÇÃO EXEMPLAR
            exemplar.mostraDadosExemplar();

            //ASSOCIAÇÃO PESSOA
            pessoa.mostraDadosPessoaImprimir();
        }

        public void mostraDadosEmprestimoImprimir()
        {
            //DADOS DO EMPRESTIMO PARA IMPRIMIR NO MENU 
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO EMPRÉSTIMO*****");
            Console.WriteLine("CODIGO: " + codigo);
            Console.WriteLine("DATA DO EMPRÉSTIMO: " + dataEmprestimo);
            Console.WriteLine("DATA DA DEVOLUÇÃO: " + dataDevolucao);
            Console.WriteLine("VALOR DA MULTA: " + valorMulta);
        }



        //SET E GET CÓDIGO
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public int getCodigo()
        {
            return codigo;
        }

        //SET E GET DATA EMPRESTIMO
        public void setDataEmprestimo(DateTime dataEmprestimo)
        {
            this.dataEmprestimo = dataEmprestimo;
        }

        public DateTime getDataEmprestimo()
        {
            return dataEmprestimo;
        }

        //SET E GET DATA DEVOLUÇÃO
        public void setDataDevolucao(DateTime dataDevolucao)
        {
            this.dataDevolucao = dataDevolucao;
        }

        public DateTime getDataDevolucao()
        {
            return dataDevolucao;
        }

        //SET E GET VALOR MULTA
        public void setValorMulta(double valorMulta)
        {
            this.valorMulta = valorMulta;
        }

        public double getValorMulta()
        {
            return valorMulta;
        }


        // SET E GET EXEMPLAR DENTRO DE EMPRESTIMO

        public void setExemplar(Exemplar exemplar)
        {
            this.exemplar = exemplar;
        }

        public Exemplar getExemplar()
        {
            return exemplar;
        }


        // SET E GET PESSOA DENTRO DE EMPRESTIMO

        public void setPessoa(Pessoa pessoa)
        {
            this.pessoa = pessoa;
        }

        public Pessoa getPessoa()
        {
            return pessoa;
        }





    }
}
