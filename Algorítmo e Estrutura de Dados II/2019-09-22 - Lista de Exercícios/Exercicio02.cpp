#include <iostream>
#include <stdlib.h>
using namespace std;

struct tabela
{
    string nome;
    int idade;
    char sexo;
};

void cadastra (tabela *pessoas)
{
    for (int i=0; i<15; i++)
    {
        cout << "NOME: ";
        cin >> pessoas[i].nome;
        cout << "IDADE: ";
        cin >> pessoas[i].idade;
        cout << "SEXO (M ou F): ";
        cin >> pessoas[i].sexo;
        cout << endl;

    }
}

int buscador(tabela *pessoas, char sexo)
{
    int x=0;
    for (int i=0; i<15; i++)
    {
        if ((pessoas[i].idade >= 18) && (pessoas[i].idade <= 35) && (pessoas[i].sexo == sexo))
        {
            x++;
        }

    }
    return x;
}

int main()
{
    setlocale(LC_ALL, "portuguese");

    tabela pessoas[15];
    cadastra(pessoas);

    cout << "E a quantidade mulheres com idade entre 18 e 35 é = " << buscador(pessoas, 'F') << endl;

    return 0;
}
