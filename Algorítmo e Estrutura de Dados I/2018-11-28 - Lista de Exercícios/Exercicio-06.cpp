#include <iostream>

using namespace std;

int main ()
{
    setlocale (LC_ALL, "portuguese");

    int i, time, nJogadores;
    double altura, media=0;

    cout << "Digite a quantidade de jogadores do time: ";
    cin >> time;
    cout << "-------------------------------------------" << endl;
    cout << " " << endl;

    for (i=0; i<time; i++)
    {
        cout << "Digite a altura em metros: ";
        cin >> altura;
        media = media + altura;
    }

    cout << "-------------------------------------------" << endl;
    cout << " " << endl;
    media = (media/time);
    cout << "A média de altura do time é " << media << " metros" << endl;
    cout << "-------------------------------------------" << endl;


    return 0;
}
