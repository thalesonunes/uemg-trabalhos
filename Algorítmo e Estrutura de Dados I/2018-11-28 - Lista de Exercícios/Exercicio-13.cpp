#include <iostream>

using namespace std;

int main ()
{
    setlocale (LC_ALL, "portuguese");


    int maior=0, menor=0, numero;

    cout << "Digite um numero INTEIRO e POSITIVO ou 0(zero) para finalizar: ";
    cin >> numero;

    while (numero<0)
    {
        cout << "------------------------------------------------------------" << endl;
        cout << "Numero incorreto. Digite novamente!" << endl;
        cout << "------------------------------------------------------------" << endl;
        cout << " " << endl;
        cout << "Digite um numero INTEIRO e POSITIVO ou 0(zero) para finalizar: ";
        cin >> numero;
    }

    if (numero>0)
    {
        menor=numero;
        maior=numero;
    }

    while (numero>0)
    {
        if (numero>maior)
        {
            maior = numero;
        }

        if (numero<menor)
        {
            menor = numero;
        }

        cout << "Digite um numero INTEIRO e POSITIVO ou 0(zero) para finalizar: ";
        cin >> numero;
    }

    cout << "------------------------------------------------------------" << endl;
    cout << "O menor numero digitado foi " << menor << " e o maior foi " << maior << endl;
    cout << "------------------------------------------------------------" << endl;
    cout << " " << endl;


    return 0;
}
