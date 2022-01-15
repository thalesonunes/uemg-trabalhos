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


// CALCULA A MÉDIA SALARIAL DOS HABITANTES
int mediaSalario (dados *habitantes)
{
    int media=0;
    for (int i=0; i<=250; i++)
    {
        media = media + habitantes[i].salario;
    }

    return media/3;
}


// VERIFICA A MAIOR IDADE
int maiorIdade (dados *habitantes)
{
    int maior=0;

    for (int i=0; i<250; i++)
    {
        if (habitantes[i].idade > maior)
        {
            maior = habitantes[i].idade;
        }
    }

    return maior;
}


// VERIFICA A MENOR IDADE
int menorIdade (dados *habitantes)
{
    int menor=1000;

    for (int i=0; i<250; i++)
    {
        if (habitantes[i].idade < menor)
        {
            menor = habitantes[i].idade;
        }
    }

    return menor;
}


// VERIFICA QTD DE MULHERES COM 3 FILHOS COM SALÁRIO ATÉ R$ 900
int nMulheres (dados *habitantes)
{
    int numero=0;
    for (int i=0; i<250; i++)
    {
        if ((habitantes[i].filhos == 3) && (habitantes[i].salario <= 900) && (habitantes[i].sexo == 'F'))
        {
            numero = numero+1;
        }
    }

    return numero;
}


int main()
{
    setlocale(LC_ALL, "portuguese");

    dados habitantes[250];
    cadastrando (habitantes);

    cout << "A media salarial entre os habitantes é de " << mediaSalario (habitantes) << endl;
    cout << "A maior idade é de " << maiorIdade (habitantes) << " anos." << endl;
    cout << "A menor idade é de " << menorIdade (habitantes) << " anos." << endl;
    cout << "Existe(m) " << nMulheres (habitantes) << " mulher(es) com 03 filhos que recebem até R$900,00." << endl;

    return 0;
}
