#include <iostream>

using namespace std;

int main ()
{
    setlocale (LC_ALL, "portuguese");

    double nota1, nota2, media;
    int aprovado=0, reprovado=0, provafinal=0;

    for (int i=0; i < 6; i++)
    {
        cout << " " << endl;
        cout << "Digite a primeira nota: ";
        cin >> nota1;
        cout << "Digite a segunda nota: ";
        cin >> nota2;

        while (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10)
        {
            cout << "O valor das notas digitadas estão incorretas.";
            cout << " " << endl;
            cout << "Digite a primeira nota: ";
            cin >> nota1;
            cout << "Digite a segunda nota: ";
            cin >> nota2;
        }

        media = ((nota1 + nota2)/ 0.2);

        if (media >= 60)
        {
            cout << "-----------------------" << endl;
            cout << "O aluno foi APROVADO!" << endl;
            aprovado = aprovado + 1;
            cout << "-----------------------" << endl;
            cout << " " << endl;
        }

        if (media >= 40 && media < 60)
        {
            cout << "-----------------------" << endl;
            cout << " O aluno fará PROVA FINAL" << endl;
            provafinal = provafinal + 1;
            cout << "-----------------------" << endl;
            cout << " " << endl;
        }

        if (media < 40)
        {
            cout << "-----------------------" << endl;
            cout << "O aluno foi REPROVADO!" << endl;
            reprovado = reprovado + 1;
            cout << "-----------------------" << endl;
            cout << " " << endl;
        }


    }

    cout << " " << endl;
    cout << "=======================================" << endl;
    cout << " RELATÓRIO FINAL" << endl;
    cout << "=======================================" << endl;
    cout << "APROVADO: " << aprovado << " alunos." << endl;
    cout << "PROVA FINAL: " << provafinal << " alunos." << endl;
    cout << "REPROVADO: " << reprovado << " alunos." << endl;
    cout << "---------------------------------------" << endl;
    cout << " " << endl;

    return 0;
}
