#include <iostream>
#include <stdlib.h>
using namespace std;

double delta(double a, double b, double c)
{
    double d;
    d = (b*b)-4*a*c;

    return d;
}

int main()
{
    setlocale(LC_ALL, "portuguese");

    double a=0;
    double b=0;
    double c=0;

    cout << "Digite o valor de A: ";
    cin >> a;
    cout << "Digite o valor de B: ";
    cin >> b;
    cout << "Digite o valor de C: ";
    cin >> c;

    cout << "O resultado é " << delta(a, b, c) << endl;


    return 0;
}
