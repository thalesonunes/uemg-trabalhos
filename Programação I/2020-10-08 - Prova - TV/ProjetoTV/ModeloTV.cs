using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTV
{
    class ModeloTV : TV, ControleRemoto
    {
        private string marca;
        private string modelo;


        // CONSTRUTORES
        public ModeloTV()
        {

        }

        public ModeloTV(int tamanho)
        {
            setTamanho(tamanho);
        }


        // METODOS HERDADOS DA INTERFACE

        public void MudarCanal(int canal)
        {
            setCanal(canal);
        }
        public void AumentaVolume(int taxa)
        {
            setVolume(getVolume() + taxa);
        }
        public void DiminuiVolume(int taxa)
        {
            setVolume(getVolume() - taxa);
        }
        public bool Ligar()
        {
            return true;
        }
        public bool Desligar()
        {
            return false;
        }


        // GET E SETS

        public string getMarca() { return marca; }
        public void setMarca(string marca) { this.marca = marca; }

        public string getModelo() { return modelo; }
        public void setModelo(string modelo) { this.modelo = modelo; }


        // CADASTRAR TV
        public ModeloTV cadastrarTV ()
        {
            ModeloTV novaTvAux = new ModeloTV();

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("                      CADASTRAR TV                       ");
            Console.WriteLine("---------------------------------------------------------");

            Console.Write("Digite a MARCA da TV: ");
            novaTvAux.setMarca(Console.ReadLine());
            Console.Write("Digite o MODELO da TV: ");
            novaTvAux.setModelo(Console.ReadLine());
            Console.Write("Digite o TAMANHO da TV: ");
            novaTvAux.setTamanho(Convert.ToInt32(Console.ReadLine()));

            return novaTvAux;

        }
    }
}
