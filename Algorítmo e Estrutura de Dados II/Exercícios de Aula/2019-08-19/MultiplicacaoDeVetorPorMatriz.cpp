#include <iostream>
using namespace std;

int main()
{
    int vet[3];
    int mat[3][2];
    int saida [2];

    for (int i=0; i<3; i++)
    {
        cout << "Digite um valor para vetor: ";
        cin >> vet[i];
    }

    for (int i=0; i<3; i++)
        {
            for (int j=0; j < 2; j++)
                {
                    cout << "Digite um valor para matriz: ";
                    cin >> mat [i][j];

                }
        }

    //calcular o produto

    int aux=0;
    for(int c=0; c<2; c++)
    {
        for (int l=0; l<3; l++)
        {
            aux = aux + vet[l] * mat [l][c];
        }

        saida [c] = aux;
        aux = 0;
        cout << saida[c] << "\t";
    }


    return (0);
}
