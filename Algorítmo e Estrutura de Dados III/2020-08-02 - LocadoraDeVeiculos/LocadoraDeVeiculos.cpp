// INCLUINDO BIBLIOTECAS NECESSÁRIAS
//--------------------------------------------------------------------------------
#include <iostream>
#include <fstream>
#include <stdlib.h>
#include <string>
#include <algorithm>
using namespace std;



// DESCRICAO DO PROGRAMA
//--------------------------------------------------------------------------------
/*
    Consiste em um sistema de gerenciamento de uma LOCADORA DE VEICULOS.

*/



// DECLARANDO VARIAVEIS GLOBAIS
//--------------------------------------------------------------------------------
// CADASTRO DP VEICULO
string placa, marca, modelo, motor, ano, km, categoria, valor, status, locatario;
bool errorMsg = false;

//contadores iniciando em -1 pois sofrerão incremento no inicio no "While" dentro da funcao de leitura
int contadorLinha=0;
int contadorColuna=0;
string registro[50][10];



// DECLARANDO PROTOTIPOS DAS FUNCOES
//--------------------------------------------------------------------------------
void lendoRegistro();

void menuPrincipal();

void menuLocacoes();
void locacoesCadastrar();
void locacoesEditar();
void locacoesDevolver();
void locacoesConsultar();

void menuVeiculos();
void veiculosCadastrar();
void veiculosEditar();
void veiculosConsultar();
void veiculosConsultarTodos();
void veiculosConsultarMarca();
void veiculosConsultarMotor();
void veiculosConsultarCategoria();
void veiculosConsultarStatus();

void sair();
void salvar();



// ENTRADA DO PROGRAMA
//--------------------------------------------------------------------------------
int main()
{
    setlocale(LC_ALL, "portuguese");

    // cria o "registro.txt" caso não exista
    ofstream arqVeiculosSaida;
    arqVeiculosSaida.open("registro.txt", ios::app);
    arqVeiculosSaida.close();
    
    // carrega os dados de "registro.txt"
    lendoRegistro();

    // chama o menu principal
    menuPrincipal();

    // fim do programa
    cout << endl << "PROGRAMA FINALIZADO" << endl;

    system("pause");

    return 0;
}



// FUNCAO DE CARREGAMENTO DOS DADOS JA GRAVADOS NO TXT
//--------------------------------------------------------------------------------
void lendoRegistro()
{
    // limpa os contadores de linha e coluna da matriz
    // assim, sempre que for chamada a função "lendoRegistro", os dados lidas do txt serão alocadas no início da matriz, sobrescrevendo os dados existentes na mesma
    contadorLinha=0;
    contadorColuna=0;

    // variavel que vai receber o dado do arquivo "registro.txt"
    string dados;

    ifstream arquivoLeitura ("registro.txt");

    // CARREGANDO OS DADOS POR WHILE
    while (!arquivoLeitura.eof())
    {
        // aqui é carregada a informaçao da linha no arquivo para a variavel dados e alocada na matriz "registro"
        getline(arquivoLeitura, dados);

        //CONVERTER DADOS PRA LOWERCASE

        string stringEntrada;
        string stringSaida;

        stringEntrada = dados;

        // Aloca o espaço de destino
        stringSaida.resize(stringEntrada.size());

        // Converte a stringEntrada para "lowercase"
        // Armazenando o resultado em stringSaida
        transform(stringEntrada.begin(), stringEntrada.end(), stringSaida.begin(), ::toupper);

        dados = stringSaida;

        registro[contadorLinha][contadorColuna] = dados;

        contadorColuna++; // incremento de coluna

        // quando o contador da coluna chegar a 10, a variavel recebera o valor zero e a linha será incrementada em +1 para que passe a alocar os dados do proximo veiculo na linha seguinte da matriz
        if (contadorColuna == 10)
        {
            contadorColuna=0;
            contadorLinha++;
        }
    }

    arquivoLeitura.close();

}



// FUNCAO DE SAIDA - ESCOLHE ENTRE SALVAR E DESCARTAR
//--------------------------------------------------------------------------------
void sair()
{
    system("cls");
    exit(0);
}



// FUNCAO SALVAR - FAZ A ESCRITA DAS INFORMAÇÕES NO TXT
//--------------------------------------------------------------------------------
void salvar()
{
    ofstream arqLocacoesSaida;
    arqLocacoesSaida.open("registro.txt", ios::out);

    int i=0;
    int j=0;

    for (i=0; i<contadorLinha; i++)
    {
        if (j == 9)
            {
                j = 0;
            }
        
        for (j=0; j<=9; j++)
        {
            arqLocacoesSaida << registro[i][j] << endl;

        }
    }

   arqLocacoesSaida.close();

   // Le o "registro.txt" novamente para atualizar a matriz
   lendoRegistro();
   
}


