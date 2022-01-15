#include <iostream>
#include <stdlib.h>
#include <locale>

using namespace std;

void novoNome(string &nome)
{
    setlocale(LC_ALL, "portuguese");
    cout << "Digite o nome para substiruir " << nome << ": ";
    cin >> nome;


}

int main()
{
    setlocale(LC_ALL, "portuguese");

    string n;

    cout << "Digite seu nome: ";
    cin >> n;
    cout << " O nome lido foi " << n << endl;
    novoNome(n);
    cout << "O novo nome será " << n;


    return 0;
}
