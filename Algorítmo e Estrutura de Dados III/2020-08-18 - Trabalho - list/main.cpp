#include <iostream>
using namespace std;

/* INTRUÇÕES DO EXERCÍCIO
Usando como base o código feito em aula, altere-o para controlar uma lista de churrasco.
Além do NOME, você deverá armazenar o SEXO da pessoa, a IDADE e se a pessoa BEBE ou NÃO.
*/


// CRIANDO O TIPO DE DADO ARMAZENADO ----------------------
class celula
{
    // Todos os campos (váriaveis) ficam no modo PRIVATE para que o acesso seja feito apenas pelos GETs e SETs
    private:
        string nome;
        char sexo;
        int idade;
        bool bebedor;
        celula * proxima;

    // Aqui estão todos os métodos de acesso    
    public:
        celula()
        {
            proxima = NULL;
        }

        celula(string n, char s, int i, bool b, celula *p)
        {
            nome = n;
            sexo = s;
            idade = i;
            bebedor = b;
            proxima = p;
        }


        // GET E SET ----------------------
            // GET -> Usado para fazer uma consulta na variável
            // SET -> Usado para alterar o valor da variável

        // NOME
        string getNome() { return nome; }
        void setNome(string n) { nome = n;}

        // SEXO
        char getSexo() { return sexo; }
        void setSexo(char s) { sexo = s; }

        // IDADE
        int getIdade() { return idade; }
        void setIdade(int i) { idade = i; }

        // BEBEDOR
        bool getBebedor() { return bebedor; }
        void setBebedor(bool b) { bebedor = b; }

        // PRÓXIMA
        celula * getProxima() { return proxima; }
        void setProxima(celula * l)  { proxima = l; }
};


// CRIANDO A LISTA ----------------------
class lista
{
    private:
        celula * inicio;

    public:

        // MÉTODO CONSTRUTOR
        lista()
        {
            inicio = NULL;
        }

        // MÉTODO DESTRUTOR
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

        void inserirInicio(string n, char s, int i, bool b)
        {
            celula *nova = new celula;
            nova->setNome(n);
            nova->setSexo(s);
            nova->setIdade(i);
            nova->setBebedor(b);
            nova->setProxima(inicio);
            inicio = nova;
        }

        void inserirFim(string n, char s, int i, bool b)
        {
            if(inicio == NULL)
            {
                inserirInicio(n, s, i, b);
            }
            else
            {
                celula *aux = inicio;
                while(aux->getProxima() != NULL)
                {
                    aux = aux->getProxima();
                }
                celula *nova = new celula(n, s, i, b, NULL);
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
                    // Usando uma variavel auxiliar pra transformar dado boleando em "SIM" ou "NÃO"
                    string bebe = "Sim";
                    if (aux->getBebedor() == 0) { bebe = "Nao"; }

                    // IMPRIMINDO               
                    cout << endl;
                    cout << "NOME: " << aux->getNome() << endl;
                    cout << "SEXO: " << aux->getSexo() << endl;
                    cout << "IDADE: " << aux->getIdade() << endl;
                    cout << "BEBEDOR: " << bebe << endl;

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
	lista listaChurrasco;
	listaChurrasco.inserirFim("Ana", 'F', 27, true);
	listaChurrasco.inserirFim("Maria", 'F', 21, false);
    listaChurrasco.inserirInicio("Fabricio", 'M', 23, true);
	listaChurrasco.imprimir();
	return 0;
}