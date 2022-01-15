#include <iostream>
#include <queue>

using namespace std;

struct pessoa{
	string nome;
	int idade;
	string cpf;
};

void imprimir(queue<pessoa> fila){
	while(fila.size() > 0){
		cout << fila.front().nome << " - " << fila.front().cpf << " - " << fila.front().idade << endl;
		fila.pop();
	}
}



int main() {
  queue<pessoa> filaBanco;

	pessoa p1, p2;
	cout << "Digite o nome da pessoa: ";
	cin >> p1.nome;
	cout << "Digite a idade da pessoa: ";
	cin >> p1.idade;
	cout << "Digite o CPF da pessoa: ";
	cin >> p1.cpf;

	filaBanco.push(p1);

	cout << "Digite o nome da pessoa: ";
	cin >> p2.nome;
	cout << "Digite a idade da pessoa: ";
	cin >> p2.idade;
	cout << "Digite o CPF da pessoa: ";
	cin >> p2.cpf;
	filaBanco.push(p2);


	imprimir(filaBanco);

}
