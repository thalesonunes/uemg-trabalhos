#include <iostream>

using namespace std;

int main()

{
     setlocale(LC_ALL,"portuguese");

     int opcao=0, i=1;
     double mediaAritimetica=0, notaAritimetica=0, pesoPonderada=0, notaPonderada=0, notaPonderadaTotal=0;


     cout << "----- MENU DE OPÇÕES -----" << endl;
     cout << endl;
     cout << " 1 - Média Aritimética" << endl;
     cout << " 2 - Média Ponderada" << endl;
     cout << " 3 - Sair" << endl;
     cout << "--------------------------" << endl;
     cout << "Digite a opção desejada: ";
     cin >> opcao;


        if((opcao != 1) && (opcao != 2) && (opcao != 3))
        {
        do{
        cout << endl;
        cout << "----------------------------------" << endl;
        cout << "DADO INCORRETO! Responda novamente" <<endl;
        cout << "----------------------------------" << endl;
        cout << endl;
        cout << "----- MENU DE OPÇÕES -----" << endl;
        cout << endl;
        cout << " 1 - Média Aritimética" << endl;
        cout << " 2 - Média Ponderada" << endl;
        cout << " 3 - Sair" << endl;
        cout << "--------------------------" << endl;
        cout << "Digite a opção desejada: ";
        cin >> opcao;
        }while ((opcao != 1) && (opcao != 2) && (opcao != 3));
        }


    if(opcao == 1)
    {
        for(i=1 ; i <4; i++)
        {
        cout<<endl;
        cout<<"Digite a nota "<<i<<" : ";
        cin>>notaAritimetica;
        mediaAritimetica = mediaAritimetica + notaAritimetica;
        }

        cout<<endl;
        cout << "--------------------------" << endl;
        cout<< "Média Aritimética = "<< (mediaAritimetica/3);
        cout << "--------------------------" << endl;

    }



    if(opcao == 2)
    {
        for(i=1 ; i<3; i++)
        {
        cout<<endl;
        cout<<"Digite a nota "<<i<<" : ";
        cin>>notaPonderada;
        cout<<"Digite o peso "<< i << ", em porcentagem: ";
        cin>>pesoPonderada;
        notaPonderadaTotal = notaPonderadaTotal + (notaPonderada * pesoPonderada);
        }

        cout<<endl;
        cout << "--------------------------" << endl;
        cout<<"A média ponderada = "<< (notaPonderadaTotal/100) << "." << endl;
        cout << "--------------------------" << endl;

    }


        return 0;

}




