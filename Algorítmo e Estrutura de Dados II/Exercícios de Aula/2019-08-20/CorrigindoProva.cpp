#include <iostream>
using namespace std;

int main()
{
    char notas[3][6];
    float gabarito[3][6];


    for (int i=0; i<3; i++)
    {
        cout << endl;
        cout << "Aluno 0" << i+1 << endl;
        for(int j=0; j<6; j++)
        {
            cout << "Resp. Quest. 0" << j+1 << ": ";
            cin >> notas[i][j];
        }
    }

    for (int i=0; i<3; i++)
    {
        cout << endl;
        cout << "A" << i+1 <<" ";
        for(int j=0; j<6; j++)
        {
        cout << "["<< notas[i][j] << "] ";

        }
    }



    return (0);
}
