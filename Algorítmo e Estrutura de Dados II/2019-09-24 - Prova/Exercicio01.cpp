#include <iostream>
using namespace std;


// DECLARANDO ESTRUTURA
struct dados
{
    int nSala;
    int largura;
    int comprimento;
    int nCarteiras;
    int nLampadas;
    string turma;
};


// CADASTRANDO DADOS
void cadastrando (dados *salas)
{
    for (int i=0; i<30; i++)
    {
        cout << "COD. SALA: ";
        cin >> salas[i].nSala;
        cout << "LARGURA: ";
        cin >> salas[i].largura;
        cout << "COMPRIMENTO: ";
        cin >> salas[i].comprimento;
        cout << "NUM. DE CARTEIRAS: ";
        cin >> salas[i].nCarteiras;
        cout << "NUM. DE LAMPADAS: ";
        cin >> salas[i].nLampadas;
        cout << "TURMA OCUPANTE: ";
        cin >> salas[i].turma;
        cout << endl;
    }
}

// LEITURA DOS DADOS

int busca (dados *salas)
{
    int contador = 0;

    for (int i=0; i<30; i++)
    {
        if (salas[i].nCarteiras > 40)
        {
            contador++;
        }
    }
    return contador;
}

int main()
{
    setlocale(LC_ALL, "portuguese");

    dados salas[50];
    cadastrando (salas);
    cout << "Existem " << busca(salas) << " com mais do que 40 cadeiras." << endl;

    return 0;
}
