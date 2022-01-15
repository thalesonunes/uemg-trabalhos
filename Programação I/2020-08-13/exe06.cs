using System;

namespace exe06
{
    class Retângulo()
    {
        double lado1, lado2, area, perimetro;

        public Retangulo()
        {
            lado1 = ∅;
            lado2 = ∅;
        }

        public void CalculaArea()
        {
            area = lado1 * lado2;
        }

        public double CalculaPerimetro()
        {
            perimetro = 2*(lado1+lado2);
            return perimetro;
        }


        public void setlado1(double l)
        {
            lado1 = l;
        }

        public double getlado1()
        {
            return lado1;
        }

        public void setlado2(double l)
        {
            lado2 = l;
        }

        public double getlado2()
        {
            return lado2;
        }

        public double getperimetro()
        {
            return perimetro;
        }

        public double getarea()
        {
            return area;
        }


    }

    Class TestaRetangulo()
    {
        Retangulo r1 = new Retangulo();

        public static void main()
        {
            r1.lado1=10;
            r2.lado2=5;

            r1.CalculaArea();
            Console.Writeline(r1.area);
            Console.Writeline(r1.CalculaPerimetro());
            r1.lado2=7;
            r1.CalculaArea();
            Console.Writeline(r1.area);
            Console.Writeline(r1.CalculaPerimetro());
        }
    }

}