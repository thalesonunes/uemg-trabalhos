#include <iostream>

using namespace std;

int main ()
{
    setlocale (LC_ALL, "portuguese");

    int idade[4], imaior50=0, ientre10e20=0, pmenor40=0;
    double altura [4], peso[4], media=0, somaAltura10e20=0;

    for (int i=0; i<5; i++)
    {
        cout << "============================" << endl;
        cout << "Digite sua idade: ";
        cin >> idade[i];
        cout << "Digite sua altura: ";
        cin >> altura[i];
        cout << "Digite seu peso: ";
        cin >> peso[i];

        if (idade[i] > 50)
        {
            imaior50 = imaior50 + 1;
        }

        if ((idade[i] > 10) && (idade[i] < 20))
        {
            somaAltura10e20 = somaAltura10e20 + altura[i];
            ientre10e20 = ientre10e20 + 1;
        }

        if ((peso[i] < 40))
        {
            pmenor40 = pmenor40 + 1;
        }

    }


    cout << " " << endl;
    cout << "=======================================" << endl;
    cout << " RELATÓRIO FINAL" << endl;
    cout << "=======================================" << endl;
    cout << "Maior do que 50: " << imaior50 << endl;
    cout << "Media de altura de pessoas entre 10 e 20 anos: " << (somaAltura10e20/ientre10e20) << endl;
    cout << "Porcentagem com peso inferior a 40kg: " << ((100*pmenor40)/5) << endl;
    cout << "---------------------------------------" << endl;
    cout << " " << endl;

    return 0;
}
