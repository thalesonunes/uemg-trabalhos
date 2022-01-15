#include <iostream>
using namespace std;

// ESTRUTURA DO CADASTRO
struct gastos
{
    string empresa;
    int data;
    double valor;

};

// VARIAVEIS GLOBAIS
gastos srKin [6];
double totalGasto=0;
double limite = 2700;


// CADASTRANDO VALORES
void cadastrando (gastos *srKin, double *totalGasto, double *limite)
{
    for (int i=0; i<6; i++)
    {
        cout << "Digite o nome da empresa: ";
        cin >> srKin[i].empresa;
        cout << "Digite o dia do mês compra: ";
        cin >> srKin[i].data;
        cout << "Digite o valor da compra: ";
        cin >> srKin[i].valor;

        totalGasto = (totalGasto + srKin[i].valor);

        cout << "Você ainda tem " << limite - totalGasto << " de crédito.";

        if (totalGasto > 2700)
        {
            cout << "Você estourou o limite e não pode mais comprar." << endl;
            i = 6;
        }
    }
}


// TOTAL DE GASTO
void gastoTotal(gastos *srKin, double *totalGasto)
{
    for (int i=0; i<6; i++)
    {
        totalGasto = totalGasto + srKin[i].gastos;
    }
}


// PRIMEIRA COMPRA
void primeira (gastos *srKin)
{
    int data = 32;

    for (int i=0; i<6; i++)
    {
        if(srKin[i].data < data)
            data = srKin[i].data;
    }

    cout << "A primeira compra foi feita dia " << data << endl;
}


// EMPRESA DA ULTIMA COMPRA
void empresa (gastos *srKin)
{
    int data = 0;
    string empresa;

    for (int i=0; i<6; i++)
    {
        if(srKin[i].data > data)
            empresa = srKin[i].empresa;
    }

    cout << "O nome da ultima empresa é " << empresa << endl;
}

int main ()
{
    //CHAMANDO FUNÇÕES
    cadastrando (gastos srKin);
    gastoTotal (gastos srKin, totalGasto);
    primeira (gastos srKin);
    empresa (gastos srKin);
}
