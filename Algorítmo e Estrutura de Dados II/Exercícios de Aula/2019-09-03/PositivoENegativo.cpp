#include <iostream>
#include <stdlib.h>
using namespace std;

int verPosNeg(int num)
{
    if(num > 0)
    {
        return true;
    }

    return false;

}

int main()
{
    setlocale(LC_ALL, "portuguese");

    int num;
    bool resultado;

    cout << "Digite um numero" << endl;
    cin >> num;

    if(verPosNeg(num))
    {
        cout << "O numero é POSITIVO!" << endl;
    }else
    {
        cout << "O numero é NEGATIVO!" << endl;
    }
    return 0;
}
