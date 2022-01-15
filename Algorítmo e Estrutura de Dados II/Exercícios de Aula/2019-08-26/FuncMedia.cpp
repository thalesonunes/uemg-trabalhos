#include <iostream>
using namespace std;

float FuncMedia (float num1, float num2, float num3, char tipo)
{
    float media;

    if ((tipo == 'a') || (tipo == 'A'))
    {
        media = (num1 + num2 + num3)/3;
    }

    if ((tipo == 'p') || (tipo == 'P'))
    {
        media = (((num1 * 5) + (num2 * 3) + (num3 * 2))/10);
    }

    if ((tipo != 'a') && (tipo != 'A') && (tipo != 'p') && (tipo != 'P'))
    {
        cout << "Media escolhida nao confere";
    }

    return media;

}

int main()
{
    float nota1=0, nota2, nota3;
    char tipoMedia;

    cout << "Digite primeira nota: ";
    cin >> nota1;
    cout << "Digite primeira nota: ";
    cin >> nota2;
    cout << "Digite primeira nota: ";
    cin >> nota3;

    cout << "Digite A para media aritmetica ou P: ";
    cin >> tipoMedia;

    cout << "A media eh: " << FuncMedia (nota1, nota2, nota3, tipoMedia) << endl;


    return 0;
}
