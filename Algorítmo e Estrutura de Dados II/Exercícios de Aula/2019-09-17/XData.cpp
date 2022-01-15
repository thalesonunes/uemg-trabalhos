#include <iostream>
using namespace std;

struct TProduto
{
    int codigo;
    string nome;
    string descricao;
    string unidade;
    float quantidade;
    float valor_compra;
    float valor_venda;
};

TProduto prods[10]; // vetor de prosutos
int indice = 0; // indice do vetor de produtos

void cadastra()
{
    cout << "CODIGO: ";
    cin >> prods[indice].codigo;
    cout << "NOME: ";
    cin >> prods[indice].nome;
    cout << "DESCRICAO: ";
    cin >> prods[indice].descricao;
    cout << "UNIDADE: ";
    cin >> prods[indice].unidade;
    cout << "QUANTIDADE: ";
    cin >> prods[indice].quantidade;
    cout << "VALOR DE COMPRA: ";
    cin >> prods[indice].valor_compra;
    // cout << "VALOR DE VENDA: ";
    // cin >> prods[indice].valor_venda;
    indice++;
    cout << endl;
}

void setValorVenda(float porcento)
{
    for (int i=0; i<indice; i++)
    {
        prods[i].valor_venda = prods[i].valor_compra + (porcento * prods[i].valor_compra/100);
    }
}

void lista ()
{
    for (int i=0; i<indice; i++)
    {
        cout << "CODIGO: " << prods[i].codigo << endl;
        cout << "NOME: " << prods[i].codigo << endl;
        cout << "DESCRICAO: " << prods[i].codigo << endl;
        cout << "UNIDADE: " << prods[i].codigo << endl;
        cout << "QUANTIDADE: " << prods[i].codigo << endl;
        cout << "VALOR DE COMPRA: " << prods[i].codigo << endl;
        cout << "VALOR DE VENDA: " << prods[i].codigo << endl;
        cout << endl;

    }
}

void buscaProd (int codigo)
{
    bool achei=false;
    for (int i=0; i<indice; i++)
    {
        if (prods[i].codigo == codigo)
        {
            cout << "CODIGO: " << prods[i].codigo << endl;
            cout << "NOME: " << prods[i].codigo << endl;
            cout << "DESCRICAO: " << prods[i].codigo << endl;
            cout << "UNIDADE: " << prods[i].codigo << endl;
            cout << "QUANTIDADE: " << prods[i].codigo << endl;
            cout << "VALOR DE COMPRA: " << prods[i].codigo << endl;
            cout << "VALOR DE VENDA: " << prods[i].codigo << endl;
            cout << endl;
            achei = true;
            cout << endl;
        }

        if (achei == false)
            cout << "CÓDIGO NÃO CADASTRADO!";
            cout << endl;
    }
}


int main()
{
    setlocale(LC_ALL, "portuguese");

    cadastra(); // cadatsra novo produto
    float perc;
    cout << "Digite a porcentagem de lucro: ";
    cin >> perc;
    cadastra(); // cadatsra novo produto
    setValorVenda(perc); // calcula o valor de venda dos produtos
    lista(); // lista todos os produtos cadastrados
    buscaProd(23); // busca o produto com codigo 23

    return 0;
}
