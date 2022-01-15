#include <iostream>
using namespace std;


void codifica ()
{
    int nCaracteres;

    cout << "QUANTOS CARACTERES TEM SUA PALAVRA? " << endl;
    cin >> nCaracteres;

    char letras[nCaracteres];

    cout << "Digite cada letra e aperte ENTER: " << endl;

    for (int i=0; i < nCaracteres; i++)
    {
        cin >> letras[i];
    }

    for (int i=0; i < nCaracteres; i++)
    {
        int emNumero;
        emNumero = letras[i];
        emNumero = emNumero + 5;
        letras[i] = emNumero;
    }

    cout << "A PALAVRA CODIFICADA: ";

    for (int i=0; i < nCaracteres; i++)
    {
        cout << letras[i];
    }

    cout << endl;
}


int main()
{
    setlocale(LC_ALL, "portuguese");

    codifica();

    return 0;
}
