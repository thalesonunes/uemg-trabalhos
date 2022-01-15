#include <iostream>
using namespace std;

int fibonacci (int num)
{
    int termo1=0, termo2=1;
    int serie[num];
    double soma=1;

    serie[0]=0;
    serie[1]=1;

    cout << "A série solicitada é: 0 1 ";

    for (int i=2; i<num; i++)
    {

        serie[i] = termo1 + termo2;
        termo1 = termo2;
        termo2 = serie[i];
        cout << serie[i] << " ";

        soma = soma + serie[i];

    }

    cout << endl << "E a soma desses valores é: " << soma << endl;

    return 0;

}

int main()
{
    setlocale(LC_ALL, "portuguese");

    int q=0;

    cout << "Digite a quantidade de elementos da série de FIBONACCI que deseja saber: ";
    cin >> q;

    fibonacci(q);

    return 0;
}



