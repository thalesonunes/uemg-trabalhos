#include <iostream>
#include <stdlib.h>
using namespace std;

void incremento(int X, int &Y)
{
    Y = Y + X;

}

int main()
{
    setlocale(LC_ALL, "portuguese");

    int a, b;
    cout << "Digite o valor de A: ";
    cin >> a;
    cout << "Digite o valor de B (incremento): ";
    cin >> b;

    incremento(b, a);

    cout << "O valor de B é " << a << endl;

    return 0;
}