// MENU PRINCIPAL
//--------------------------------------------------------------------------------
void menuPrincipal()
{

    int opMenuPrincipal = 0;
    cout << "======================================================" << endl;
    cout << "+++              LOCADORA DE VEICULOS              +++" << endl;
    cout << "+++               > Menu Principal <               +++" << endl;
    cout << "======================================================" << endl;
    cout << endl;
    cout << "Selecione uma opcao: " << endl;
    cout << endl;
    cout << "1 - LOCACOES" << endl;
    cout << "2 - VEICULOS" << endl;
    cout << "3 - Sair" << endl;
    cout << endl;
    cout << "======================================================" << endl;
    cin >> opMenuPrincipal;

    switch (opMenuPrincipal)
    {

    case 1:
        menuLocacoes();
        break;

    case 2:
        menuVeiculos();
        break;

    case 3:
        system("cls");
        sair();
        break;

    default:
        system("cls");
        cout << "OCPCAO INCORRETA, digite novamente!" << endl << endl;
        menuPrincipal();
    }
}



// MENU LOCACOES
//--------------------------------------------------------------------------------
void menuLocacoes()
{

    system("cls");
    int opMenuLocacoes = 0;
    cout << "======================================================" << endl;
    cout << "+++                  > LOCACOES <                  +++" << endl;
    cout << "======================================================" << endl;
    cout << endl;
    cout << "Selecione uma opcao: " << endl;
    cout << endl;
    cout << "1 - CADASTRAR" << endl;
    cout << "2 - EDITAR" << endl;
    cout << "3 - DEVOLVER" << endl;
    cout << "4 - CONSULTAR" << endl;
    cout << "5 - Voltar" << endl;
    cout << "6 - Sair" << endl;
    cout << endl;
    cout << "======================================================" << endl;
    cin >> opMenuLocacoes;

    switch (opMenuLocacoes)
    {

    case 1:
        system("cls");
        locacoesCadastrar();
        break;

    case 2:
        system("cls");
        locacoesEditar();
        break;

    case 3:
        system("cls");
        locacoesDevolver();
        break;

    case 4:
        system("cls");
        locacoesConsultar();
        break;

    case 5:
        system("cls");
        menuPrincipal();
        break;

    case 6:
        system("cls");
        sair();
        break;

    default:
        system("cls");
        cout << "OCPCAO INCORRETA, digite novamente!" << endl
             << endl;
        menuLocacoes();
    }
}



//LOCACOES CADASTRAR
//--------------------------------------------------------------------------------
void locacoesCadastrar()
{

    lendoRegistro();
    
    system("cls");

    cout << "======================================================" << endl;
    cout << "+++             > LOCACOES / CADASTRAR <           +++" << endl;
    cout << "======================================================" << endl;

    cout << endl << "Digite a placa do veiculo: ";
    cin >> placa;

    // VERIFICA SE A PLACA JÁ NÃO ESTÁ LOCADA
    for (int i = 0; i < 50; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            if (registro[i][j] == placa)
            {
                if (registro[i][j+8] == "LOCADO")
                {
                    system("cls");
                    cout << "======================================================" << endl;
                    cout << "+++             > LOCACOES / CADASTRAR <           +++" << endl;
                    cout << "======================================================" << endl;

                    cout << endl << "VEICULO JA ESTA LOCADO!!!" << endl << endl;

                    cout << "Digite a placa de OUTRO veiculo: ";
                    cin >> placa;
                }
            }
        }
    }

    system("cls");

    cout << "======================================================" << endl;
    cout << "+++             > LOCACOES / CADASTRAR <           +++" << endl;
    cout << "======================================================" << endl;

    string dados;         // recebe os dados
    char opLocacoesCadastrar; // usado no "switch case"
    bool alteracao; // usada pra verificar se foi feita a alteracao nos dados

    for (int i = 0; i < 50; i++)
    {

        for (int j = 0; j < 10; j++)
        {

            dados = registro[i][j];

            if (dados == placa)
            {
                cout << endl << "Insira os dados da locacao:" << endl << endl;

                registro[i][j + 8] = "LOCADO";

                cin.ignore();
                cout << "LOCATARIO: ";
                getline (cin, registro[i][j + 9]);

                system("cls");

                cout << "======================================================" << endl;
                cout << "+++             > LOCACOES / CADASTRAR <           +++" << endl;
                cout << "======================================================" << endl;

                alteracao = true;
                
            }
        }
    }

     
    if(alteracao != true){
        system("cls");

        cout << "======================================================" << endl;
        cout << "+++             > LOCACOES / CADASTRAR <           +++" << endl;
        cout << "======================================================" << endl;

        cout << endl << "PLACA NAO ENCONTRADA!!!" << endl;
    }

    if (alteracao == true){
        cout << endl << "CADASTRO REALIZADO!!!" << endl;
    }

    salvar();
    lendoRegistro();

    cout << endl << "Deseja cadastrar mais alguma locacao? (s/n): ";
    cin >> opLocacoesCadastrar;

    switch (opLocacoesCadastrar)
    {

    case 's':
    case 'S':
        system("cls");
        locacoesCadastrar();
        break;

    case 'n':
    case 'N':
        system("cls");
        menuPrincipal();
        break;

    default:
        system("cls");
        menuPrincipal();
    }
}



