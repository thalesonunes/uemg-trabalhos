#include <iostream>

using namespace std;

int main ()
{
    setlocale (LC_ALL, "portuguese");

    int idade, otimo=0, bom=0, regular=0, nota;
    double iO=0, iB=0, iR=0;

    for (int i=0; i < 15; i++)
    {
        cout << "Digite sua idade: ";
        cin >> idade;
        cout << "Qual sua opinião sobre o filme?" << endl;
        cout << "Otimo (3)   Bom (2)   Regular (1)";
        cout << " >> ";
        cin >> nota;
        cout << "-----------------------------------------" << endl;
        cout << " " << endl;

        while ((nota!=3) && (nota!=2) && (nota!=1))
        {
            cout << "-----------------------------------------" << endl;
            cout << "ALGUM DADO DIGITADO INCORRETAMENTE" << endl;
            cout << "Responda novamente as perguntas com ATENÇÃO!" << endl;
            cout << "-----------------------------------------" << endl;
            cout << " " << endl;

            cout << "Digite sua idade: ";
            cin >> idade;
            cout << "Qual sua opinião sobre o filme?" << endl;
            cout << "Otimo (3)   Bom (2)   Regular (1)";
            cout << " >> ";
            cin >> nota;
            cout << "-----------------------------------------" << endl;
            cout << " " << endl;
        }

        if (nota==3)
        {
            otimo = otimo + 1;
            iO = iO + idade;
        }

        if (nota==2)
        {
            bom = bom + 1;
            iB = iB + idade;
        }

        if (nota==1)
        {
            regular = regular + 1;
            iR = iR + idade;
        }
    }

    cout << "A média de idade de quem respondeu ótimo é de: " << (iO/otimo) << " anos." << endl;
    cout << "A quantidade de pessoas qeu responderam regular é: " << regular << " pessoas." << endl;
    cout << "A porcentagem de pessoas que responderam bom é de " << (100*bom)/15 << "% do total." << endl;




    return 0;
}
