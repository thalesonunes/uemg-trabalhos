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

//FUNÇÃO IMPRIMIR O PROXIMO DA FILA
void imprimirproximo(queue<pessoa>fila)
{
		cout << "NOME DO USUÁRIO: ";
		cout << fila.front().nome<< endl;

		cout<<"ENDEREÇO DO USUÁRIO"<<endl;
		cout<<"CEP: ";
		cout<<fila.front().remetente.cep<<endl;
		cout<<"RUA: ";
		cout<<fila.front().remetente.rua<<endl;
        cout<<"NÚMERO: ";
        cout<<fila.front().remetente.numero<<endl;
        cout<<"CIDADE: ";
        cout<<fila.front().remetente.cidade<<endl;

        cout<<endl;
		cout << "NOME DO DESTINATÁRIO: ";
		cout << fila.front().nomedest<< endl;

		cout<<"ENDEREÇO DO DESTINATÁRIO"<<endl;
		cout<<"CEP: ";
		cout<<fila.front().destino.cep<<endl;
		cout<<"RUA: ";
		cout<<fila.front().destino.rua<<endl;
        cout<<"NÚMERO: ";
        cout<<fila.front().destino.numero<<endl;
        cout<<"CIDADE: ";
        cout<<fila.front().destino.cidade<<endl;
}

//FUNÇÃO IMPRIMIR FILAS
void imprimir(queue<pessoa>fila)
{
	while(fila.size() > 0)
	{
		cout << "NOME DO USUÁRIO: ";
		cout << fila.front().nome <<endl;

		cout<<"ENDEREÇO DO USUÁRIO"<<endl;
		cout<<"CEP: ";
		cout<<fila.front().remetente.cep<<endl;
		cout<<"RUA: ";
		cout<<fila.front().remetente.rua<<endl;
        cout<<"NÚMERO: ";
        cout<<fila.front().remetente.numero<<endl;
        cout<<"CIDADE: ";
        cout<<fila.front().remetente.cidade<<endl;

        cout<<endl;
		cout << "NOME DO DESTINATÁRIO: ";
		cout << fila.front().nomedest <<endl;

		cout<<"ENDEREÇO DO DESTINATÁRIO"<<endl;
		cout<<"CEP: ";
		cout<<fila.front().destino.cep<<endl;
		cout<<"RUA: ";
		cout<<fila.front().destino.rua<<endl;
        cout<<"NÚMERO: ";
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
		cout << "****************** DIGITE A OPÇÃO DESEJADA ********************" << endl;
		cout << "***************************************************************" << endl;
		cout << "1 - ADICIONAR PESSOA NA FILA " << endl;
		cout << "2 - CHAMAR O PRÓXIMO DA FILA" << endl;
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
			cout << "                   QUAL O SERVIÇO DESEJADO?"                     << endl;
			cout << "                       [1]PAC  [2]SEDEX"                         << endl;
			cout << "***************************************************************" << endl;
			cout << endl;
			cin  >> servico;

			if(servico == 1)
			{
				pessoa p1;
				int contpac = 0;

				cout << endl;
				cout << "NOME DO USUÁRIO: " << endl;
				cin.ignore();
				getline(cin, p1.nome);

				cout << "ENDEREÇO DO USUÁRIO"<<endl;
				cout << "DIGITE O CEP: " << endl;
                getline(cin, p1.remetente.cep);
                cout << "DIGITE A RUA: " << endl;
                getline(cin, p1.remetente.rua);
                cout << "DIGITE O NÚMERO DA RESIDÊNCIA: " << endl;
                cin >> p1.remetente.numero;
                cout << "DIGITE A CIDADE: " << endl;
                cin.ignore();
                getline(cin, p1.remetente.cidade);
                cout << "-------------------------------"<<endl;

				cout << "NOME DO DESTINATÁRIO: " << endl;
				getline(cin, p1.nomedest);

                cout << "ENDEREÇO DO DESTINATÁRIO"<<endl;
				cout << "DIGITE O CEP: " << endl;
                getline(cin, p1.destino.cep);
                cout << "DIGITE A RUA: " << endl;
                getline(cin, p1.destino.rua);
                cout << "DIGITE O NÚMERO DA RESIDÊNCIA: " << endl;
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
						cout<< "********* USUÁRIO ADICIONADO À FILA PAC COM SUCESSO! **********"<<endl;
						cout<<endl;	
						}
      
						else if (contpac == 0)
						{
						cout<<endl;
						cout<< "************* USUÁRIO NÃO ADICIONADO À FILA PAC! *************"<<endl;
						cout<<endl;

						}

			}
			else if(servico == 2)
			{
				pessoa p1;
				int contsedex = 0;

				cout << endl;
				cout << "NOME DO USUÁRIO: " << endl;
				cin.ignore();
				getline(cin, p1.nome);

				cout << "ENDEREÇO DO USUÁRIO"<<endl;
				cout << "DIGITE O CEP: " << endl;
                getline(cin, p1.remetente.cep);
                cout << "DIGITE A RUA: " << endl;
                getline(cin, p1.remetente.rua);
                cout << "DIGITE O NÚMERO DA RESIDÊNCIA: " << endl;
                cin >> p1.remetente.numero;
                cout << "DIGITE A CIDADE: " << endl;
                cin.ignore();
                getline(cin, p1.remetente.cidade);
                cout << "-------------------------------"<<endl;

				cout << "NOME DO DESTINATÁRIO: " << endl;
				getline(cin, p1.nomedest);

                cout << "ENDEREÇO DO DESTINATÁRIO"<<endl;
				cout << "DIGITE O CEP: " << endl;
                getline(cin, p1.destino.cep);
                cout << "DIGITE A RUA: " << endl;
                getline(cin, p1.destino.rua);
                cout << "DIGITE O NÚMERO DA RESIDÊNCIA: " << endl;
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
						cout<< "******** USUÁRIO ADICIONADO À FILA SEDEX COM SUCESSO! *********"<<endl;
						cout<<endl;	
						}
      
						else if (contsedex == 0)
						{
						cout<<endl;
						cout<< "************ USUÁRIO NÃO ADICIONADO À FILA SEDEX! ************"<<endl;
						cout<<endl;

						}

			}
			else
			{
			cout << "*************** OPÇÃO INVÁLIDA *************" << endl;
			}

		}
		break;


		case 2://CHAMAR O PRÓXIMO DA FILA, INDICANDO A FILA CORRESPONDENTE
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
				cout << "                     PRÓXIMOS ATENDIMENTOS"                      << endl;
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
				cout << "                     PRÓXIMOS ATENDIMENTOS"                      << endl;
				cout << "                          FILA SEDEX"                            << endl;
    			cout << "***************************************************************" << endl;
                cout<<endl;
				filaSedex.pop();
				imprimir(filaSedex);

			}
			else
			{
			cout << "*************** OPÇÃO INVÁLIDA *************" << endl;
			}

		}

		break;


		case 3://MOSTRAR AS FILAS
		{
			//IMPRIMINDO AS FILAS, CHAMANDO FUNÇÃO

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

		case 0://OPÇÃO SAIR
		{
		    cout << endl;
			cout << "******************* SAINDO *****************" << endl;
			cout << endl;
		}

		break;

		default:
		{
		    cout << endl;
			cout << "*************** OPÇÃO INVÁLIDA *************" << endl;
			cout << endl;
		}

		}
		system("pause");

	}
	while(op != 0);


	return 0;
}
