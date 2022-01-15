#include <iostream>
using namespace std;

int MDC(int a, int b)
{
    int aux;

    while (a%b != 0)
    {
        aux = a%2;
        a = b;
        b = aux;
    }

    return b;
}

int MDCRec(int a, int b)
{
    int aux;

    if(a%b != 0)
    {
        return MDCRec (b, a%b);
    }
    else{
        return b;
    }

    return b;
}

int main()
{
    int a, b;
    cin >> a >> b;
    cout << "MDC = " << MDC (a,b) << endl;

    cout << "MDC = " << MDCRec (a,b) << endl;


    return 0;
}
