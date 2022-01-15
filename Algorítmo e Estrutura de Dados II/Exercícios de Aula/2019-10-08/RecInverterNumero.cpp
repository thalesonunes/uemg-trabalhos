#include <iostream>
using namespace std;


void inverte(int n)
{
    if (n/10 == 0)
    {
        cout << n;
    }
    else
    {
        cout << n%10;
        inverte (n/10);
    }
}

int main()
{

    int n;
    cout << "Digite o numero: ";
    cin >> n;

    inverte(n);

    return 0;
}
