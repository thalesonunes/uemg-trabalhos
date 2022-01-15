#include <iostream>
using namespace std;

int celsius (int fahr)
{
    int c;
    c = (fahr - 32) * 5 / 9;
    return c;
}

int main()
{
    int c, f;
    cout << "Digite a temperatura em graus Fahrenheit: ";
    cin >> f;
    c = celsius(f);
    cout << "Celsius: " << c << endl;
    return 0;
}
