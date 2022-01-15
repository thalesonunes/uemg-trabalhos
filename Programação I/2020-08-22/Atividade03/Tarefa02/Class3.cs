using System;
using System.Collections.Generic;
using System.Text;

namespace Tarefa02
{
    class TCC
    {
        string titulo, resumo;
        string area;


        public TCC(string titulo, string resumo, string area)
        {
            this.titulo = titulo;
            this.resumo = resumo;
            this.area = area;
        }

        public void mostraDados()
        {
            Console.WriteLine(titulo);
            Console.WriteLine(resumo);
            Console.WriteLine(area);
        }


    }
}
