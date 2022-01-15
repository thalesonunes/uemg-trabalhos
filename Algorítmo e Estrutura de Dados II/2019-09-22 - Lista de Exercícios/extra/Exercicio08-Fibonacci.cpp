#include <iostream>
using namespace std;



int main()
{
    setlocale(LC_ALL, "portuguese");

    int q=0;
    int termo1=0, termo2=1;

    cout << "Digite a quantidade de elementos da série de FIBONACCI que deseja saber: ";
    cin >> q;

    int serie[q];

    for (int i=2; i<=10; i++)
    {

        serie[i] = termo1 + termo2;
        termo1 = termo2;
        termo2 = serie[i];
    }

    cout << serie[7] << endl;

    return 0;
}



