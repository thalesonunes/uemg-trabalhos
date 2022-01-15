#include <iostream>
#include <stdlib.h>
using namespace std;

int converIdade(int A, int M, int D)
{
    int somando=0;
    somando = ((A*365) + (M*30) + D);

    return somando;
}

int main()
{
    setlocale(LC_ALL, "portuguese");

    int idadeA, idadeM, idadeD;
    cout << "Digite sua idade em ANOS, MESES e DIAS (respectivamente): " << endl;
    cin >> idadeA >> idadeM >> idadeD;

    cout << "Você tem " << converIdade(idadeA, idadeM, idadeD) << " dias de vida." << endl;

    return 0;
}
