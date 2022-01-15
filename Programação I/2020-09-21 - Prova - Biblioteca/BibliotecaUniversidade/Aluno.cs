using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUniversidade
{
    class Aluno : Pessoa
    {

        private int matricula;
        private DateTime dataInicio;
        private DateTime dataConclusao;
        private double valorDesconto;
        private string situacao;
        private Curso curso;


        public Aluno() { }

        public Aluno(int matricula, DateTime dataInicio, DateTime dataConclusao, double valorDesconto, string situacao, Curso curso)
        {
            this.matricula = matricula;
            this.dataInicio = dataInicio;
            this.dataConclusao = dataConclusao;
            this.valorDesconto = valorDesconto;
            this.situacao = situacao;
            this.curso = curso;
        }

        public void mostraDadosAluno()
        {
            //DADOS DO ALUNO
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO ALUNO*****");
            Console.WriteLine("MATRÍCULA: " + matricula);
            Console.WriteLine("DATA DE INICIO: " + dataInicio);
            Console.WriteLine("DATA DE CONCLUSÃO: " + dataConclusao);
            Console.WriteLine("VALOR DO DESCONTO: " + valorDesconto);
            Console.WriteLine("SITUAÇÃO: " + situacao);
            Console.WriteLine("CPF: " + cpf);

            //HERANÇA PESSOA
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS PESSOAIS*****");
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("RG: " + rg);
            Console.WriteLine("DATA DE NASCIMENTO: " + dataNascimento);
            Console.WriteLine("TELEFONE: " + telefone);
            Console.WriteLine("EMAIL: " + email);
            Console.WriteLine("LIBERADO: " + (convertBoolToString(liberado)));
            endereco.mostraDadosEndereco();

            //ASSOCIAÇAO CURSO
            curso.mostraDadosCurso();
        }

        public void mostraDadosAlunoImprimir()
        {
            //DADOS DO ALUNO PARA IMPRIMIR NO MENU
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO ALUNO*****");
            Console.WriteLine("MATRÍCULA: " + matricula);
            Console.WriteLine("DATA DE INICIO: " + dataInicio);
            Console.WriteLine("DATA DE CONCLUSÃO: " + dataConclusao);
            Console.WriteLine("VALOR DO DESCONTO: " + valorDesconto);
            Console.WriteLine("SITUAÇÃO: " + situacao);
            Console.WriteLine("CPF: " + cpf);
        }


            //SET E GET MATRÍCULA
            public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public int getMatricula()
        {
            return matricula;
        }

        //SET E GET DATA DE INICIO
        public void setDataInicio(DateTime dataInicio)
        {
            this.dataInicio = dataInicio;
        }

        public DateTime getDataInicio()
        {
            return dataInicio;
        }

        //SET E GET DATA DE CONCLUSÃO
        public void setDataConclusao(DateTime dataConclusao)
        {
            this.dataConclusao = dataConclusao;
        }

        public DateTime getDataConclusao()
        {
            return dataConclusao;
        }


        //SET E GET VALOR DO DESCONTO
        public void setValorDesconto(double valorDesconto)
        {
            this.valorDesconto = valorDesconto;
        }

        public double getValorDesconto()
        {
            return valorDesconto;
        }


        //SET E GET SITUAÇÃO
        public void setSituacao(string situacao)
        {
            this.situacao = situacao;
        }

        public string getSituacao()
        {
            return situacao;
        }


        // SET E GET CURSO DENTRO DE ALUNO
        public void setCurso(Curso curso)
        {
            this.curso = curso;
        }

        public Curso getCurso()
        {
            return curso;
        }



    }
}
