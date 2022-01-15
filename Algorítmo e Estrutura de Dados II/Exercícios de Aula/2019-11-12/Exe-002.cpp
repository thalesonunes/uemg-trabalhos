#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "portuguese");

    string cidade;
    int pop;


    // ESCRITA

    ofstream arq;
    arq.open("cidades.txt", ios::out);

    for (int i=0; i<5; i++)
    {
        cout << "CIDADE: ";
        getline (cin, cidade);

        cout << "POPULAÇÃO: ";
        cin >> pop;

        arq << cidade << endl;
        arq << pop << endl;
    }

    cout << endl;
    arq.close();



    // LEITURA

    ifstream arq1 ("cidades.txt");

    string cidadeMaior;
    string cidadeMenor;
    int popMenor;
    int popMaior;

    for (int i=0; i<5; i++)
    {
        getline (arq1, cidade);
        arq1 >> pop;

        if( i == 0)
        {
            cidadeMaior = cidadeMenor = cidade;
            popMaior = popMenor = pop;
        }
        else{
            if(pop > popMaior)
            {
                popMaior = pop;
                cidadeMaior = cidade;
            }

            if (pop < popMenor)
            {
                popMenor = pop;
                cidadeMenor = cidade;
            }
            }
    }

    cout << "A cidade menor é " << cidadeMenor << endl;
    cout << "A cidade maior é " << cidadeMaior << endl;

    arq1.close();

    return 0;
}
