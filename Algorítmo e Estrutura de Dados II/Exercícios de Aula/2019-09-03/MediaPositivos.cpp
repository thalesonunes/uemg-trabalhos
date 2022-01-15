#include <iostream>
#include <stdlib.h>
using namespace std;

int positivo(int num)
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

    int num = 1;
    int media=0;
    int contador=0;

    while(num > 0)
    {
        cout << "Digite um numero POSITIVO para fazer média ou NGEATIVO pra encerrar." << endl;
        cin >> num;

        if(positivo(num))
        {
            media = media + num;
            contador = contador + 1;
        }
    }

    cout << (media/contador) << endl;

    return 0;
}
