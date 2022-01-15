using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUniversidade
{
    class Exemplar
    {
        private int codigo;
        private int nroExemplar;
        private bool exclusivo;
        private Livro livro;


        public Exemplar() { }

        public Exemplar(int codigo, int nroExemplar, bool exclusivo, Livro livro1)
        {
            this.codigo = codigo;
            this.nroExemplar = nroExemplar;
            this.exclusivo = exclusivo;
            livro = livro1;
        }

        public void mostraDadosExemplar()
        {
            //DADOS DO EXEMPLAR
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO EXEMPLAR*****");
            Console.WriteLine("CODIGO: " + codigo);
            Console.WriteLine("NÚMERO DE EXEMPLAR: " + nroExemplar);
            Console.WriteLine("EXCLUSIVO: " + (convertBoolToString(exclusivo)));
           
            //ASSOCIAÇÃO LIVRO
            livro.mostraDadosLivro();
        }

        public void mostraDadosExemplarImprimir()
        {
            //DADOS DO EXEMPLAR PARA IMPRIMIR NO MENU
            Console.WriteLine("\n");
            Console.WriteLine("*****DADOS DO EXEMPLAR*****");
            Console.WriteLine("CODIGO: " + codigo);
            Console.WriteLine("NÚMERO DE EXEMPLAR: " + nroExemplar);
            Console.WriteLine("EXCLUSIVO: " + (convertBoolToString(exclusivo)));
        }


        // SAIDA DOS DADOS
        public string convertBoolToString(bool dados)
        {
            string boolConvertido;

            if (dados)
            {
                boolConvertido = "Sim";
            }
            else
            {
                boolConvertido = "Nao";
            }

            return boolConvertido;
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


        //SET E GET NÚMERO DO EXEMPLAR
        public void setNroExemplar(int nroExemplar)
        {
            this.nroExemplar = nroExemplar;
        }

        public int getNroExemplar()
        {
            return nroExemplar;
        }

        //SET E GET EXCLUSIVO
        public void setExclusivo(string exclusivo)
        {
            bool stringConvertido = false;

            if (exclusivo == "Sim" || exclusivo == "SIM" || exclusivo == "sim")
            {
                stringConvertido = true;
            }
            else
            {
                stringConvertido = false;
            }

            this.exclusivo = stringConvertido;
        }

        public bool getExclusivo()
        {
            return exclusivo;
        }


        // SET E GET LIVRO DENTRO DE EXEMPLAR

        public void setLivro(Livro livro)
        {
            this.livro = livro;
        }

        public Livro getLivro()
        {
            return this.livro;
        }




    }
}
