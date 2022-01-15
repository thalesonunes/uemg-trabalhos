#include <iostream>
#include <stdlib.h>
using namespace std;

int numDiv(int X)
{
        int soma=0;

    for(int i=1; i<=X; i++)
    {

        if(X % i == 0)
            soma = soma + 1;
    }

    return soma;

}

int main()
{
    setlocale(LC_ALL, "portuguese");

    int numero;

    cout << "Digite um numero" << endl;
    cin >> numero;

    cout << "O numero de dividores desse numero é " << numDiv(numero) << endl;

    return 0;
}
