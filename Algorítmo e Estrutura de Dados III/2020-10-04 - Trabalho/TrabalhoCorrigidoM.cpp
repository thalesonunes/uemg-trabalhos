#include <iostream>
#include <queue>
#include <stdlib.h>

using namespace std;


struct endereco
{
	string cep;
	string rua;
	int numero;
	string cidade;
};


struct pessoa
{
	string nome;
	endereco remetente;
	string nomedest;
	endereco destino;
};

//FUN��O IMPRIMIR O PROXIMO DA FILA
void imprimirproximo(queue<pessoa>fila)
{
		cout << "NOME DO USU�RIO: ";
		cout << fila.front().nome<< endl;

		cout<<"ENDERE�O DO USU�RIO"<<endl;
		cout<<"CEP: ";
		cout<<fila.front().remetente.cep<<endl;
		cout<<"RUA: ";
		cout<<fila.front().remetente.rua<<endl;
        cout<<"N�MERO: ";
        cout<<fila.front().remetente.numero<<endl;
        cout<<"CIDADE: ";
        cout<<fila.front().remetente.cidade<<endl;

        cout<<endl;
		cout << "NOME DO DESTINAT�RIO: ";
		cout << fila.front().nomedest<< endl;

		cout<<"ENDERE�O DO DESTINAT�RIO"<<endl;
		cout<<"CEP: ";
		cout<<fila.front().destino.cep<<endl;
		cout<<"RUA: ";
		cout<<fila.front().destino.rua<<endl;
        cout<<"N�MERO: ";
        cout<<fila.front().destino.numero<<endl;
        cout<<"CIDADE: ";
        cout<<fila.front().destino.cidade<<endl;
}

//FUN��O IMPRIMIR FILAS
void imprimir(queue<pessoa>fila)
{
	while(fila.size() > 0)
	{
		cout << "NOME DO USU�RIO: ";
		cout << fila.front().nome <<endl;

		cout<<"ENDERE�O DO USU�RIO"<<endl;
		cout<<"CEP: ";
		cout<<fila.front().remetente.cep<<endl;
		cout<<"RUA: ";
		cout<<fila.front().remetente.rua<<endl;
        cout<<"N�MERO: ";
        cout<<fila.front().remetente.numero<<endl;
        cout<<"CIDADE: ";
        cout<<fila.front().remetente.cidade<<endl;

        cout<<endl;
		cout << "NOME DO DESTINAT�RIO: ";
		cout << fila.front().nomedest <<endl;

		cout<<"ENDERE�O DO DESTINAT�RIO"<<endl;
		cout<<"CEP: ";
		cout<<fila.front().destino.cep<<endl;
		cout<<"RUA: ";
		cout<<fila.front().destino.rua<<endl;
        cout<<"N�MERO: ";
        cout<<fila.front().destino.numero<<endl;
        cout<<"CIDADE: ";
        cout<<fila.front().destino.cidade<<endl;
		cout<<"---------------------------------------------------------------"<<endl;
	
		fila.pop();
	}

}




