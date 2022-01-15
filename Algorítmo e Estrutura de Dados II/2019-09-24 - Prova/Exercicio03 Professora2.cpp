#include <iostream>
using namespace std;


string codifica (string texto)
{
    string saida="";

    for (int x=0; x<texto.length(); x++)
    {

            if (texto[x] >= 118)
            {
                saida += 96+(texto[x]+5 - 122);
            }
            else
            {
                saida += texto[x]+5;
            }

    }

    return saida;
}

int main()
{
    setlocale(LC_ALL, "portuguese");

    // DANDO CÓDIGOS AS LETRAS

    string palavra;
    cout << "Digite a palavra" << endl;
    cin >> palavra;

    for (int i=0; i<palavra.length(); i++)
    {
        palavra[i] = tolower(palavra[i]);
    }

    cout << codifica (palavra);

    return 0;
}
