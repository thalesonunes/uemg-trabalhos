#include <iostream>
using namespace std;

int contador = 0;

int numeros(int num)
{
    int nPerfeitos[5];

    int banana;
    while(contador < 6)
    {
        nPerfeitos[contador] = contador;
        contador++;
    }
    cout << banana;

    return nPerfeitos;

}


int main()
{
    setlocale(LC_ALL, "portuguese");

    int nPerfeitos [5];
    numeros();

    cout << "O seis primeros números perfeitos são: ";
    for (int i=0; i<6; i++)
    {
        cout << nPerfeitos[i] << ", ";
    }
    cout << endl;

    return 0;
}



