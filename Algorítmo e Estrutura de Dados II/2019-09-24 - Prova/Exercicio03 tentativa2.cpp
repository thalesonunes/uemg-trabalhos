#include <iostream>
using namespace std;


string codifica (string *texto)
{
    int n;
    n = string.length(texto);

    for (int i=0; i<n, i++)
    {
        int convertendo;
        convertendo = texto[i];
        convertendo = convertendo+5;
        texto[i] = convertendo;
    }


    cout << "TEXTO CODIFICADO: " << endl;
    for (int i=0; i<n, i++)
    {
        cout >> texto[i];
    }

}

int main()
{
    setlocale(LC_ALL, "portuguese");

    // DANDO CÓDIGOS AS LETRAS

    string texto;
    cout << "Digite a palavra" << endl;
    cin >> texto;

    codifica (texto);

    return 0;
}
