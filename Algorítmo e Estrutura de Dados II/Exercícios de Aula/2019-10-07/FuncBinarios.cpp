#include <iostream>
using namespace std;

void converteBinario(int d)
{
    int binario[100];
    int i=0;

    while (d != 0)
    {
        if(d % 2 == 0)
        {
            d = d/2;
            binario[i] = 1;
            i++;

        }
        else
        {
            d = (d-1)/2;
            binario[i] = 0;
            i++;
        }
    }

    i--;
    cout << "O numero convertido em binario: ";

    for (int j=i; j>0; j--)
    {
        cout << binario [j];
    }

    cout << endl;
}

int main()
{
    int d;
    cout << "Digite um numero: ";
    cin >> d;
    converteBinario (d);
}
