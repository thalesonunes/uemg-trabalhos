#include <iostream>
using namespace std;




string codifica (string texto)
{

}

int main()
{
    setlocale(LC_ALL, "portuguese");

    // DANDO CÓDIGOS AS LETRAS

    string letras[26];
    letras[0] = 'A';
    letras[1] = 'B';
    letras[2] = 'C';
    letras[3] = 'D';
    letras[4] = 'E';
    letras[5] = 'F';
    letras[6] = 'G';
    letras[7] = 'H';
    letras[8] = 'I';
    letras[9] = 'J';
    letras[10] = 'K';
    letras[11] = 'L';
    letras[12] = 'M';
    letras[13] = 'N';
    letras[14] = 'O';
    letras[15] = 'P';
    letras[16] = 'Q';
    letras[17] = 'R';
    letras[18] = 'S';
    letras[19] = 'T';
    letras[20] = 'U';
    letras[21] = 'V';
    letras[22] = 'W';
    letras[23] = 'X';
    letras[24] = 'Y';
    letras[25] = 'Z';

    int numeros;
    char nome;
    nome = 'A';
    numeros = nome;
    numeros = numeros + 5;
    nome = numeros;
    cout << nome;

    return 0;
}
