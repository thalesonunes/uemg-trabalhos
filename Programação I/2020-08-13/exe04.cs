using System;

namespace exe04
{
    class Dvd()
    {
        int codigo, ano;
        string titulo, genero, artista;
        float precov, precoc;
        bolean status;

        public Dvd ()
        {
            codigo = ano = ∅;
            titulo = genero = artista = “ “;
            precov = precoc = ∅;
            status = true;
        }


        public void vender ()
        {
            status = false;
        }

        public void devolver ()
        {
            status = true;
        }

        public void AlteraPreco (float nu)
        {
            precov = nu;
        }

        public void AlteraAno(int nano)
        {
            ano = nano;
        }

        public float VerPrecov()
        {
        return precov;
        }

        public string VerStatus()
        {
            if (status){
                 return “disponivel”;
            }else{
                return “indisponivel”;
            }
        }

        public string VerArtista() 
        {
            return artista;
        }


        public int codigo(){
            return codigo;
        }
        public void codigo (int c){
            codigo = c;
        }


        public int ano(){
            return ano;
        }
        public void ano (int a){
            ano = a;
        }


        public string titulo(){
            return titulo;
        }
        public void titulo (string t){
            titulo = t;
        }


        public string genero(){
            return genero;
        }
        public void genero (string g){
            genero = g;
        }
        

        public string artista(){
            return artista;
        }
        public void artista (string a){
            artista = a;
        }


        public float precov(){
            return precov;
        }
        public void precov (float pv){
            precov = pv;
        }


        public float precoc(){
            return precoc;
        }
        public void precoc (float pc){
            precoc = pc;
        }


        public boolean status(){
            return status;
        }
        public void status (boolean s){
            status = s;
        }
        
    }

}