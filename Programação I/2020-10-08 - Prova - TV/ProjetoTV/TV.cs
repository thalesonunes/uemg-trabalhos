using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTV
{
    class TV
    {
        private int tamanho;
        private int canal;
        private int volume;
        private bool ligada;

        public TV()
        {

        }

        public TV(int tamanho)
        {

        }

        
        // GET E SETS
        public int getTamanho() { return tamanho;  }
        public void setTamanho(int tamanho) { this.tamanho = tamanho; }

        public int getCanal() { return canal; }
        public void setCanal(int canal) { this.canal = canal; }

        public int getVolume() { return volume; }
        public void setVolume(int volume) { this.volume = volume; }

        public bool getLigada() { return ligada; }
        public void setLigada(bool ligada) { this.ligada = ligada; }

        
    }
}
