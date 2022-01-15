
#include <iostream>
#include <list>

using namespace std;

class jogador
{
private:
	string nome, posicao;
	int numero;

protected:

public:
	jogador(){
		cout << "Digite o nome do jogador: ";
		cin >> nome;
		cout << "Digite a posicao do jogador: ";
		cin >> posicao;
		cout << "Digite o numero do jogador: ";
		cin >> numero;
	}

	string getNome(){
		return nome;
	}

	int getNumero(){
		return numero;
	}
	void imprimir(){
		cout << "Nome: " << nome ;
		cout << "\tPosicao: " << posicao;
		cout << "\tNumero: " << numero<<endl;
	}
};


void imprimirLista(list<jogador> l){
	for(list<jogador>::iterator i = l.begin(); i != l.end(); i++){
		i->imprimir();
	}
}

int main()
{
	list<jogador> time1;
	jogador j1, j2;
	time1.push_back(j1);
	time1.push_back(j2);
	imprimirLista(time1);
	return 0;
}