//LOCACOES EDITAR
//--------------------------------------------------------------------------------
void locacoesEditar()
{
    lendoRegistro();
    
    system("cls");

    cout << "======================================================" << endl;
    cout << "+++              > LOCACOES / EDITAR <             +++" << endl;
    cout << "======================================================" << endl;

    cout << endl << "Digite a placa do veiculo: ";
    cin >> placa;
    system("cls");

    cout << "======================================================" << endl;
    cout << "+++              > LOCACOES / EDITAR <             +++" << endl;
    cout << "======================================================" << endl;

    string dados;         // recebe os dados
    char opLocacoesEditar; // usado no "switch case"
    bool alteracao; // usada pra verificar se foi feita a alteracao nos dados

    for (int i = 0; i < 50; i++)
    {

        for (int j = 0; j < 10; j++)
        {

            dados = registro[i][j];

            if (dados == placa)
            {
                cout << endl << "Insira os novos dados da locacao:" << endl << endl;
                cout << "STATUS (1-Disponivel | 2-Locado | 3-Manutencao): ";
                cin >> status;

                if(status == "1"){registro[i][j + 8] = "DISPONIVEL";}
                if(status == "2"){registro[i][j + 8] = "LOCADO";}
                if(status == "3"){registro[i][j + 8] = "MANUTENCAO";}


                cin.ignore();

                if (registro[i][j + 8] != "LOCADO")
                {
                    registro[i][j + 9] = "*";
                }

                if (registro[i][j + 8] == "LOCADO")
                {
                    cout << "LOCATARIO: ";
                    getline (cin, registro[i][j + 9]);
                }
                

                system("cls");

                cout << "======================================================" << endl;
                cout << "+++              > LOCACOES / EDITAR <             +++" << endl;
                cout << "======================================================" << endl;

                alteracao = true;
                
            }
        }
    }

     
    if(alteracao != true){
        system("cls");

        cout << "======================================================" << endl;
        cout << "+++              > LOCACOES / EDITAR <             +++" << endl;
        cout << "======================================================" << endl;

        cout << endl << "PLACA NAO ENCONTRADA!!!" << endl;
    }

    if (alteracao == true){
        cout << endl << "DADOS ATUALIZADOS!!!" << endl;
    }

    salvar();
    lendoRegistro();

    cout << endl << "Deseja editar mais alguma locacao? (s/n): ";
    cin >> opLocacoesEditar;

    switch (opLocacoesEditar)
    {

    case 's':
    case 'S':
        system("cls");
        locacoesEditar();
        break;

    case 'n':
    case 'N':
        system("cls");
        menuPrincipal();
        break;

    default:
        system("cls");
        menuPrincipal();
    }
}



//LOCACOES DEVOLVER
//--------------------------------------------------------------------------------
void locacoesDevolver()
{
    lendoRegistro();
    
    system("cls");

    cout << "======================================================" << endl;
    cout << "+++             > LOCACOES / DEVOLUCAO <           +++" << endl;
    cout << "======================================================" << endl;

    cout << endl << "Digite a placa do veiculo: ";
    cin >> placa;
    system("cls");

    cout << "======================================================" << endl;
    cout << "+++             > LOCACOES / DEVOLUCAO <           +++" << endl;
    cout << "======================================================" << endl;

    string dados;         // recebe os dados
    char opLocacoesDevolver; // usado no "switch case"
    bool alteracao; // usada pra verificar se foi feita a alteracao nos dados

    for (int i = 0; i < 50; i++)
    {

        for (int j = 0; j < 10; j++)
        {

            dados = registro[i][j];

            if (dados == placa)
            {
                if (registro[i][j + 8] == "DISPONIVEL")
                {
                    cout << endl << "VEICULO JA ESTAVA DISPONIVEL!!!" << endl;

                    cout << endl << "Deseja devolver OUTRO veiculo? (s/n): ";
                    cin >> opLocacoesDevolver;

                    switch (opLocacoesDevolver)
                    {

                    case 's':
                    case 'S':
                        system("cls");
                        locacoesDevolver();
                        break;

                    case 'n':
                    case 'N':
                        system("cls");
                        menuPrincipal();
                        break;

                    default:
                        system("cls");
                        menuPrincipal();
                    }
                }

                if (registro[i][j + 8] == "MANUTENCAO")
                {
                    cout << endl << "VEICULO ESTA EM MANUTENCAO!!!" << endl;

                    cout << endl << "Deseja devolver OUTRO veiculo? (s/n): ";
                    cin >> opLocacoesDevolver;

                    switch (opLocacoesDevolver)
                    {

                    case 's':
                    case 'S':
                        system("cls");
                        locacoesDevolver();
                        break;

                    case 'n':
                    case 'N':
                        system("cls");
                        menuPrincipal();
                        break;

                    default:
                        system("cls");
                        menuPrincipal();
                    }
                }

                if (registro[i][j + 8] == "LOCADO")
                {
                    registro[i][j + 8] = "DISPONIVEL";
                    registro[i][j + 9] = "*";
                }                

                system("cls");

                cout << "======================================================" << endl;
                cout << "+++             > LOCACOES / DEVOLUCAO <           +++" << endl;
                cout << "======================================================" << endl;

                alteracao = true;
                
            }
        }
    }

     
    if(alteracao != true){
        system("cls");

        cout << "======================================================" << endl;
        cout << "+++             > LOCACOES / DEVOLUCAO <           +++" << endl;
        cout << "======================================================" << endl;

        cout << endl << "PLACA NAO ENCONTRADA!!!" << endl;
    }

    if (alteracao == true){
        cout << endl << "DEVOLUCAO REALIZADA!!!" << endl;
    }

    salvar();
    lendoRegistro();

    cout << endl << "Deseja devolver mais algum veiculo? (s/n): ";
    cin >> opLocacoesDevolver;

    switch (opLocacoesDevolver)
    {

    case 's':
    case 'S':
        system("cls");
        locacoesDevolver();
        break;

    case 'n':
    case 'N':
        system("cls");
        menuPrincipal();
        break;

    default:
        system("cls");
        menuPrincipal();
    }
}



