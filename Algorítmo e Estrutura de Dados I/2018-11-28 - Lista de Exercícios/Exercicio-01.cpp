#include <iostream>

using namespace std;

int main ()
{
    setlocale (LC_ALL, "portuguese");

    double numero, soma=0;

    for (int i=0; i < 5; i++)
    {
        cout << "Digite um numero: ";
        cin >> numero;
        soma = soma + numero;
    }

    cout << "=============================================" << endl;
    cout << "A soma dos números digitados é igual a: " << soma << endl;
    cout << "=============================================" << endl;

    return 0;
}
