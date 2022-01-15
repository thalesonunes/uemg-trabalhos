#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    /*
    string nome;
    int idade;
    string telefone;

    ofstream arq ("pessoas.txt");

    for (kint i; i<=10; i++)
    {
        cin >> nome;
        cin >> idade;
        cin >> telefone;
        arq << nome << "   " << idade << "   " << telefone << endl;
    }

    arq.close();
    */

    ifstream arq ("dados10pessoas.txt");

    int qtde=0;

    while (arq >> nome >> idade >> telefone)
    {
        if (idade >=18)
        {
            qtde++;
        }
    }

    cout << "Foram cadastradas" << qtde << " maiores de idade";

    arq.close();


    return 0;
}
