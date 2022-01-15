#include <iostream>
#include <locale>
using namespace std;

strinf getMeio (int c)
{
    string meio = " * ";

    if (c == 1)
    {
        return 0;
    }
    else
    {
        return meio + getMeio (c-2);
    }
}


void desenha(int col)
{
    string branco = " ";
    for (int i=1; i<=col-1; i++)
    {
        branco += "  ";
    }

    for (int i=1; i<=col; i++)
    {
        cout << "* ";
        branco = branco + " ";
    }
    cout << endl;

    for (int i=1; i<=col; i++)
    {
        cout << "*" << branco << "*" << endl;

    }

    for (int i=1; i<=col; i++)
    {
        cout << "* ";
    }



}


int main ()
{
    setlocale(LC_ALL, "portuguese");

    int col;

    cout << "Digite o numero maximo de colunas: ";
    cin >> col;
    desenha (col);

    /* SE FOR USAR OCMANDO DE REPETIÇÃO */


    return 0;
}
