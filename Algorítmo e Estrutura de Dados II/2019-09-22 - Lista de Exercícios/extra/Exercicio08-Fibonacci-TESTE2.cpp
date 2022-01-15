#include <iostream>
using namespace std;



// FUNÇÃO DE CADASTRO DE DADOS
void geraNumeros (int *numeros, int q)
{

    int n1=0, n2=1;

    for (int i=2; i<q; i++)
    {
        numeros[i] = n1 + n2;
        n1 = n2;
        n2 = numeros[i];
    }

    return numeros;
}



int main()
{
    setlocale(LC_ALL, "portuguese");

    int q;
    cout << "QUANTIDADE DE NUMEROS DA SÉRIE: ";

    int numeros[q];

    geraNumeros (numeros, q)

    cout << numeros[3];


    return 0;
}
