#include <iostream>
#include <stdlib.h>
#include <list>


using namespace std;

void menu();

class aluno
{
private:
	string nome;
	float nota;

protected:

public:

    // METODO CONSTRUTOR
	aluno(){
	}
	
    //GETS E SETS
	string getNome(){
		return nome;
	}

    void setNome(string n){
        nome = n;
    }
  
	int getNota(){
		return nota;
	}

    void setNota(float n){
        nota = n;
    }

    // IMPRIMINDO DADOS NA TELA
	void imprimir(float acrescimo){

		cout << "NOME: " << nome << endl;
        cout << "NOTA: " << nota * acrescimo << endl;
		cout << "--------------------------------------" << endl;
	}

    // SOBRECRGA DE OPERADOR
	bool operator == (const aluno& removido) const{
		return nome == removido.nome;
	}
};

// IMPRIMINDO LISTA CHAMANDO METODO IMPRIMIR DO OBJETO
// Usa um contador para incrementar acrescimo de nota
// para os tres primeiros alunos
void imprimirLista (list<aluno> l){

    int contador = 0;

	for(list<aluno>::iterator i = l.begin(); i != l.end(); i++){

        contador++;
        
        if (contador == 1){ i->imprimir(1.10); }
        if (contador == 2){ i->imprimir(1.075); } 
        if (contador == 3){ i->imprimir(1.05); } 
        if (contador > 3){ i->imprimir(1); } 
		
	}
}

// PROGRAMA PRINCIPAL
int main()
{	
    setlocale(LC_ALL, "portuguese");

    // DECLARANDO A LISTA
    list<aluno> turma;
	
    // INTERFACE DO MENU
    int opcao;
	do{

        system("cls");	
		cout << "--------------------------------------" << endl;
		cout << "            DIGITE UMA OPCAO          " << endl;
		cout << "--------------------------------------" << endl;
		cout << "1 - CADASTRAR ALUNO " << endl;
		cout << "2 - REMOVER ALUNO " << endl;
		cout << "3 - ATUALIZAR NOME " << endl;
		cout << "4 - ATUALIZAR NOTA " << endl;
		cout << "5 - IMPRIMIR " << endl;
		cout << "0 - SAIR " << endl;
		cout << "--------------------------------------" << endl;
		cout << endl;
		cin >> opcao;

        // VARIAVEIS AUXILIARES
		aluno alunoAux;
        string nomeAux;
        string n1, n2;
		float notaAux;
        bool atualizado = false;
		
        // SELECIONANDO AS OPCOES
		switch(opcao) {
            case 0:
            {
                system("cls");
                cout << "VOCE SAIU DO PROGRAMA!" << endl;
                system("pause");
                break;
            }
                
			case 1:
			{				
                system("cls");
                atualizado = false;
                cout << "--------------------------------------" << endl;
                cout << "          CADASTRANDO ALUNO           " << endl;
                cout << "--------------------------------------" << endl;

                cout << "Digite o nome: ";
                cin.ignore();
                getline(cin, nomeAux);
                alunoAux.setNome(nomeAux);

                list<aluno>::iterator elemento;
                for(elemento = turma.begin(); elemento != turma.end(); elemento++)
                {
                    n1 = elemento->getNome();
                    n2 = alunoAux.getNome();

                    if(n1 == n2)
                    {
                        cout << "ERRO! CADASTRO JA EXISTENTE!" << endl;

                        atualizado = true;
                    }
                    
                }

                if (atualizado == false)
                {
                    cout << "Digite a nota: ";
                    cin >> notaAux;

                    while(notaAux > 10 || notaAux < 0)
                    {
                        cout << "NOTA INCORRETA!" << endl;
                        cout << "Digite uma nova nota: ";
                        cin >> notaAux;
                    }
            
                    alunoAux.setNota(notaAux);

                    turma.push_back(alunoAux);

                    cout << "O ALUNO CADASTRADO!" << endl;        
                }

                system("pause");
                break;     
			}
			
            case 2:
			{
				system("cls");
                atualizado = false;
                cout << "--------------------------------------" << endl;
                cout << "           REMOVENDO ALUNO            " << endl;
                cout << "--------------------------------------" << endl;

				cout << "Digite o nome: ";
                cin.ignore();
                getline(cin, nomeAux);
                alunoAux.setNome(nomeAux);

                list<aluno>::iterator elemento;
                for(elemento = turma.begin(); elemento != turma.end(); elemento++)
                {
                    n1 = elemento->getNome();
                    n2 = alunoAux.getNome();

                    if(n1 == n2)
                    {
                        turma.remove(alunoAux);

                        cout << "O ALUNO FOI REMOVIDO!" << endl;

                        atualizado = true;
                    }
                }

                if (atualizado == false)
                {
                    cout << "NOME NAO ENCONTRADO!" << endl;
                }

			    system("pause");
                break;
            }

            case 3:
			{
				system("cls");
                atualizado = false;
                cout << "--------------------------------------" << endl;
                cout << "          ATUALIZANDO O NOME          " << endl;
                cout << "--------------------------------------" << endl;

                cout << "Digite o nome: ";
                cin.ignore();
                getline(cin, nomeAux);
                alunoAux.setNome(nomeAux);

                list<aluno>::iterator elemento;
                for(elemento = turma.begin(); elemento != turma.end(); elemento++)
                {
                    n1 = elemento->getNome();
                    n2 = alunoAux.getNome();

                    if(n1 == n2)
                    {
                        cout << "Digite o NOVO nome: ";
                        getline(cin, nomeAux);
                        alunoAux.setNome(nomeAux);
                        
                        elemento->setNome(nomeAux);

                        cout << "O NOME FOI ATUALIZADO!" << endl;

                        atualizado = true;
                    }
                }

                if (atualizado == false)
                {
                    cout << "NOME NAO ENCONTRADO!" << endl;
                }

                system("pause");  
                break;
			}
                
            case 4:
            {
                system("cls");
                atualizado = false;
                cout << "--------------------------------------" << endl;
                cout << "          ATUALIZANDO O NOTA          " << endl;
                cout << "--------------------------------------" << endl;

                cout << "Digite o nome: ";
                cin.ignore();
                getline(cin, nomeAux);
                alunoAux.setNome(nomeAux);

                list<aluno>::iterator elemento;
                for(elemento = turma.begin(); elemento != turma.end(); elemento++)
                {
                    n1 = elemento->getNome();
                    n2 = alunoAux.getNome();

                    if(n1 == n2)
                    {                     
                        cout << "Digite a NOVA nota: ";
                        cin >> notaAux;

                        while(notaAux > 10 || notaAux < 0)
                        {
                            cout << "NOTA INCORRETA!" << endl;
                            cout << "Digite uma nova nota: ";
                            cin >> notaAux;
                        }

                        alunoAux.setNota(notaAux);
                        
                        elemento->setNota(notaAux);

                        cout << "A NOTA FOI ATUALIZADA!" << endl; 

                        atualizado = true;                  
                    }
                }

                if (atualizado == false)
                {
                    cout << "NOME NAO ENCONTRADO!" << endl;
                }

                system("pause");
                break;
            }

            case 5:
            {
				system("cls");
				cout << "--------------------------------------" << endl;
                cout << "             IMPRIMINDO               " << endl;
                cout << "--------------------------------------" << endl;

                imprimirLista(turma);

                system("pause");
                break;
            }

            default:
            {  
                cout << "OPCAO INVALIDA!" << endl;
                system("pause");
            }
                
		}
	}while (opcao != 0);
	
	return 0;
}