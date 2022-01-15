#include <iostream>
using namespace std;


string codifica (string *texto)
{
    int n;
    n = string.length(texto);

    for (int i=0; i<n, i++)
    {
        texto[i] = texto[i+5];
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
    texto = banana;

    codifica (texto);

    return 0;
}
