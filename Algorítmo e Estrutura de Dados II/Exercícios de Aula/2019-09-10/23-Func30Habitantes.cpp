#include <iostream>
#include <stdlib.h>
using namespace std;

struct TPessoa
{
    string sexo;
    string olhos;
    string cabelos;
    int idade;
};

void cadastra (TPessoa *pessoas)
{
    for (int i=0; i<3; i++)
    {
        cout << "Digite o sexo do habitante: ";
        cin >> pessoas[i].sexo;
        cout << "Digite a cor dos olhos do habitante: ";
        cin >> pessoas[i].olhos;
        cout << "Digite a cor dos cabelos do habitante: ";
        cin >> pessoas[i].cabelos;
        cout << "Digite a idade do habitante: ";
        cin >> pessoas[i].idade;
    }
}

int buscaCorCabelo(TPessoa *pessoas, string cor)
{
    int x=0;
    for (int i=0; i<3; i++)
    {
        if (pessoas[i].cabelos == cor)
        {
            x++;
        }

    }
    return x;
}

int main()
{
    setlocale(LC_ALL, "portuguese");

    TPessoa dados[30];
    cadastra(dados);

    cout << "Sexo do segundo habitante " << dados[1].sexo << endl;

    cout << "E a quantidade de habitantes com a cor de cabelo preto = " << buscaCorCabelo(dados, "preto") << endl;

    return 0;
}
