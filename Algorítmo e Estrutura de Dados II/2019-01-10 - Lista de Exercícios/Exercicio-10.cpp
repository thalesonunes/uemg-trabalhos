#include <iostream>

using namespace std;

int main ()
{
    setlocale (LC_ALL, "portuguese");

    double valor=0, juros=0;
    int parcelas=0;

    cout << "Digite o valor do carro a ser fincanciado: ";
    cin >> valor;

    while ((parcelas!=1) && (parcelas!=2) && (parcelas!=6) && (parcelas!=12) && (parcelas!=24))
    {
        cout << "===============================================" << endl;
        cout << "|          FORMAS DE FINANCIAMENTO:           |" << endl;
        cout << "===============================================" << endl;
        cout << "|     1 parcela  ->  5% de desconto           |" << endl;
        cout << "|     2 parcelas ->  mesmo valor              |" << endl;
        cout << "|     6 parcelas ->  acréscimo de 10%         |" << endl;
        cout << "|    12 parcelas ->  acréscimo de 20%         |" << endl;
        cout << "|    24 parcelas ->  acréscimo de 40%         |" << endl;
        cout << "===============================================" << endl;
        cout << "        De acordo com a tabela acima,          " << endl;
        cout << "   em quantas parcelas deseja financiar?       " << endl;
        cout << "             >> ";
        cin >> parcelas;
    }

    if (parcelas=1)
    {
        juros = 0.95;
    }

        if (parcelas=2)
    {
        juros = 1;
    }

        if (parcelas=10)
    {
        juros = 1.1;
    }

        if (parcelas=20)
    {
        juros = 1.2;
    }

        if (parcelas=24)
    {
        juros = 1.4;
    }

    cout << "======================================================" << endl;
    cout << "O valor final do seu financiamento será de R$ " << (valor*juros) << "." << endl;
    cout << "Pagos em " << parcelas << " parcelas de R$ " << ((valor*juros)/parcelas) << "." << endl;
    cout << "======================================================" << endl;











    return 0;
}
