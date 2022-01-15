#include <iostream>
using namespace std;

void numeros (int *q, int *nPerfeito[q])
{
    int x=0;

    while (q >= 0)
    {
        x++;
        int s=0;


        for(int i =1; i<x ; i++)
        {
            if(x%i ==0)
            {
                s = s+i;
            }

        }

        if (s == x)
        {
            q--;
            contador++;
            nPerfeito[contator] == x;

            ;
        }
    }

}

int contador=0;
int q=6;

int main()
{
    setlocale(LC_ALL, "portuguese");


    int nPerfeito[q];
    numeros(nPerfeito[q]);

    for (int i = 0; i<q; i++)
    {
        cout << nPerfeito[i] << ", ";
    }

    return 0;
}



