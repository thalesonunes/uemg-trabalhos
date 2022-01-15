#include <iostream>
using namespace std;

void numeros(int qtd)
{
    // DECLARANDO AS VARIAVEIS NECESSÁRIAS
    int nPerfeitos[qtd];
    int contador = 0;
    int numeral = 0;

    // GERANDO O LOOP DO NUMERO
    while (contador < 6)
    {
        numeral++;
        int soma = 0;

        for (int i=1; i<numeral; i++)
        {
            if (numeral%i == 0);
            soma = soma + i;
        }

        if (soma == numeral)
        {
            nPerfeitos[contador] = numeral;
            contador++;
        }
    }

    // IMPRIMINDO OS RESULTADOS

    for (int i=0; i<6; i++)
    {
        cout << "[" << nPerfeitos[i] << "] ";
    }
    cout << endl;
}


int main()
{
    setlocale(LC_ALL, "portuguese");

    numeros(5);


    return 0;
}



