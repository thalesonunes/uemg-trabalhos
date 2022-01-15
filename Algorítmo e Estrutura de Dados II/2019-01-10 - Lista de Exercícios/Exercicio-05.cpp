#include <iostream>

using namespace std;

int main ()
{
    setlocale (LC_ALL, "portuguese");

    char sexo;
    int m=0, f=0;

    for (int i=0; i<8; i++)
    {
        cout << " " << endl;
        cout << "---------------------------------------" << endl;
        cout << "DIGITE SEU SEXO: (M) ou (F): ";
        cin >> sexo;
        cout << "---------------------------------------" << endl;

        while ((sexo != 'F') && (sexo != 'M'))
        {
            cout << "### DADO INCORRETO! Responda novamente! ###" << endl;
            cout << " " << endl;
            cout << "---------------------------------------" << endl;
            cout << "DIGITE SEU SEXO: (M) ou (F): ";
            cin >> sexo;
            cout << "---------------------------------------" << endl;
        }

        if (sexo=='F')
        {
            f = f+1;
        }

        if (sexo=='M')
        {
            m = m+1;
        }
    }

    cout << " " << endl;
    cout << "=======================================" << endl;
    cout << "----------- RELATÓRIO FINAL -----------" << endl;
    cout << "=======================================" << endl;
    cout << "FEMININO: " << f << " pessoas." << endl;
    cout << "MASCULINO: " << m << " pessoas." << endl;
    cout << "---------------------------------------" << endl;
    cout << " " << endl;




    return 0;
}
