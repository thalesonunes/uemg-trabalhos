// INCLUINDO BIBLIOTECAS NECESSÁRIAS
//--------------------------------------------------------------------------------
#include <iostream>
#include <fstream>
#include <stdlib.h>
using namespace std;

void bubblesort (int vet [], int tam)
    {
        int aux, menor;

        for (int i=0; i<tam; i++)
        {
            menor = i;

            for (int j=i+1; j<tam; j++)
            {
                if (vet[j] < vet [menor])
                {
                    menor = j;
                }
            } // saio daqui com a posicao do menor valor do vetor

            if (i !=menor)
            {
                aux = vet[i];
                vet[i] = vet[menor];
                vet[menor] = aux;
            }
        }

        // IMPRIME O VETOR ORDENADO

        cout << endl << "========================================" << endl;

        cout << "OS NÚMEROS ORDENADOS: ";

        for (int i=0; i<tam; i++)
        {
            cout << vet[i] << " ";
        }

        cout << endl << "========================================" << endl;


        system("pause");
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

    bubblesort(vet, t);

    return 0;
}
