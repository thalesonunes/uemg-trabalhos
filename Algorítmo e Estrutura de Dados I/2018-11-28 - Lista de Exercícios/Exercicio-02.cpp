#include <iostream>

using namespace std;

int main ()
{
    setlocale (LC_ALL, "portuguese");

    double numero;
    int maior=0;

    for (int i=0; i < 6; i++)
    {
        cout << "Digite um numero: ";
        cin >> numero;

        if(numero > 7)
        {
            maior = maior + 1;
        }
    }

    cout << "=============================================" << endl;
    cout << maior << " dos números digitados são maiores que sete" << endl;
    cout << "=============================================" << endl;

    return 0;
}
