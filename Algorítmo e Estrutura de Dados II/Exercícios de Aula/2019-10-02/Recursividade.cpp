#include <iostream>
#include <locale>
using namespace std;

int fat(int x)
{
    if(x == 0)
    {
        return 1;
    }
    else
    {
        return x * fat (x-1);
    }

}


int main ()
{
    int n;
    cout << "Digite um valor pra calcular o fatorial: ";
    cin >> n;
    cout << "Fatorial = "<< fat(n) << endl;

    /* SE FOR USAR OCMANDO DE REPETIÇÃO */

    int f=1;
    for (int i=1; i<=n; i++)
    {
        f = f * i;
    }

    cout << "Fatorial = "<< f;

    return 0;
}
