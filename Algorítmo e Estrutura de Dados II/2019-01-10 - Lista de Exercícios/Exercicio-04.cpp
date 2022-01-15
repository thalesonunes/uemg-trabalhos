#include <iostream>

using namespace std;

int main ()
{
    setlocale (LC_ALL, "portuguese");

    int idade, fx1=0, fx2=0, fx3=0, fx4=0, fx5=0;

    for (int i=0; i<8; i++)
    {
        cout << "Digite a idade: ";
        cin >> idade;

        if (idade <= 15)
        {
            fx1 = fx1 + 1;
        }

        if (idade >= 16 && idade <= 30)
        {
            fx2 = fx2 + 1;
        }

         if (idade >= 31 && idade <= 45)
        {
            fx3 = fx3 + 1;
        }

         if (idade >= 46 && idade <= 60)
        {
            fx4 = fx4 + 1;
        }

         if (idade > 60)
        {
            fx5 = fx5 + 1;
        }

    }

    cout << " " << endl;
    cout << "=======================================" << endl;
    cout << " RELATÓRIO FINAL" << endl;
    cout << "=======================================" << endl;
    cout << "Até 15 anos: " << fx1 << " pessoas." << endl;
    cout << "De 16 a 30 anos: " << fx2 << " pessoas." << endl;
    cout << "De 31 a 45 anos: " << fx3 << " pessoas." << endl;
    cout << "De 46 a 60 anos: " << fx4<< " pessoas." << endl;
    cout << "Acima de 60: " << fx5 << " pessoas." << endl;
    cout << "---------------------------------------" << endl;
    cout << "Até 15 anos são " << ((100*fx1)/8) << "% do total." << endl;
    cout << "Acima de 60 anos são " << ((100*fx5)/8) << "% do total." << endl;
    cout << "---------------------------------------" << endl;
    cout << " " << endl;

    return 0;
}
