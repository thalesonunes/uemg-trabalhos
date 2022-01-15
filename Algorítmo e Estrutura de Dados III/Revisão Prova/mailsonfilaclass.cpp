#include <iostream>
#include <queue>

using namespace std;

class pessoa{
	private:
		string nome;
		int idade;
		string cpf;
	public:
		pessoa(string n, int i, string c){
			nome = n;
			idade = i;
			cpf = c;
		}
		void imprimir(){
			cout << nome << " - " << cpf << " - " << idade << endl;
		}
};

void imprimir(queue<pessoa> fila){
	while(fila.size() > 0){
		fila.front().imprimir();
		fila.pop();
	}
}



int main() {
  queue<pessoa> filaBanco;

	pessoa p1("Mailson", 22, "55454541");
	filaBanco.push(p1);

	string nomePessoa, cpfPessoa;
	int idadePessoa;
	cout << "Digite o nome da pessoa: ";
	cin >> nomePessoa;
	cout << "Digite a idade da pessoa: ";
	cin >> idadePessoa;
	cout << "Digite o CPF da pessoa: ";
	cin >> cpfPessoa;
	pessoa p2(nomePessoa, idadePessoa, cpfPessoa);

	filaBanco.push(p2);


	imprimir(filaBanco);

}
