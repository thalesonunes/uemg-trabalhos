#include <iostream>
#include <stdlib.h>
using namespace std;

bool numPerfeito(int X)
{
    int soma=0;

    for(int i=1; i<X; i++)
    {

        if(X % i == 0)
            soma = soma + i;
    }

    if (X == soma)
    {
        return true;
    }

    return false;

}

int main()
{
    setlocale(LC_ALL, "portuguese");

    int numero;
    cout << "Digite um numero" << endl;
    cin >> numero;

    if(numPerfeito(numero))
    {
        cout << "O numero é PERFEITO" << endl;
    }else
    {
        cout << "O numero é IMPERFEITO" << endl;
    }

    return 0;
}
