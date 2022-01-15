using System;

namespace exe02
{
    class Veiculo
    {
        string modelo;
        int ano;
        double preco;

        public Veiculo()
        {
            modelo = “ “; ano = ∅, preco = ∅;
        }

        public Veiculo(string modelo, int idade, double preco)
        {
            this.modelo = modelo;
            this.ano = ano;
            this.preco = preco;
        }

        public Veiculo(double preco)
        {
            this.preco = preco;
        }

            public string modelo(){
            return modelo;
            }
            public void modelo (string m){
                modelo = m;
            }


            public int ano(){
                return ano;
            }
            public void ano (int a){
                ano = a;
            }

            public double preco(){
            return precoc;
            }
            public void preco (double p){
                preco = p;
            }
    }

}