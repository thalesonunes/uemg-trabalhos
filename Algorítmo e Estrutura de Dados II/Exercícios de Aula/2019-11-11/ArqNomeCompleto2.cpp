#include <iostream>
#include<fstream>

using namespace std;

int main ()
{
    string nome;
    cout << "Nome completo: ";
    getline (cin, nome);
    int pos=0;

    pos = nome.find(" ");
    while (pos != -1)
    {
        nome = nome.substr(0, pos) + "_" + nome.substr(pos+1);
        pos = nome.find(" ");
    }

    string curso;
    cout << "Digite seu curso: ";
    cin >> curso;


    pos=0;
    pos = curso.find(" ");
    while (pos != -1)
    {
        curso = nome.substr(0, pos) + "_" + curso.substr(pos+1);
        pos = curso.find(" ");
    }



    // ESCRITA

    ofstream arq ("nomecompleto.txt", ios::app);
    arq << nome << " " << curso;
    arq.close();

    // LEITURA

    ifstream arq1 ("nomecompleto.txt");

    while (arq1 >> nome >> curso)
    {
        pos = nome.find("_"); // LOCALIZA O TEXTO
        while (pos != -1)
        {
            nome = nome.substr(0, pos) + " " + nome.substr(pos+1); // COPIA PARTE DA STRING
            pos = nome.find("_");
        }

        cout << "Nome: " << nome;
        cout << " Curso: " << curso << endl;
    }

    return 0;
}
