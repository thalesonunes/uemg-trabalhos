#include <iostream>
using namespace std;

struct dados
{
    int idade;
    char sexo;
    double salario;
    int filhos;
};

void cadastrando (dados *habitantes)
{
    for (int i=0; i<250; i++)
    {
        cout << "IDADE: ";
        cin >> habitantes[i].idade;
        cout << "SEXO: ";
        cin >> habitantes[i].sexo;
        cout << "SALARIO: ";
        cin >> habitantes[i].salario;
        cout << "FILHOS: ";
        cin >> habitantes[i].filhos;

    }
}

int main()
{
    setlocale(LC_ALL, "portuguese");

    dados habitantes[250];
    cadastrando (habitantes);

    return 0;
}
