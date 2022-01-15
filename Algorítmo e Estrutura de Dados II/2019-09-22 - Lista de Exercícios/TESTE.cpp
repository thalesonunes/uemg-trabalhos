#include <iostream>
using namespace std;

bool nPerfeito (int numeral)
{
    int soma = 0;
    for (int i=1; i<numeral; i++)
    {
        if (numeral % i == 0)
        {
            soma = soma + i;
        }
    }
    if (soma == numeral)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void printPerfeitos ()
{

}


int main()
{
    setlocale(LC_ALL, "portuguese");

    int numero;

    cout << "INFORME UM NUMERO: ";
    cin >> numero;

    if(nPerfeito(numero))
    {
        cout << "O NUMERO É PERFEITO: " << endl;
    }
    else
    {
        cout << "O NUMERO É IMPERFEITO: " << endl;
    }




   return 0;
}

