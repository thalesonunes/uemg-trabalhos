#include <iostream>
using namespace std;

float calcVolume (float raio)
{
    float volume, pi = 3.14;
    volume = ((4 * pi * raio*raio*raio)/3);
    return volume;
}

int main()
{
    float raio;
    cout << "Digite o raio da esfera: ";
    cin >> raio;
    cout << "O volume eh: " << calcVolume(raio) << endl;
    return 0;
}
