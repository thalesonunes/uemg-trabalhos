#include <iostream>
#include <fstream>

using namespace std;

int main()
{

    ifstream nome;
    nome.open ("dados.txt");
    int i;

    while (nome >> i)
    {
        if (i % 2 == 0)
        cout << i << endl;
    }

    nome.close();

    return 0;
}
