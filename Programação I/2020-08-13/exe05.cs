using System;

namespace exe05
{
    class Calculadora()
    {
        float a, b;

        public Calculadora (float x, float y)
        {
            a = x; b = y;
        }

        public float soma(){
        return a + b;
        }

        pubic float sub (){
        retur a – b;
        }

        public float divisao(){
        return a/b;
        }

        pubic float mult(){
        return a*b;
        }

            public void setla(float n)
            {
                a = n;
            }

            public float geta()
            {
                return a;
            }


            public void setlb(float m)
            {
                a = m;
            }

            public float getb()
            {
                return b;
            }

    }

    public class testCalc{
    Calculadora c1 = new Calculadora (10,3)

    public static void main(){
    Console.Writeline(c1.soma());
    }
    }

}