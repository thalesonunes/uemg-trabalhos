#include <iostream>
#include<fstream>

using namespace std;

int main ()
{
    string nome;
    cout << "Nome completo: ";
    getline (cin, nome);
    int pos=0;

    pos = nome.find(" ");

    while (pos != -1)
    {
        nome = nome.substr(0, pos) + "_" + nome.substr(pos+1);
        pos = nome.find(" ");
    }

    cout << nome;

    return 0;
}
