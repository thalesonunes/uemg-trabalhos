#include <iostream>

using namespace std;

int main ()
{
    setlocale (LC_ALL, "portuguese");

    int voto=5, c1=0, c2=0, c3=0, nulo=0, branco=0, totalvotos=0, maisvotado=0;
    string vencedor, nome;

    while (voto!=0) //((voto==1) || (voto==2) || (voto==3) || (voto==4) || (voto==5))
    {
        voto=0;
        cout << " " << endl;
        cout << "----------------------------------" << endl;
        cout << "         PAINEL DE VOTAÇÃO" << endl;
        cout << "----------------------------------" << endl;
        cout << " cod. 1 - JOÃO" << endl;
        cout << " cod. 2 - MARIA" << endl;
        cout << " cod. 3 - JOSÉ" << endl;
        cout << " cod. 4 - NULO" << endl;
        cout << " cod. 5 - BRANCO" << endl;
        cout << "----------------------------------" << endl;
        cout << "Digite seu voto: ";
        cin >> voto;

        while ((voto < 0) || (voto > 5))
        {
            cout << "----------------------------------" << endl;
            cout << "VOTO INVÁLIDO! Vote novamente!" << endl;
            cout << "----------------------------------" << endl;
            cout << " " << endl;
            cout << "Digite seu voto: ";
            cin >> voto;
        }

        if (voto==1)
        {
            c1 = c1+1;
        }

        if (voto==2)
        {
            c2 = c2+1;
        }

        if (voto==3)
        {
            c3 = c3+1;
        }

        if (voto==4)
        {
            nulo = nulo+1;
        }

        if (voto==5)
        {
            branco = branco+1;
        }

    }

    if ((c1>c2) && (c1>c3))
    {
        vencedor = "1";
        nome = "JOÃO";
        maisvotado = c1;
    }

    if ((c2>c1) && (c2>c3))
    {
        vencedor = "2";
        nome = "MARIA";
        maisvotado = c2;
    }

    if ((c3>c1) && (c3>c2))
    {
        vencedor = "3";
        nome = "JOSÉ";
        maisvotado = c3;
    }

    totalvotos = c1+c2+c3;

    if ((c1!=c2) && (c2!=c3) && (c1!=c3))
    {
        cout << " " << endl;
        cout << " " << endl;
        cout << "----------------------------------" << endl;
        cout << "JOÃO: " << c1 << " votos" << endl;
        cout << "MARIA: " << c2 << " votos" << endl;
        cout << "JOSÉ: " << c3 << " votos" << endl;
        cout << "NULO: " << nulo << " votos" << endl;
        cout << "BRANCO: " << branco << " votos" << endl;
        cout << "----------------------------------" << endl;
        cout << "O cogido do vencedor é " << vencedor << "." << endl;
        cout << nome << " foi eleito!" << endl;
        cout << "----------------------------------" << endl;
        cout << " " << endl;
    }else
    {
        cout << " " << endl;
        cout << " " << endl;
        cout << "----------------------------------" << endl;
        cout << "JOÃO: " << c1 << " votos" << endl;
        cout << "MARIA: " << c2 << " votos" << endl;
        cout << "JOSÉ: " << c3 << " votos" << endl;
        cout << "NULO: " << nulo << " votos" << endl;
        cout << "BRANCO: " << branco << " votos" << endl;
        cout << "----------------------------------" << endl;
        cout << "ELEIÇÕES SEM VENCEDOR" << endl;
    }




    return 0;
}