//LOCACOES CONSULTAR
//--------------------------------------------------------------------------------
void locacoesConsultar()
{
    lendoRegistro();
    system("cls");

    cout << "======================================================" << endl;
    cout << "+++           > LOCACOES / CONSULTA <            +++" << endl;
    cout << "======================================================" << endl;
    cout << endl;

    string statusDesejado = "LOCADO";

    int contadorCarros=0;

    for (int i=0; i<contadorLinha; i++)
    {
        for (int j=0; j<10; j++)
        {
            if (registro[i][j] == statusDesejado)
            {
                contadorCarros++;

                cout << "...................... VEICULO 0" << contadorCarros << " ...................." << endl;

                cout << "PLACA: " << registro[i][j-8] << endl;
                cout << "MARCA: " <<  registro[i][j-7] << endl;
                cout << "MODELO: " <<  registro[i][j-6] << endl;
                cout << "MOTOR: " <<  registro[i][j-5] << endl;
                cout << "ANO: " <<  registro[i][j-4] << endl;
                cout << "KM: " <<  registro[i][j-3] << endl;
                cout << "CATEGORIA: " <<  registro[i][j-2] << endl;
                cout << "VALOR: " <<  registro[i][j-1] << endl;
                cout << "STATUS: " <<  registro[i][j] << endl;
                cout << "LOCATARIO: " <<  registro[i][j+1] << endl;   
            }

            if (j==10)
            {
                j=0;
            }
        }
    }

    cout << endl;
    cout << "....................................................." << endl;

    if (contadorCarros == 0)
    {
        cout << "NENHUM veiculo locado no momento!" << endl;
    }else
    {
        cout << "Existe(m) 0" << contadorCarros << " carro(s) locado(s) no momento." << endl;
    }

    cout << "....................................................." << endl;

    char opVeiculoConsultar;
    cout << endl << "Deseja voltar para menu LOCACOES? (s/n): ";
    cin >> opVeiculoConsultar;

    switch (opVeiculoConsultar)
    {

    case 's':
    case 'S':
        system("cls");
        menuLocacoes();
        break;

    case 'n':
    case 'N':
        system("cls");
        menuPrincipal();
        break;

    default:
        system("cls");
        menuPrincipal();
    }
}



// MENU VEICULOS
//--------------------------------------------------------------------------------

void menuVeiculos()
{

    system("cls");
    int opMenuVeiculos = 0;
    cout << "======================================================" << endl;
    cout << "+++                  > VEICULOS <                  +++" << endl;
    cout << "======================================================" << endl;
    cout << endl;
    cout << "Selecione uma opcao: " << endl;
    cout << endl;
    cout << "1 - CADASTRAR" << endl;
    cout << "2 - EDITAR" << endl;
    cout << "3 - CONSULTAR" << endl;
    cout << "4 - Voltar" << endl;
    cout << "5 - Sair" << endl;
    cout << endl;
    cout << "======================================================" << endl;
    cin >> opMenuVeiculos;

    switch (opMenuVeiculos)
    {

    case 1:
        system("cls");
        veiculosCadastrar();
        break;

    case 2:
        system("cls");
        veiculosEditar();
        break;

    case 3:
        system("cls");
        veiculosConsultar();
        break;

    case 4:
        system("cls");
        menuPrincipal();
        break;

    case 5:
        system("cls");
        sair();
        break;

    default:
        system("cls");
        cout << "OCPCAO INCORRETA, digite novamente!" << endl
             << endl;
        menuVeiculos();
    }
}



