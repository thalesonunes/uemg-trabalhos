#include <iostream>
#include <stdlib.h>
using namespace std;

double soma(int num)
{
    double S=0;

    for (double i=1; i <= num; i++)
    {
        double f=i;

        for(double j=num; j>=1; j--)
        {
            f = f*j;
        }

        S = S + (1/f);
    }

    return S;
}

int main()
{
    setlocale(LC_ALL, "portuguese");

    int numero = 0;
    cout << "Digite um numero" << endl;
    cin >> numero;

    cout << "O resultado é " << soma(numero) << endl;


    return 0;
}
