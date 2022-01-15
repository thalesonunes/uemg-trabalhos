#include <iostream>

using namespace std;

int main ()
{
    setlocale (LC_ALL, "portuguese");

    int idade, cont=0;
    int media=0, soma=0;

    cout << "Digite sua idade: ";
    cin >> idade;

    if (idade!=0)
    {
        cont = cont+1;
        soma = soma + idade;
        media = ((soma)/cont);
        cout << "Média das idades digitadas é igual a: " << media << endl;
        cout << "Foram digtadas " << cont << " idades." << endl;
        cout << " " << endl;
    }

    while (idade!=0)
    {
        cout << "Digite sua idade: ";
        cin >> idade;
        cont = cont+1;
        soma = soma + idade;
        media = ((soma)/cont);
        cout << "Média das idades digitadas é igual a: " << media << endl;
        cout << "Foram digtadas " << cont << " idades." << endl;
        cout << " " << endl;
    }


    return 0;
}
