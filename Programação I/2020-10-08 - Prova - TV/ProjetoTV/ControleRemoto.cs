using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTV
{
    interface ControleRemoto
    {
        void MudarCanal(int canal);
        void AumentaVolume(int taxa);
        void DiminuiVolume(int taxa);
        bool Ligar();
        bool Desligar();
    }
}
