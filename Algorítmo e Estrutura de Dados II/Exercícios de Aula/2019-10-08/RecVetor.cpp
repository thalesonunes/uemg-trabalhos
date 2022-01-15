#include <iostream>
using namespace std;


int soma(int v[], int n)
{
    if (n == 0)
    {
        return 0;
    }
    else
    {
        return v[n-1]+ soma(v, n-1);
    }

}

int main()
{

    int vetor[5];

    for (int i=0; i<5; i++)
    {
        cout << "Digite o numero [" << i+1 << "]: ";
        cin >> vetor[i];
    }
    cout << "Soma igual a: " << soma (vetor, 5);

    return 0;
}
