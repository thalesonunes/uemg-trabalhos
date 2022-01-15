#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    string nome;
    int idade;
    string telefone;

    ofstream arq;
    arq.open("dados10pessoas.txt", ios::out);

    for (int i=0; i<10; i++)
    {
        cout << "nome: ";
        cin >> nome;
        cout << "idade: ";
        cin >> idade;
        cout << "telefone: ";
        cin >> telefone;
        arq << nome << "   " << idade << "   " << telefone << "\n";
    }

    arq.close();


    return 0;
}
