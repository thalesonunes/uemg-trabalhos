#include <iostream>

using namespace std;

int main ()
{
    setlocale (LC_ALL, "portuguese");

    double valor=0, totalV=0, totalP=0, total=0, contP=0, primeiraCompra;
    char tipo;


    for (int i=0; i <15; i++)
    {
        cout << "===============================" << endl;
        cout << "SELECIONE A OP��O DE VENDA" << endl;
        cout << "(v) a vista   (p) a prazo >> ";
        cin >> tipo;

        while ((tipo!='v') && (tipo!='p'))
        {
            cout << "ALTERNATIVA DIGITADA ERRADA" << endl;
            cout << "Responda novamente" << endl;
            cout << "===============================" << endl;
            cout << "SELECIONE A OP��O DE VENDA" << endl;
            cout << "(v) a vista   (p) a prazo >> ";
            cin >> tipo;
        }

        cout << "-------------------------------" << endl;
        cout << "Digite o valor da compra: ";
        cin >> valor;
        cout << "-------------------------------" << endl;
        cout << " " << endl;


        if (tipo=='v')
        {
            totalV = totalV + valor;

        }

        if (tipo=='p')
        {
            totalP = totalP + valor;

            if (contP < 1)
            {
                primeiraCompra = valor;
                contP = contP + 1;
            }
        }

        total = total + valor;

    }

    cout << " " << endl;
    cout << "=======================================" << endl;
    cout << " RELAT�RIO FINAL" << endl;
    cout << "=======================================" << endl;
    cout << "O valor total das compras a vista �: " << totalV << endl;
    cout << "O valor total das compras a prazo �: " << totalP << endl;
    cout << "O valor total das compras �: " << total << endl;
    cout << "O valor da primeira compra a prazo �: " << primeiraCompra << endl;
    cout << "---------------------------------------" << endl;
    cout << " " << endl;


    return 0;
}
