#include <iostream>
using namespace std;

int main()
{

    int nota[10][5];
    float media=0;
    float medias[5];


    for (int i=0; i<5; i++)
    {
        for(int j=0; j<10; j++)
            {
                cout << "Digite um valor para vetor: ";
                cin >> nota[i][j];
                media = media + nota [i][j];

            }

            medias [i] = media/10;
            media = 0;
    }

    cout << "Medias ";

    for (int k=0; k<5; k++)
    {
        cout << medias[k] << "\t";

    }



    return (0);
}
