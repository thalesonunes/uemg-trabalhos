#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    string origem, destino, dataPartida, hora;

    ofstream arq;
    arq.open("dados.txt", ios::out);

    for (int i=0; i<3; i++)
    {
        cout << endl;
        cout << "ORIGEM: ";
        getline (cin, origem);

        cout << "DESTINO: ";
        getline (cin, destino);

        cout << "DATA PARTIDA: ";
        getline (cin, dataPartida);

        cout << "HORÁRIO: ";
        getline (cin, hora);

        arq << origem << endl << destino << endl << dataPartida << endl << hora << "\n";
    }

    arq.close();
    cout << endl;

    ifstream arq1 ("dados.txt");
    for (int i=0; i<3; i++)
    {
        getline (arq1, origem);
        cout << origem << endl;
        getline (arq1, destino);
        cout << destino << endl;
        getline (arq1, dataPartida);
        cout << dataPartida << endl;
        getline (arq1, hora);
        cout << hora << endl << endl;
    }

    return 0;
}
