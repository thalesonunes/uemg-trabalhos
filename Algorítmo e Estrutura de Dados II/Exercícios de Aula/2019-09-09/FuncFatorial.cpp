#include <iostream>
#include <stdlib.h>
using namespace std;

int fat(int num)
{
    int f=1;
    for(int i=num; i>=1; i--)
        f = f*i;
    return f;

}

int main()
{
    setlocale(LC_ALL, "portuguese");

    int numero = 0;
    cout << "Digite um numero" << endl;
    cin >> numero;

    cout << "O fatorial do numero é " << fat(numero) << endl;


    return 0;
}
