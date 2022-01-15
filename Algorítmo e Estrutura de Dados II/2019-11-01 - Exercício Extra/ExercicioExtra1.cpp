#include <iostream>
using namespace std;

double vetor[20];

void GeraVet (double *vetor)
{

    for(int i=0; i<10; i++)
    {
        if (i % 2 == 0)
        {
            vetor[i+10] = (vetor[i]*1.03);
        }
        else
        {
            vetor[i+10] = (vetor[i]*1.10);
        }
    }

}

int main ()
{

    // INSERINDO VALORES
    for(int i=0; i<10; i++)
    {
        cout << "Digite um valor: ";
        cin >> vetor[i];
    }
    cout << endl;


    // CHAMANDO FUNÇÃO

    GeraVet (vetor);

    // IMPRIMINDO NA TELA
    cout << "O numero sao: " << endl;
    for(int i=0; i<20; i++)
    {
        cout << "[" << vetor[i] << "] ";
    }


}
