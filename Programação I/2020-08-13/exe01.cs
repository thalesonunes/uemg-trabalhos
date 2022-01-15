using System;

namespace exe01
{
    public class Pessoa
    {
        private string nome;
        private int idade;

        public string getNome(){
        return nome;
        }

        public void setNome(string novoNome){
        nome = novoNome;
        }

        public int getIdade(){
            return idade;
        }

        public void setIdade(int novaIdade){
            if(idade < 0)
            {
                idade = 0;
            }
            else
            {
                idade = novaIdade;
            }
        }
    }

}