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
	{
		proxima = NULL;
	}
	celula(string n)
	{
		nome = n;
	}
	celula(string n, celula *p)
	{
		nome = n;
		proxima = p;
	}
	celula(string n, float m, celula *p){
		nome = n;
		mediaFinal = m;
		proxima = p;
	}
	string getNome()
	{
		return nome;
	}
	void setNome(string n)
	{
		nome = n;
	}

	celula * getProxima()
	{
		return proxima;
	}

	void setProxima(celula * l)
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


class lista
{
private:
	celula * inicio;

public:
	lista()
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
	celula * getInicio()
	{
		return inicio;
	}

	void inserirInicio(string n, float m)
	{
		celula *nova = new celula;
		nova->setNome(n);
		nova->setProxima(inicio);
		nova->setMediaFinal(m);
		inicio = nova;
	}

	void inserirFim(string n, float m)
	{
		if(inicio == NULL)
		{
			inserirInicio(n, m);
		}
		else
		{
			celula *aux = inicio;
			while(aux->getProxima() != NULL)
			{
				aux = aux->getProxima();
			}
			celula *nova = new celula(n, m, NULL);
			aux->setProxima(nova); 
		}
	}


	void imprimir()
	{
		if(inicio == NULL)
		{
			cout << "Lista vazia.\n";
		}
		else
		{
			celula *aux = inicio;
			while(aux != NULL)
			{
				cout << aux->getNome() << " - " << aux->getMediaFinal() << endl;
				aux = aux->getProxima();
			}
		}
	}
	
	void esvaziar(){
		celula *aux = inicio;
		while(aux != NULL){
			inicio = inicio->getProxima();
			delete aux;
			aux = inicio;
		}
		cout << "\n----Memoria liberada----\n";
	}
};

int main()
{
	lista listaAlunos;
	listaAlunos.inserirInicio("Miguel", 9.5);
	listaAlunos.inserirFim("Jorge", 10);
	listaAlunos.inserirFim("Ana", 9.8);
	listaAlunos.imprimir();
	return 0;
}