// VEICULOS CADASTRAR  - SALVA DIRETAMENTE NO ARQUIVO TXT (não necessita da função "salvar")
//--------------------------------------------------------------------------------
void veiculosCadastrar()
{

    system("cls");
    char opVeiculoCadastrar;

    cout << "======================================================" << endl;
    cout << "+++            > VEICULOS / CADASTRAR <            +++" << endl;
    cout << "======================================================" << endl;
    cout << endl;

    ofstream arqVeiculosSaida;
    arqVeiculosSaida.open("registro.txt", ios::app);

    cin.ignore();

    cout << "PLACA: ";
    cin >> placa;

    // VERIFICA SE A PLACA JÁ NÃO ESTÁ LOCADA
    for (int i = 0; i < 50; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            if (registro[i][j] == placa)
            {
                while (registro[i][j] == placa)
                {
                    system("cls");
                    cout << "======================================================" << endl;
                    cout << "+++            > VEICULOS / CADASTRAR <            +++" << endl;
                    cout << "======================================================" << endl;

                    cout << endl << "VEICULO JA CADASTRADO!!!" << endl << endl;

                    cout << "Deseja cadastrar OUTRO veiculo? (s/n): ";
                    cin >> opVeiculoCadastrar;

                    switch (opVeiculoCadastrar)
                    {

                    case 's':
                        veiculosCadastrar();
                        break;

                    case 'S':
                        veiculosCadastrar();
                        break;

                    case 'n':
                        system("cls");
                        menuPrincipal();
                        break;

                    case 'N':
                        system("cls");
                        menuPrincipal();
                        break;

                    default:
                        system("cls");
                        menuPrincipal();
                    }
                }
            }
        }
    }

    cin.ignore();

    cout << "MARCA: ";
    getline(cin, marca);

    cout << "MODELO: ";
    getline(cin, modelo);

    cout << "MOTOR (ex.: 1.0): ";
    getline(cin, motor);

    cout << "ANO: ";
    getline(cin, ano);

    cout << "KM: ";
    getline(cin, km);

    cout << "CATEGORIA (1-Economico | 2-Intermediario | 3-Luxo): ";
    cin >> categoria;
    if (categoria == "1"){categoria = "ECONOMICO";}
    if (categoria == "2"){categoria = "INTERMEDIARIO";}
    if (categoria == "3"){categoria = "LUXO";}

    cout << "VALOR (de locacao): ";
    cin.ignore();
    getline(cin, valor);

    cout << "STATUS (1-Disponivel | 2-Locado | 3-Manutencao): ";
    cin >> status;
    if (status == "1"){status = "DISPONIVEL";}
    if (status == "2"){status = "LOCADO";}
    if (status == "3"){status = "MANUTENCAO";}

    arqVeiculosSaida << placa << endl;
    arqVeiculosSaida << marca << endl;
    arqVeiculosSaida << modelo << endl;
    arqVeiculosSaida << motor << endl;
    arqVeiculosSaida << ano << endl;
    arqVeiculosSaida << km << endl;
    arqVeiculosSaida << categoria << endl;
    arqVeiculosSaida << valor << endl;
    arqVeiculosSaida << status << endl;
    arqVeiculosSaida << "*" << endl;

    cout << endl;
    cout << "Deseja cadastrar mais algum veiculo? (s/n): " << endl;
    cin >> opVeiculoCadastrar;

    switch (opVeiculoCadastrar)
    {

    case 's':
        veiculosCadastrar();
        break;

    case 'S':
        veiculosCadastrar();
        break;

    case 'n':
        system("cls");
        menuPrincipal();
        break;

    case 'N':
        system("cls");
        menuPrincipal();
        break;

    default:
        system("cls");
        menuPrincipal();
    }

    arqVeiculosSaida.close();
}



