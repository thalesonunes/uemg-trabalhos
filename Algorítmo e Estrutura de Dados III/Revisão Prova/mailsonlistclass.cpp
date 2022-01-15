#include <iostream>
#include <list>

using namespace std;

class jogador{
	private:
		string nome, posicao;
		int numero;
	public:
		jogador(){
		}
		jogador(string n, string p, int nu){
			nome = n;
			posicao = p;
			numero = nu;
		}

		//sobrecarga operador ==
		bool operator == (const jogador& p) const {
			return nome == p.nome;
		}

		void imprimir(){
			cout << nome << " - " << posicao << " - " << numero << endl;
		}
};

int main() {
	jogador j1("Mailson", "Atacante", 9);
	jogador j2("Thales", "Meia", 19);
	jogador j3("Jose", "Meia", 15);

	if(j1 == j2){
		cout << "Iguais\n\n";
	}
	else{
		cout << "Diferentes\n\n";
	}

	list<jogador> time;
	time.push_back(j1);
	time.push_back(j2);
	time.push_back(j3);

	for(auto item : time){
		item.imprimir();
	}
	jogador temp("Mailson", "", 0);
	time.remove(temp);

	for(auto item : time){
		item.imprimir();
	}

}
