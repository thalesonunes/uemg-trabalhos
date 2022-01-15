#include <iostream>
#include <fstream>

using namespace std;

int main()
{

    ofstream nome;
    nome.open("dados.txt", ios::out);

    for(int i=1; i<=100; i++)
    {
        nome << i << "\n";
    }

    nome.close();

    return 0;
}
