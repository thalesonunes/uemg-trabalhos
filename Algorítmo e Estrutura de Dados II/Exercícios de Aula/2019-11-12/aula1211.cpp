#include <fstream>
#include <iostream>
#include <iomanip>

using namespace std;


int main ()

{

 setlocale(LC_ALL,"portuguese");

    ofstream arq;
    arq.open ("viagem.txt", ios::out);

    for (int i=1; i<4; i++)
    {


        string origem;
        cout<<"Digite a origem: ";
        getline(cin, origem);
        int pos=0;
        //não pode ter espaço em branco
        pos = origem.find(" ");
        while (pos !=-1)
        {
        origem = origem.substr (0, pos) + "_" + origem.substr(pos+1);
        pos = origem.find (" ");
        }


        string destino;
        cout<<"Digite o destino: ";
        getline(cin, destino);
        pos=0;
        //não pode ter espaço em branco
        pos = destino.find(" ");
        while (pos !=-1)
        {
        destino = destino.substr (0, pos) + "_" + destino.substr(pos+1);
        pos = destino.find (" ");
        }


        string partida;
        cout<<"Digite a data da partida: ";
        getline(cin, partida);
        pos=0;
        //não pode ter espaço em branco
        pos = partida.find(" ");
        while (pos !=-1)
        {
        partida = partida.substr (0, pos) + "_" + partida.substr(pos+1);
        pos = partida.find (" ");
        }


        string hora;
        cout<<"Digite o horário: ";
        getline(cin, hora);
        pos=0;
        //não pode ter espaço em branco
        pos = hora.find(" ");
        while (pos !=-1)
        {
        hora = hora.substr (0, pos) + "_" + hora.substr(pos+1);
        pos = hora.find (" ");
        }


        arq<<origem<<endl;
        arq<<destino<<endl;
        arq<<partida<<endl;
        arq<<hora<<endl;
    }

    arq.close();
    return 0;
}
