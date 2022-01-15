using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUniversidade
{
    class Livro
    {
        private int codigo;
        private string nome;
        private string autor;
        private int anoLancamento;
        private string editora;
        private int edicao;

        public Livro() { }

        public Livro(int codigo, string nome, string autor, int anoLancamento, string editora, int edicao)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.autor = autor;
            this.anoLancamento = anoLancamento;
            this.editora = editora;
            this.edicao = edicao;
        }

        public void mostraDadosLivro()
        {
            //DADOS DO LIVRO
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO LIVRO*****");
            Console.WriteLine("CODIGO: " + codigo);
            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("AUTOR: " + autor);
            Console.WriteLine("ANO DE LANÇAMENTO: " + anoLancamento);
            Console.WriteLine("EDITORA: " + editora);
            Console.WriteLine("EDIÇÃO: " + edicao);
        }

        public void mostraDadosLivroImprimir()
        {
            //DADOS DO LIVRO PARA IMPRIMIR NO MENU
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO LIVRO*****");
            Console.WriteLine("CODIGO: " + codigo);
            Console.WriteLine("NOME: " + nome);
            Console.WriteLine("AUTOR: " + autor);
            Console.WriteLine("ANO DE LANÇAMENTO: " + anoLancamento);
            Console.WriteLine("EDITORA: " + editora);
            Console.WriteLine("EDIÇÃO: " + edicao);
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

        //SET E GET NOME
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

        //SET E GET AUTOR
        public void setAutor(string autor)
        {
            this.autor = autor;
        }

        public string getAutor()
        {
            return autor;
        }

        //SET E GET ANO DE LANÇAMENTO
        public void setAnoLancamento(int anoLancamento)
        {
            this.anoLancamento = anoLancamento;
        }

        public int getAnoLancamento()
        {
            return anoLancamento;
        }

        //SET E GET EDITORA
        public void setEditora(string editora)
        {
            this.editora = editora;
        }

        public string getEditora()
        {
            return editora;
        }

        //SET E GET EDICAO
        public void setEdicao(int edicao)
        {
            this.edicao = edicao;
        }

        public int getEdicao()
        {
            return edicao;
        }

    }
}