//VEICULOS EDITAR
//--------------------------------------------------------------------------------
void veiculosEditar()
{

    lendoRegistro();
    system("cls");

    cout << "======================================================" << endl;
    cout << "+++              > VEICULOS / EDITAR <             +++" << endl;
    cout << "======================================================" << endl;

    cout << endl << "Digite a placa do veiculo a ser editado: ";
    cin >> placa;
    system("cls");

    cout << "======================================================" << endl;
    cout << "+++              > VEICULOS / EDITAR <             +++" << endl;
    cout << "======================================================" << endl;

    string dados;         // recebe os dados
    char opVeiculoEditar; // usado no "switch case"
    bool alteracao; // usada pra verificar se foi feita a alteracao nos dados

    for (int i = 0; i < 50; i++)
    {

        for (int j = 0; j < 10; j++)
        {

            dados = registro[i][j];

            if (dados == placa)
            {
                cout << endl << "Insira os novos dados:" << endl << endl;
                cout << "MARCA: ";
                cin.ignore();
                getline (cin, registro[i][j + 1]);
                cout << "MODELO: ";
                getline (cin, registro[i][j + 2]);
                cout << "MOTOR (ex.: 1.0): ";
                getline (cin, registro[i][j + 3]);
                cout << "ANO: ";
                getline (cin, registro[i][j + 4]);
                cout << "KM: ";
                getline (cin, registro[i][j + 5]);

                cout << "CATEGORIA (1-Economico | 2-Intermediario | 3-Luxo): ";
                cin >> categoria;
                if(categoria == "1"){registro[i][j + 6] = "ECONOMICO";}
                if(categoria == "2"){registro[i][j + 6] = "INTERMEDIARIO";}
                if(categoria == "3"){registro[i][j + 6] = "LUXO";}

                cin.ignore();             
                cout << "VALOR (de locacao): ";
                getline (cin, registro[i][j + 7]);

                
                cout << "STATUS (1-Disponivel | 2-Locado | 3-Manutencao): ";
                cin >> status;
                if(status == "1"){registro[i][j + 8] = "DISPONIVEL"; registro[i][j + 9] = "*";}
                if(status == "2"){registro[i][j + 8] = "LOCADO";}
                if(status == "3"){registro[i][j + 8] = "MANUTENCAO"; registro[i][j + 9] = "*";}

                system("cls");

                cout << "======================================================" << endl;
                cout << "+++              > VEICULOS / EDITAR <             +++" << endl;
                cout << "======================================================" << endl;

                alteracao = true;
                
            }
        }
    }

     
    if(alteracao != true){
        system("cls");

        cout << "======================================================" << endl;
        cout << "+++              > VEICULOS / EDITAR <             +++" << endl;
        cout << "======================================================" << endl;

        cout << endl << "PLACA NAO ENCONTRADA!!!" << endl;
    }

    if (alteracao == true){
        cout << endl << "DADOS ATUALIZADOS!!!" << endl;
    }

    salvar();
    lendoRegistro();

    cout << endl << "Deseja editar mais algum veiculo? (s/n): ";
    cin >> opVeiculoEditar;

    switch (opVeiculoEditar)
    {

    case 's':
    case 'S':
        system("cls");
        veiculosEditar();
        break;

    case 'n':
    case 'N':
        system("cls");
        menuPrincipal();
        break;

    default:
        system("cls");
        menuPrincipal();
    }

}



// VEICULOS CONSULTAR
//--------------------------------------------------------------------------------
void veiculosConsultar()
{

    lendoRegistro();

    system("cls");
    int opVeiculosConsultar = 0;
    cout << "======================================================" << endl;
    cout << "+++            > VEICULOS / CONSULTAR <            +++" << endl;
    cout << "======================================================" << endl;
    cout << endl;
    cout << "Selecione uma opcao: " << endl;
    cout << endl;
    cout << "1 - Todos" << endl;
    cout << "2 - Por Marca" << endl;
    cout << "3 - Por Motor" << endl;
    cout << "4 - Por Categoria" << endl;
    cout << "5 - Por Status" << endl;
    cout << "6 - Voltar" << endl;
    cout << "7 - Sair" << endl;
    cout << endl;
    cout << "======================================================" << endl;
    cin >> opVeiculosConsultar;

    switch (opVeiculosConsultar)
    {

    case 1:
        veiculosConsultarTodos();
        break;

    case 2:
        veiculosConsultarMarca();
        break;

    case 3:
        system("cls");
        veiculosConsultarMotor();
        break;

    case 4:
        system("cls");
        veiculosConsultarCategoria();
        break;

    case 5:
        system("cls");
        veiculosConsultarStatus();
        break;

    case 6:
        system("cls");
        menuVeiculos();
        break;
    
    case 7:
        system("cls");
        sair();
        break;

    default:
        system("cls");
        cout << "OCPCAO INCORRETA, digite novamente!" << endl
             << endl;
        menuVeiculos();
    }
}



// VEICULOS CONSULTAR - TODOS
//--------------------------------------------------------------------------------
void veiculosConsultarTodos()
{
    lendoRegistro();

    system("cls");
    char opVeiculoConsultar;
    int contadorCarros=0;

    cout << "======================================================" << endl;
    cout << "+++       > TODOS OS VEICULOS CADASTRADOS <        +++" << endl;
    cout << "======================================================" << endl;
    cout << endl;

    for (int i=0; i<contadorLinha; i++)
    {
        contadorCarros++;
        cout << "...................... VEICULO 0" << i+1 << " ...................." << endl;

        for (int j=0; j<10; j++)
        {
            if(j==0){cout<<"PLACA: ";}
            if(j==1){cout<<"MARCA: ";}
            if(j==2){cout<<"MODELO: ";}
            if(j==3){cout<<"MOTOR: ";}
            if(j==4){cout<<"ANO: ";}
            if(j==5){cout<<"KM: ";}
            if(j==6){cout<<"CATEGORIA: ";}
            if(j==7){cout<<"VALOR: ";}
            if(j==8){cout<<"STATUS: ";}
            if(j==9){cout<<"LOCATARIO: ";}
            
            cout << registro[i][j] << endl;
       
            if (j==10)
            {
                j=0;
            }
        }
    }

    cout << endl;
    cout << "....................................................." << endl;

    if (contadorCarros == 0)
    {
        cout << "NENHUM carro encontrado no resgistro!" << endl;
    }else
    {
        cout << "Existe(m) 0" << contadorCarros << " carro(s) no registro." << endl;
    }

    cout << "....................................................." << endl;

    cout << endl << "Deseja fazer uma nova consulta? (s/n): ";
    cin >> opVeiculoConsultar;

    switch (opVeiculoConsultar)
    {

    case 's':
    case 'S':
        system("cls");
        veiculosConsultar();
        break;

    case 'n':
    case 'N':
        system("cls");
        menuPrincipal();
        break;

    default:
        system("cls");
        menuPrincipal();
    }

}



