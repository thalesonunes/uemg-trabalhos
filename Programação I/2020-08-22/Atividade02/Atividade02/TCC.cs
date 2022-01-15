
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02
{
    class TCC
    {
        string titulo, resumo, area;

        public TCC(string titulo, string resumo, string area)
        {
            this.titulo = titulo;
            this.resumo = resumo;
            this.area = area;
        }

        public void imprimeDados()
        {
            Console.WriteLine("TÍTULO: " + titulo);
            Console.WriteLine("RESUMO: " + resumo);
            Console.WriteLine("ÁREA: " + area);
            Console.WriteLine("");
        }
    }
}
