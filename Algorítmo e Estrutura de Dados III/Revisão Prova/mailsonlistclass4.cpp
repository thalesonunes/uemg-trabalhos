#include <iostream>
using namespace std;
class celula
{
private:
	string nome;
	float mediaFinal;
	celula * proxima;
public:
	celula()
@@ -17,16 +16,12 @@ class celula
	{
		nome = n;
	}
	celula(string n, celula *p)
	{
		nome = n;
		proxima = p;
	}
	celula(string n, float m, celula *p){

	celula(string n, celula *p){
		nome = n;
		mediaFinal = m;
		proxima = p;
	}

	string getNome()
	{
		return nome;
@@ -45,12 +40,6 @@ class celula
	{
		proxima = l;
	}
	float getMediaFinal(){
		return mediaFinal;
	}
	void setMediaFinal(float m){
		mediaFinal = m;
	}
};


@@ -64,32 +53,41 @@ class lista
	{
		inicio = NULL;
	}
	~lista(){
		esvaziar();
	}
	lista(celula *i)
	{
		inicio = i;
	}
	~lista()
	{
		esvaziar();
		cout << "\nPassou no metodo destrutor";
	}
	celula * getInicio()
	{
		return inicio;
	}

	void inserirInicio(string n, float m)
	void setInicio(celula *i)
	{
		inicio = i;
	}

	void inserirInicio(string n)
	{
		celula *nova = new celula;
		nova->setNome(n);
		nova->setProxima(inicio);
		nova->setMediaFinal(m);
		inicio = nova;
	}

	void inserirFim(string n, float m)
	void inserirFim(string n)
	{
		celula *nova = new celula(n, NULL);
		//nova->setNome(n);
		//nova->setProxima(NULL);
		if(inicio == NULL)
		{
			inserirInicio(n, m);
			inicio = nova;
		}
		else
		{
@@ -98,8 +96,7 @@ class lista
			{
				aux = aux->getProxima();
			}
			celula *nova = new celula(n, m, NULL);
			aux->setProxima(nova);
			aux->setProxima(nova);
		}
	}

@@ -115,29 +112,34 @@ class lista
			celula *aux = inicio;
			while(aux != NULL)
			{
				cout << aux->getNome() << " - " << aux->getMediaFinal() << endl;
				cout << aux->getNome() << endl;
				aux = aux->getProxima();
			}
		}
	}

	void esvaziar(){

	void esvaziar()
	{
		celula *aux = inicio;
		while(aux != NULL){
		while(aux != NULL)
		{
			inicio = inicio->getProxima();
			delete aux;
			aux = inicio;
		}
		cout << "\n----Memoria liberada----\n";
		cout << "\nLista esvaziada com sucesso.";
	}


};

int main()
{
	lista listaAlunos;
	listaAlunos.inserirInicio("Miguel", 9.5);
	listaAlunos.inserirFim("Jorge", 10);
	listaAlunos.inserirFim("Ana", 9.8);
	listaAlunos.inserirInicio("Miguel");
	listaAlunos.inserirFim("Ana");
	listaAlunos.esvaziar();
	listaAlunos.inserirFim("Vinicius");
	listaAlunos.imprimir();
	return 0;
}
