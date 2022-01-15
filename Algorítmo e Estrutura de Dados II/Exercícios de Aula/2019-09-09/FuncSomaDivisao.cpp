#include <iostream>
#include <stdlib.h>
using namespace std;

double soma(int num)
{
    double S=0;
    for (double i=1; i <= num; i++)
    {
        S = S + (1/i);
    }

    return S;
}

int main()
{
    setlocale(LC_ALL, "portuguese");

    int numero = 0;
    cout << "Digite um numero" << endl;
    cin >> numero;

    cout << "O a soma das divisões é " << soma(numero) << endl;


    return 0;
}
