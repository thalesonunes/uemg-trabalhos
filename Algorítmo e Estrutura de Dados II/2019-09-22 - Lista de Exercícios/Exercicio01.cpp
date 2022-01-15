#include <iostream>
using namespace std;

int potencia(int num1, int num2)
{
    if (num1 == 0)
    {
        return 0;
    }

    if (num2 == 0)
    {
        return 1;
    }

    int resultado = num1;
    for (int i=1; i < num2; i++)
    {
        resultado = resultado * num1;
    }

    return resultado;
}

int main()
{
    int num1, num2;
    cout << "Digite um valor: ";
    cin >> num1;
    cout << "Digite sua potencia: ";
    cin >> num2;

    cout << "O resultado sera: " << potencia(num1, num2) << endl;

    return 0;
}
