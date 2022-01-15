#include <iostream>
using namespace std;


int multiplica(int n1, int n2)
{
    if (n2 == 0)
    {
        return 0;
    }
    else
    {
        return n1 + multiplica (n1, n2-1);
    }
}

int main()
{

    int n1, n2;
    cout << "n1 = ";
    cin >> n1;
    cout << "n2 = ";
    cin >> n2;

    cout << "Resultado: " << multiplica(n1, n2) << endl;

    return 0;
}
