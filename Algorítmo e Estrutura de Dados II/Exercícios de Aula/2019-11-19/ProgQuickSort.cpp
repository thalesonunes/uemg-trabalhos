
// INCLUINDO BIBLIOTECAS NECESSÁRIAS
//--------------------------------------------------------------------------------
#include <iostream>
#include <fstream>
#include <stdlib.h>
using namespace std;

void quicksort (int vet [], int inicio, int fim)
    {
        int pivo, i=inicio, j=fim, meio, aux;

        meio = (int)((i+j)/2);
        pivo = vet[meio];

        do
        {
            while (vet[i] < pivo) i=i+1;
            while (vet[j] > pivo) j=j-1;

            if (i<=j)
            {
                aux = vet[i];
                vet[i] = vet[j];
                vet[j] = aux;
                i = i+1;
                j = j-1;
            }

        }while (j>i);

        if (inicio < j) quicksort (vet, inicio, j);
        if (i < fim) quicksort (vet, i, fim);
    }

// ENTRADA DO PROGRAMA
//--------------------------------------------------------------------------------
int main()
{

    setlocale(LC_ALL, "portuguese");

    int t;

    cout << "Tamanho do vetor: ";
    cin >> t;

    int vet[t];

    for (int i=0; i<t; i++)
    {
        cout << "Digite um valor: ";
        cin >> vet[i];
    }

    quicksort(vet, 0, t-1);

    cout << endl << "========================================" << endl;
    cout << "OS NUMEROS ORDENADOS: ";

    for (int i=0; i<t; i++)
    {
        cout << vet[i] << " ";
    }

    cout << endl << "========================================" << endl;

    system("pause");

    return 0;
}