int main()
{
	setlocale(LC_ALL, "portuguese");

	//CRIANDO AS FILAS
	queue<pessoa> filaPac;
	queue<pessoa> filaSedex;


	int op;

	do
	{
		//MENU GERAL
		system("cls");
		cout << "***************************************************************" << endl;
		cout << "****************** DIGITE A OP��O DESEJADA ********************" << endl;
		cout << "***************************************************************" << endl;
		cout << "1 - ADICIONAR PESSOA NA FILA " << endl;
		cout << "2 - CHAMAR O PR�XIMO DA FILA" << endl;
		cout << "3 - MOSTRAR FILAS PAC E SEDEX" << endl;
		cout << "0 - PARA SAIR" << endl;
		cout << "***************************************************************" << endl;
		cout << endl;
		cin >> op;

		switch(op)
		{
		case 1://ADICIONANDO PESSOAS NA FILA
		{
			int servico;
			cout << "***************************************************************" << endl;
			cout << "                   QUAL O SERVI�O DESEJADO?"                     << endl;
			cout << "                       [1]PAC  [2]SEDEX"                         << endl;
			cout << "***************************************************************" << endl;
			cout << endl;
			cin  >> servico;

			if(servico == 1)
			{
				pessoa p1;
				int contpac = 0;

				cout << endl;
				cout << "NOME DO USU�RIO: " << endl;
				cin.ignore();
				getline(cin, p1.nome);

				cout << "ENDERE�O DO USU�RIO"<<endl;
				cout << "DIGITE O CEP: " << endl;
                getline(cin, p1.remetente.cep);
                cout << "DIGITE A RUA: " << endl;
                getline(cin, p1.remetente.rua);
                cout << "DIGITE O N�MERO DA RESID�NCIA: " << endl;
                cin >> p1.remetente.numero;
                cout << "DIGITE A CIDADE: " << endl;
                cin.ignore();
                getline(cin, p1.remetente.cidade);
                cout << "-------------------------------"<<endl;

				cout << "NOME DO DESTINAT�RIO: " << endl;
				getline(cin, p1.nomedest);

                cout << "ENDERE�O DO DESTINAT�RIO"<<endl;
				cout << "DIGITE O CEP: " << endl;
                getline(cin, p1.destino.cep);
                cout << "DIGITE A RUA: " << endl;
                getline(cin, p1.destino.rua);
                cout << "DIGITE O N�MERO DA RESID�NCIA: " << endl;
                cin >> p1.destino.numero;
                cout << "DIGITE A CIDADE: " << endl;
                cin.ignore();
                getline(cin, p1.destino.cidade);
                cout << "-------------------------------"<<endl;

				filaPac.push(p1);
				contpac = 1;
				
				
					if(contpac >=1)
						{
						cout<<endl;
						cout<< "********* USU�RIO ADICIONADO � FILA PAC COM SUCESSO! **********"<<endl;
						cout<<endl;	
						}
      
						else if (contpac == 0)
						{
						cout<<endl;
						cout<< "************* USU�RIO N�O ADICIONADO � FILA PAC! *************"<<endl;
						cout<<endl;

						}

			}
			else if(servico == 2)
			{
				pessoa p1;
				int contsedex = 0;

				cout << endl;
				cout << "NOME DO USU�RIO: " << endl;
				cin.ignore();
				getline(cin, p1.nome);

				cout << "ENDERE�O DO USU�RIO"<<endl;
				cout << "DIGITE O CEP: " << endl;
                getline(cin, p1.remetente.cep);
                cout << "DIGITE A RUA: " << endl;
                getline(cin, p1.remetente.rua);
                cout << "DIGITE O N�MERO DA RESID�NCIA: " << endl;
                cin >> p1.remetente.numero;
                cout << "DIGITE A CIDADE: " << endl;
                cin.ignore();
                getline(cin, p1.remetente.cidade);
                cout << "-------------------------------"<<endl;

				cout << "NOME DO DESTINAT�RIO: " << endl;
				getline(cin, p1.nomedest);

                cout << "ENDERE�O DO DESTINAT�RIO"<<endl;
				cout << "DIGITE O CEP: " << endl;
                getline(cin, p1.destino.cep);
                cout << "DIGITE A RUA: " << endl;
                getline(cin, p1.destino.rua);
                cout << "DIGITE O N�MERO DA RESID�NCIA: " << endl;
                cin >> p1.destino.numero;
                cout << "DIGITE A CIDADE: " << endl;
                cin.ignore();
                getline(cin, p1.destino.cidade);
                cout << "-------------------------------"<<endl;

				filaSedex.push(p1);
				contsedex = 1;
				
				
				if(contsedex >=1)
						{
						cout<<endl;
						cout<< "******** USU�RIO ADICIONADO � FILA SEDEX COM SUCESSO! *********"<<endl;
						cout<<endl;	
						}
      
						else if (contsedex == 0)
						{
						cout<<endl;
						cout<< "************ USU�RIO N�O ADICIONADO � FILA SEDEX! ************"<<endl;
						cout<<endl;

						}

			}
			else
			{
			cout << "*************** OP��O INV�LIDA *************" << endl;
			}

		}
		break;


		case 2://CHAMAR O PR�XIMO DA FILA, INDICANDO A FILA CORRESPONDENTE
		{
			int qualfila;
			cout << "***************************************************************" << endl;
			cout << "                    QUAL FILA DESEJA CHAMAR?"                    << endl;
			cout << "                       [1]PAC  [2]SEDEX"                         << endl;
			cout << "***************************************************************" << endl;
			cout << endl;
			cin >> qualfila;

			if(qualfila == 1)
			{
				cout << endl;
				cout << "***************************************************************" << endl;
				cout << "                           ATENDIMENTO"                          << endl;
				cout << "                            FILA PAC"                            << endl;
    			cout << "***************************************************************" << endl;
                cout<<endl;
				imprimirproximo(filaPac);
				cout << endl;
				cout << endl;
				cout << "***************************************************************" << endl;
				cout << "                     PR�XIMOS ATENDIMENTOS"                      << endl;
				cout << "                            FILA PAC"                            << endl;
    			cout << "***************************************************************" << endl;
                cout<<endl;
				filaPac.pop();
				imprimir(filaPac);

			}
			else if(qualfila == 2)
			{
				cout << endl;
				cout << "***************************************************************" << endl;
				cout << "                           ATENDIMENTO"                          << endl;
				cout << "                           FILA SEDEX"                           << endl;
    			cout << "***************************************************************" << endl;
                cout<<endl;
				imprimirproximo(filaSedex);
				cout << endl;
				cout << endl;
				cout << "***************************************************************" << endl;
				cout << "                     PR�XIMOS ATENDIMENTOS"                      << endl;
				cout << "                          FILA SEDEX"                            << endl;
    			cout << "***************************************************************" << endl;
                cout<<endl;
				filaSedex.pop();
				imprimir(filaSedex);

			}
			else
			{
			cout << "*************** OP��O INV�LIDA *************" << endl;
			}

		}

		break;


		case 3://MOSTRAR AS FILAS
		{
			//IMPRIMINDO AS FILAS, CHAMANDO FUN��O

			//IMPRINDO FILA PAC
	  	    cout<<endl;
			cout << "***************************************************************" << endl;
			cout << "************************** FILA PAC ***************************" << endl;
		    cout << "***************************************************************" << endl;
            cout<<endl;
			imprimir(filaPac);
			
			//IMPRIMINDO FILA SEDEX
			cout <<endl;
			cout << "***************************************************************" << endl;
			cout << "************************** FILA SEDEX *************************" << endl;
			cout << "***************************************************************" << endl;
            cout<<endl;
			imprimir(filaSedex);
		}
		break;

		case 0://OP��O SAIR
		{
		    cout << endl;
			cout << "******************* SAINDO *****************" << endl;
			cout << endl;
		}

		break;

		default:
		{
		    cout << endl;
			cout << "*************** OP��O INV�LIDA *************" << endl;
			cout << endl;
		}

		}
		system("pause");

	}
	while(op != 0);


	return 0;
}
