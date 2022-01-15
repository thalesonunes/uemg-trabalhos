#include <iostream>
using namespace std;


// ESTRUTURA DE CADASTRO DE DADOS
struct dados
{
    int idade;
    char sexo;
    double salario;
    int filhos;
};


// FUNÇÃO DE CADASTRO DE DADOS
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
        cout << endl;

    }
}

int main()
{
    setlocale(LC_ALL, "portuguese");

    dados habitantes[250];
    cadastrando (habitantes);

    return 0;
}
