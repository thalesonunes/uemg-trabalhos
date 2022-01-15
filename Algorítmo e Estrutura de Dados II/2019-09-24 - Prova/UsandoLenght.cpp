#include <iostream>
#include <string>
using namespace std;


int main()
{
    setlocale(LC_ALL, "portuguese");


    string texto = 'BANANA';
    int n;

    n = texto.length();

    cout << "O numero de caracteres é: " << n << endl;

    return 0;
}