// VEICULOS CONSULTAR - POR MARCA
//--------------------------------------------------------------------------------
void veiculosConsultarMarca()
{
    lendoRegistro();

    system("cls");
    cout << "======================================================" << endl;
    cout << "+++       > VEICULOS / CONSULTA POR MARCA <        +++" << endl;
    cout << "======================================================" << endl;

    string marcaDesejada;
    cout << endl << "Digite o nome da MARCA desejada: ";
    cin >> marcaDesejada;

    int contadorCarros=0;

    for (int i=0; i<contadorLinha; i++)
    {
        for (int j=0; j<10; j++)
        {
            if (registro[i][j] == marcaDesejada)
            {
                contadorCarros++;

                cout << endl << "...................... VEICULO 0" << contadorCarros << " ...................." << endl;

                cout << "PLACA: " << registro[i][j-1] << endl;
                cout << "MARCA: " <<  registro[i][j] << endl;
                cout << "MODELO: " <<  registro[i][j+1] << endl;
                cout << "MOTOR: " <<  registro[i][j+2] << endl;
                cout << "ANO: " <<  registro[i][j+3] << endl;
                cout << "KM: " <<  registro[i][j+4] << endl;
                cout << "CATEGORIA: " <<  registro[i][j+5] << endl;
                cout << "VALOR: " <<  registro[i][j+6] << endl;
                cout << "STATUS: " <<  registro[i][j+7] << endl;
 
            }
        }
    }

    cout << endl;
    cout << "....................................................." << endl;

    if (contadorCarros == 0)
    {
        cout << "NENHUM carro encontrato dessa MARCA!" << endl;
    }else
    {
        cout << "Existe(m) 0" << contadorCarros << " carro(s) registrado(s) com essa MARCA." << endl;
    }

    cout << "....................................................." << endl;

    char opVeiculoConsultar;
    cout << endl << "Deseja fazer uma nova consulta? (s/n): ";
    cin >> opVeiculoConsultar;

    switch (opVeiculoConsultar)
    {

    case 's':
    case 'S':
        system("cls");
        veiculosConsultar();
        break;

    case 'n':
    case 'N':
        system("cls");
        menuPrincipal();
        break;

    default:
        system("cls");
        menuPrincipal();
    }
}



// VEICULOS CONSULTAR - POR MOTOR
//--------------------------------------------------------------------------------
void veiculosConsultarMotor()
{

    lendoRegistro();

    system("cls");
    cout << "======================================================" << endl;
    cout << "+++       > VEICULOS / CONSULTA POR MOTOR <        +++" << endl;
    cout << "======================================================" << endl;

    string motorDesejado;
    cout << endl << "Digite o MOTOR desejado: ";
    cin >> motorDesejado;

    int contadorCarros=0;

    for (int i=0; i<contadorLinha; i++)
    {
        for (int j=0; j<10; j++)
        {
            if (registro[i][j] == motorDesejado)
            {
                contadorCarros++;

                cout << endl << "...................... VEICULO 0" << contadorCarros << " ...................." << endl;

                cout << "PLACA: " << registro[i][j-3] << endl;
                cout << "MARCA: " <<  registro[i][j-2] << endl;
                cout << "MODELO: " <<  registro[i][j-1] << endl;
                cout << "MOTOR: " <<  registro[i][j] << endl;
                cout << "ANO: " <<  registro[i][j+1] << endl;
                cout << "KM: " <<  registro[i][j+2] << endl;
                cout << "CATEGORIA: " <<  registro[i][j+3] << endl;
                cout << "VALOR: " <<  registro[i][j+4] << endl;
                cout << "STATUS: " <<  registro[i][j+5] << endl;

                
            }

            if (j==10)
            {
                j=0;
            }
        }
    }

    cout << endl;
    cout << "....................................................." << endl;

    if (contadorCarros == 0)
    {
        cout << "NENHUM carro encontrato com esse MOTOR!" << endl;
    }else
    {
        cout << "Existe(m) 0" << contadorCarros << " carro(s) registrado(s) com esse MOTOR." << endl;
    }

    cout << "....................................................." << endl;

    char opVeiculoConsultar;
    cout << endl << "Deseja fazer uma nova consulta? (s/n): ";
    cin >> opVeiculoConsultar;

    switch (opVeiculoConsultar)
    {

    case 's':
    case 'S':
        system("cls");
        veiculosConsultar();
        break;

    case 'n':
    case 'N':
        system("cls");
        menuPrincipal();
        break;

    default:
        system("cls");
        menuPrincipal();
    }
}



