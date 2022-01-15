#include <iostream>
using namespace std;

int main()
{
    float matriz[3][6];
    float soma=0;

    for (int i=0; i<3; i++)
    {
        for(int j=0; j<6; j++)
        {
            cout << "Valor ["<< i << "]["<<j<<"] : ";
            cin >> matriz[i][j];
        }
    }

    for (int i=0; i<3; i++)
    {
        soma += matriz[i][1] + matriz[i][3] + matriz[i][5];
    }

    cout << "==========================================" << endl;
    cout << "o valor da soma das colunas impares e " << soma << endl;
    cout << "==========================================" << endl;

    for (int i=0; i<3; i++)
    {
        soma += matriz[i][1] + matriz[i][3];
    }

    cout << "A media aritmetica e " << soma/6 << endl;
    cout << "==========================================" << endl;



    for (int i=0; i<3; i++)
    {
        soma += matriz[i][1] + matriz[i][2];
        matriz[i][5] = soma;
    }

    for (int i=0; i<3; i++)
    {
        cout << endl;
        for(int j=0; j<6; j++)
        {
            cout << "["<< matriz[i][j] << "] ";

        }
    }




    return (0);
}
