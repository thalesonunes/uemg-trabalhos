#include <iostream>

using namespace std;

int main ()
{
    setlocale (LC_ALL, "portuguese");

    double salario=1, somaSalario=0, maiorSalario=0, contMenor100=0;
    int numPessoas=0, numFilhos=0, somaFilhos=0;

    cout << "Digite seu salário: ";
    cin >> salario;
    if (salario>0)
    {
        cout << "Digite quantos filhos tem: ";
        cin >> numFilhos;
        cout << "--------------------------------" << endl;
    }

    while (salario > 0)
    {
        somaSalario = somaSalario + salario;
        somaFilhos = somaFilhos + numFilhos;
        numPessoas = numPessoas + 1;


        if (salario > maiorSalario)
        {
            maiorSalario = salario;
        }

        if (salario < 100)
        {
            contMenor100 = contMenor100 + 1;
        }

        cout << "Digite seu salário: ";
        cin >> salario;
        if (salario>0)
        {
            cout << "Digite quantos filhos tem: ";
            cin >> numFilhos;
            cout << "--------------------------------" << endl;
        }

    }


    if (numPessoas >=1)
    {
        cout << "----------------------------------------------------------" << endl;
        cout << "A média de salário da população é de: " << (somaSalario/numPessoas) << " reais." << endl;
        cout << "A média de numero de filhos é de: " << (somaFilhos/numPessoas) << " filhos." << endl;
        cout << "O maior salário é de " << maiorSalario << " reais." << endl;
        cout << "O percentual de pessoas com salario abaixo de 100 reais é de " << ((100/numPessoas)*contMenor100) << "%." <<endl;
        cout << "----------------------------------------------------------" << endl;

        cout << "----------------------------------------------------------" << endl;
        cout << "                 OBRIGADO PELA PESQUISA!!!" << endl;
        cout << "----------------------------------------------------------" << endl;

    }else
    {
        cout << "----------------------------------------------------------" << endl;
        cout << "                   PESQUISA CANCELADA!!!" << endl;
        cout << "----------------------------------------------------------" << endl;
    }






    return 0;
}