// VEICULOS CONSULTAR - POR CATEGORIA
//--------------------------------------------------------------------------------
void veiculosConsultarCategoria()
{

    lendoRegistro();

    system("cls");
    cout << "======================================================" << endl;
    cout << "+++     > VEICULOS / CONSULTA POR CATEGORIA <      +++" << endl;
    cout << "======================================================" << endl;

    string categoriaDesejada;
    cout << endl << "Digite o nome da CATEGORIA desejada CATEGORIA" << endl << "(1-Economico | 2-Intermediario | 3-Luxo): ";
    cin >> categoriaDesejada;

    if (categoriaDesejada == "1"){categoriaDesejada = "ECONOMICO";}
    if (categoriaDesejada == "2"){categoriaDesejada = "INTERMEDIARIO";}
    if (categoriaDesejada == "3"){categoriaDesejada = "LUXO";}

    int contadorCarros=0;

    for (int i=0; i<contadorLinha; i++)
    {
        for (int j=0; j<10; j++)
        {
            if (registro[i][j] == categoriaDesejada)
            {
                contadorCarros++;

                cout << endl << "...................... VEICULO 0" << contadorCarros << " ...................." << endl;

                cout << "PLACA: " <<  registro[i][j-6] << endl;
                cout << "MARCA: " <<  registro[i][j-5] << endl;
                cout << "MODELO: " <<  registro[i][j-4] << endl;
                cout << "MOTOR: " <<  registro[i][j-3] << endl;
                cout << "ANO: " <<  registro[i][j-2] << endl;
                cout << "KM: " <<  registro[i][j-1] << endl;
                cout << "CATEGORIA: " <<  registro[i][j] << endl;
                cout << "VALOR: " <<  registro[i][j+1] << endl;
                cout << "STATUS: " <<  registro[i][j+2] << endl;
            }
        }
    }

    cout << endl;
    cout << "....................................................." << endl;

    if (contadorCarros == 0)
    {
        cout << "NENHUM carro encontrato dessa CATEGORIA!" << endl;
    }else
    {
        cout << "Existe(m) 0" << contadorCarros << " carro(s) registrado(s) dessa CATEGORIA." << endl;
    }

    cout << "....................................................." << endl;

    char opVeiculoConsultar;
    cout << endl << "Deseja fazer uma nova consulta? (s/n): ";
    cin >> opVeiculoConsultar;

    switch (opVeiculoConsultar)
    {

    case 's':
    case 'S':
        system("cls");
        veiculosConsultar();
        break;

    case 'n':
    case 'N':
        system("cls");
        menuPrincipal();
        break;

    default:
        system("cls");
        menuPrincipal();
    }
}



// VEICULOS CONSULTAR - POR STATUS
//--------------------------------------------------------------------------------
void veiculosConsultarStatus()
{

    lendoRegistro();

    system("cls");
    cout << "======================================================" << endl;
    cout << "+++       > VEICULOS / CONSULTA POR STATUS <       +++" << endl;
    cout << "======================================================" << endl;

    string statusDesejado;
    cout << endl << "Digite o STATUS desejado" << endl << "(1-Disponivel | 2-Locado | 3-Manutencao): ";
    cin >> statusDesejado;

    if (statusDesejado == "1"){statusDesejado = "DISPONIVEL";}
    if (statusDesejado == "2"){statusDesejado = "LOCADO";}
    if (statusDesejado == "3"){statusDesejado = "MANUTENCAO";}

    int contadorCarros=0;

    for (int i=0; i<contadorLinha; i++)
    {
        for (int j=0; j<10; j++)
        {
            if (registro[i][j] == statusDesejado)
            {
                contadorCarros++;

                cout << endl << "...................... VEICULO 0" << contadorCarros << " ...................." << endl;

                cout << "PLACA: " <<  registro[i][j-8] << endl;
                cout << "MARCA: " <<  registro[i][j-7] << endl;
                cout << "MODELO: " <<  registro[i][j-6] << endl;
                cout << "MOTOR: " <<  registro[i][j-5] << endl;
                cout << "ANO: " <<  registro[i][j-4] << endl;
                cout << "KM: " <<  registro[i][j-3] << endl;
                cout << "CATEGORIA: " <<  registro[i][j-2] << endl;
                cout << "VALOR: " <<  registro[i][j-1] << endl;
                cout << "STATUS: " <<  registro[i][j] << endl;   
            }
        }
    }

    cout << endl;
    cout << "....................................................." << endl;

    if (contadorCarros == 0)
    {
        cout << "NENHUM carro encontrato nesse STATUS!" << endl;
    }else
    {
        cout << "Existe(m) 0" << contadorCarros << " carro(s) registrado(s) nesse STATUS." << endl;
    }

    cout << "....................................................." << endl;

    char opVeiculoConsultar;
    cout << endl << "Deseja fazer uma nova consulta? (s/n): ";
    cin >> opVeiculoConsultar;

    switch (opVeiculoConsultar)
    {

    case 's':
    case 'S':
        system("cls");
        veiculosConsultar();
        break;

    case 'n':
    case 'N':
        system("cls");
        menuPrincipal();
        break;

    default:
        system("cls");
        menuPrincipal();
    }
}

//--------------------------------------------------------------------------------
