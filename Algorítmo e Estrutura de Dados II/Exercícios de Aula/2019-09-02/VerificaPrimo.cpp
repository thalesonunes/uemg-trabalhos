#include <iostream>
#include <stdlib.h>
using namespace std;

bool verificaPrimo(int i)
{
    for(int x=2; x<i-1; x++)
    {
        if (i % x == 0)
        {
            return false;
        }
        return true;
    }
}

int main()
{
    setlocale(LC_ALL, "portuguese");

    int n;
    cout << "Digite um numero" << endl;
    cin >> n;
    if (verificaPrimo (n))
    {
        system("CLS");
        cout << "O valor " << n << " � primo" << endl;
    }else
    {
        system("CLS");
        cout << "O valor " << n << " n�o � primo" << endl;
    }

    return 0;
}
