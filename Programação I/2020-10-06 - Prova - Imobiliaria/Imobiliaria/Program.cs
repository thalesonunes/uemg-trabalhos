using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria
{

    //ATUALIZADO 06/10/2020 6:27
    class Program
    {
        
        //LISTAS
        static List<Cliente> listaDeClientes = new List<Cliente>();
        static List<Funcionario> listaDeFuncionarios = new List<Funcionario>();
        static List<Venda> listaDeVendas = new List<Venda>();
        static List<Aluguel> listaDeAlugueis = new List<Aluguel>();
        static List<Casa> listaDeCasas = new List<Casa>();
        static List<Terreno> listaDeTerrenos = new List<Terreno>();
        static List<Apartamento> listaDeApartamentos = new List<Apartamento>();
        static List<Endereco> listaDeEnderecos = new List<Endereco>();


        //FUNÇOES DE BUSCA

        //FUNÇÃO BUSCAR CLIENTE POR NOME
        static Cliente buscarCliente(string codigocli)
        {
            foreach (Cliente cli in listaDeClientes)
            {
                if (cli.getNome() == codigocli)
                {
                    return cli;
                }
            }
            return null;
        }


        //FUNÇÃO BUSCAR FUNCIONARIO POR NOME
        static Funcionario buscarFuncionario(string codigofun)
        {
            foreach (Funcionario fun in listaDeFuncionarios)
            {
                if (fun.getNome() == codigofun)
                {
                    return fun;
                }
            }
            return null;
        }


        //FUNÇÃO BUSCAR IMÓVEL CASA POR LOTE
        static Casa buscarCasa(string codigolote, int codigoquadra)
        {
            foreach (Casa casa in listaDeCasas)
            {
                if ((casa.getQuadra() == codigoquadra && casa.getLote() == codigolote))
                {
                    return casa;
                }
            }
            return null; 
        }


        //FUNÇÃO BUSCAR IMÓVEL TERRENO POR LOTE
        static Terreno buscarTerreno(string codigolote, int codigoquadra)
        {
            foreach (Terreno terreno in listaDeTerrenos)
            {
                if ((terreno.getQuadra() == codigoquadra && terreno.getLote() == codigolote))
                {
                    return terreno;
                }
            }
            return null;
        }


        //FUNÇÃO BUSCAR IMÓVEL APARTAMENTO POR LOTE
        static Apartamento buscarApartamento(string codigolote, int codigoquadra)
        {
            foreach (Apartamento apartamento in listaDeApartamentos)
            {
                if ((apartamento.getQuadra() == codigoquadra && apartamento.getLote() == codigolote))
                {
                    return apartamento;
                }
            }
            return null;
        }


        //FUNÇÃO BUSCAR VENDA PELO VALOR TOTAL
        static Venda buscarVenda(double codigoven)
        {
            foreach (Venda ven in listaDeVendas)
            {
                if (ven.getValorTotal() == codigoven)
                {
                    return ven;
                }
            }
            return null;
        }


        //FUNÇÃO BUSCAR ALUGUEL PELO MENSAL
        static Aluguel buscarAluguel(int codigoal)
        {
            foreach (Aluguel al in listaDeAlugueis)
            {
                if (al.getMensal() == codigoal)
                {
                    return al;
                }
            }
            return null;
        }


        //FUNÇÃO BUSCAR IMÓVEL CASA PELA SITUAÇÃO
        static Casa buscarCasaSit(string codigocassit)
        {
            foreach (Casa cassit in listaDeCasas)
            {
                if (cassit.getSituacao() == codigocassit)
                {
                    return cassit;
                }
            }
            return null;
        }


        //FUNÇÃO BUSCAR IMÓVEL TERRENO PELA SITUAÇÃO
        static Terreno buscarTerrenoSit(string codigotesit)
        {
            foreach (Terreno tesit in listaDeTerrenos)
            {
                if (tesit.getSituacao() == codigotesit)
                {
                    return tesit;
                }
            }
            return null;
        }


        //FUNÇÃO BUSCAR IMÓVEL APPARTAMENTO PELA SITUAÇÃO
        static Apartamento buscarApartamentoSit(string codigoapsit)
        {
            foreach (Apartamento apsit in listaDeApartamentos)
            {
                if (apsit.getSituacao() == codigoapsit)
                {
                    return apsit;
                }
            }
            return null;
        }


        static void Main(string[] args)
        {
            
            int Opcao;

            do
            {
                //MENU PRINCIPAL
                Console.Clear();
                Console.Write("*****************************************************************\n");
                Console.Write("****************** DIGITE A OPÇÃO DESEJADA **********************\n");
                Console.Write("*****************************************************************\n");
                Console.Write("[1]  - CADASTRO DE IMÓVEL\n");
                Console.Write("*****************************************************************\n");
                Console.Write("[2]  - CADASTRO DE PESSOA (FUNCIONÁRIO/CLIENTE)\n");
                Console.Write("*****************************************************************\n");
                Console.Write("[3]  - GERENCIAMENTO DE VENDA E ALUGUÉIS\n");
                Console.Write("*****************************************************************\n");
                Console.Write("[4]  - CONSUTA DE IMÓVEL PELA SITUAÇÃO\n");
                Console.Write("*****************************************************************\n");
                Console.Write("[5]  - CONSULTA DE FUNCIONÁRIOS\n");
                Console.Write("*****************************************************************\n");
                Console.Write("[6]  - CONSULTA DE CLIENTES\n");
                Console.Write("*****************************************************************\n");
                Console.Write("[7]  - CONSULTA DE IMÓVEL POR CLIENTE\n");
                Console.Write("*****************************************************************\n");
                Console.Write("[8]  - CONSULTA DE SALÁRIO E ACRÉSCIMO DE COMISSÃO DE FUNCIONÁRIO\n");
                Console.Write("*****************************************************************\n");
                Console.Write("[9]  - CONSULTA DE LISTAS DE CADASTROS\n");
                Console.Write("*****************************************************************\n");


                Opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();


                switch (Opcao)
                {
                    case 1://CADASTRO DE IMÓVEL
                        {
                            int op;
                            Console.Write("*****************************************************************\n");
                            Console.Write("*********  SELECIONE O TIPO DE IMÓVEL A SER CADASTRADO  *********\n");
                            Console.Write("*****************************************************************\n");
                            Console.Write("[1]  - CADASTRO DE CASA\n");
                            Console.Write("*****************************************************************\n");
                            Console.Write("[2]  - CADASTRO DE TERRENO\n");
                            Console.Write("*****************************************************************\n");
                            Console.Write("[3]  - CADASTRO DE APARTAMENTO\n");
                            Console.Write("*****************************************************************\n");

                            op = int.Parse(Console.ReadLine());
                            Console.WriteLine();


                            if (op == 1)//CADASTRO DE CASA
                            {

                                Cliente clienteNovo = new Cliente();
                                Funcionario funcionarioNovo = new Funcionario();
                                Venda vendaNova = new Venda();
                                Aluguel aluguelNovo = new Aluguel();
                                Endereco enderecoNovo = new Endereco();
                                Casa casaNova = new Casa();
                                Terreno terrenoNovo = new Terreno();
                                Apartamento apartamentoNovo = new Apartamento();
                                

                                //USUÁRIO INSERINDO DADOS DA CASA
                                casaNova.cadastroCasa(casaNova, listaDeCasas, enderecoNovo, clienteNovo);

                                //USUÁRIO INSERINDO DADOS DO ENDEREÇO
                                enderecoNovo.cadastroEndereco(enderecoNovo, listaDeEnderecos);

                                //ASSOCIAÇÃO ENDEREÇO
                                casaNova.setEndereco(enderecoNovo);

                                //INSERIR ENDEREÇO NA LISTA DE ENDEREÇOS
                                listaDeEnderecos.Add(enderecoNovo);

                                //INSERIR CASA NA LISTA DE CASAS
                                listaDeCasas.Add(casaNova);

                                Console.WriteLine("");
                                Console.WriteLine("*************** CADASTRO REALIZADO COM SUCESSO *************");
                                Console.WriteLine("");

                                //MOSTRAR DADOS DA CASA
                                casaNova.mostraDadosCasa();
                                
                                Console.WriteLine("");
                                Console.WriteLine("Aperte ENTER para continuar...\n");

                                Console.ReadKey();

                            }

                            else if (op == 2)//CADASTRO DE TERRENO
                            {

                                Cliente clienteNovo = new Cliente();
                                Funcionario funcionarioNovo = new Funcionario();
                                Venda vendaNova = new Venda();
                                Aluguel aluguelNovo = new Aluguel();
                                Endereco enderecoNovo = new Endereco();
                                Casa casaNova = new Casa();
                                Terreno terrenoNovo = new Terreno();
                                Apartamento apartamentoNovo = new Apartamento();

                                //USUÁRIO INSERINDO DADOS DO ENDEREÇO
                                enderecoNovo.cadastroEndereco(enderecoNovo, listaDeEnderecos);

                                //USUÁRIO INSERINDO DADOS DO TERRENO
                                terrenoNovo.cadastroTerreno(terrenoNovo, listaDeTerrenos, enderecoNovo, clienteNovo);

                                //ASSOCIAÇÃO ENDEREÇO
                                terrenoNovo.setEndereco(enderecoNovo);

                                //INSERIR ENDEREÇO NA LISTA DE ENDEREÇOS
                                listaDeEnderecos.Add(enderecoNovo);

                                //INSERIR TERRENO NA LISTA DE TERRENOS
                                listaDeTerrenos.Add(terrenoNovo);
                                                              
                                Console.WriteLine("");
                                Console.WriteLine("*************** CADASTRO REALIZADO COM SUCESSO *************");
                                Console.WriteLine("");

                                //MOSTRAR DADOS DO TERRENO
                                terrenoNovo.mostraDadosTerreno();
                                
                                Console.WriteLine("");
                                Console.WriteLine("Aperte ENTER para continuar...\n");

                                Console.ReadKey();
                            }

                            else if (op == 3)//CADASTRO DE APARTAMENTO
                            {
                                Cliente clienteNovo = new Cliente();
                                Funcionario funcionarioNovo = new Funcionario();
                                Venda vendaNova = new Venda();
                                Aluguel aluguelNovo = new Aluguel();
                                Endereco enderecoNovo = new Endereco();
                                Casa casaNova = new Casa();
                                Terreno terrenoNovo = new Terreno();
                                Apartamento apartamentoNovo = new Apartamento();

                                //USUÁRIO INSERINDO DADOS DO ENDEREÇO
                                enderecoNovo.cadastroEndereco(enderecoNovo, listaDeEnderecos);

                                //USUÁRIO INSERINDO DADOS DO APARTAMENTO
                                apartamentoNovo.cadastroApartamento(apartamentoNovo, listaDeApartamentos, enderecoNovo, clienteNovo);

                                //ASSOCIAÇÃO ENDEREÇO
                                apartamentoNovo.setEndereco(enderecoNovo);

                                //INSERIR ENDEREÇO NA LISTA DE ENDEREÇOS
                                listaDeEnderecos.Add(enderecoNovo);

                                //INSERIR APARTAMENTO NA LISTA DE APARTAMENTOS
                                listaDeApartamentos.Add(apartamentoNovo);



                                Console.WriteLine("");
                                Console.WriteLine("*************** CADASTRO REALIZADO COM SUCESSO *************");
                                Console.WriteLine("");

                                //MOSTRAR DADOS DO APARAMENTO
                                apartamentoNovo.mostraDadosApartamento();

                                Console.WriteLine("");
                                Console.WriteLine("Aperte ENTER para continuar...\n");

                                Console.ReadKey();

                            }
                            else
                            {
                                Console.Write("");
                                Console.Write("*************** OPÇÃO INVÁLIDA *************\n");
                                Console.Write("");

                                Console.Write("Aperte ENTER para continuar...\n");
                                Console.ReadKey();
                            }

                        }
                        break;
                    
                    
                    case 2://CADASTRO DE CLIENTE E FUNCIONÁRIO
                        {
                            int op;
                            Console.Write("*****************************************************************\n");
                            Console.Write("*************  SELECIONE A PESSOA A SER CADASTRADA  *************\n");
                            Console.Write("*****************************************************************\n");
                            Console.Write("[1]  - CADASTRO DE CLIENTE\n");
                            Console.Write("*****************************************************************\n");
                            Console.Write("[2]  - CADASTRO DE FUNCIONÁRIO\n");
                            Console.Write("*****************************************************************\n");
                            
                            op = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            if (op == 1)//CADASTRO DE CLIENTE
                            {
                                Cliente clienteNovo = new Cliente();
                                Funcionario funcionarioNovo = new Funcionario();
                                Venda vendaNova = new Venda();
                                Aluguel aluguelNovo = new Aluguel();
                                Endereco enderecoNovo = new Endereco();
                                Casa casaNova = new Casa();
                                Terreno terrenoNovo = new Terreno();
                                Apartamento apartamentoNovo = new Apartamento();

                                //USUÁRIO INSERINDO DADOS DO ENDEREÇO
                                enderecoNovo.cadastroEndereco(enderecoNovo, listaDeEnderecos);

                                //USUÁRIO INSERINDO DADOS DO CLIENTE
                                clienteNovo.cadastroCliente(clienteNovo, listaDeClientes, enderecoNovo);

                                //ASSOCIAÇÃO ENDEREÇO
                                clienteNovo.setEndereco(enderecoNovo);

                                //INSERIR ENDEREÇO NA LISTA DE ENDEREÇOS
                                listaDeEnderecos.Add(enderecoNovo);

                                //INSERIR CLIENTE NA LISTA DE CLIENTES
                                listaDeClientes.Add(clienteNovo);

                                Console.WriteLine("");
                                Console.WriteLine("*************** CADASTRO REALIZADO COM SUCESSO *************");
                                Console.WriteLine("");

                                //MOSTRAR DADOS DO CLIENTE
                                clienteNovo.mostraDadosCliente();

                                Console.WriteLine("");
                                Console.WriteLine("Aperte ENTER para continuar...\n");

                                Console.ReadKey();

                            }

                            else if (op == 2)//CADASTRO FUNCIONÁRIO
                            {
                                Cliente clienteNovo = new Cliente();
                                Funcionario funcionarioNovo = new Funcionario();
                                Venda vendaNova = new Venda();
                                Aluguel aluguelNovo = new Aluguel();
                                Endereco enderecoNovo = new Endereco();
                                Casa casaNova = new Casa();
                                Terreno terrenoNovo = new Terreno();
                                Apartamento apartamentoNovo = new Apartamento();

                                //USUÁRIO INSERINDO DADOS DO ENDEREÇO
                                enderecoNovo.cadastroEndereco(enderecoNovo, listaDeEnderecos);

                                //USUÁRIO INSERINDO DADOS DO FUNCIONÁRIO
                                funcionarioNovo.cadastroFuncionario(funcionarioNovo, listaDeFuncionarios, enderecoNovo);

                                //ASSOCIAÇÃO ENDEREÇO
                                funcionarioNovo.setEndereco(enderecoNovo);

                                //INSERIR ENDEREÇO NA LISTA DE ENDEREÇOS
                                listaDeEnderecos.Add(enderecoNovo);

                                //INSERIR FUNCIONÁRIO NA LISTA DE FUNCIONÁRIOS
                                listaDeFuncionarios.Add(funcionarioNovo);

                                Console.WriteLine("");
                                Console.WriteLine("*************** CADASTRO REALIZADO COM SUCESSO *************");
                                Console.WriteLine("");

                                //MOSTRAR DADOS DO FUNCIONÁRIO
                                funcionarioNovo.mostraDadosFuncionario();

                                Console.WriteLine("");
                                Console.WriteLine("Aperte ENTER para continuar...\n");

                                Console.ReadKey();

                            }

                            else
                            {
                                Console.Write("");
                                Console.Write("*************** OPÇÃO INVÁLIDA *************\n");
                                Console.Write("");

                                Console.Write("Aperte ENTER para continuar...\n");
                                Console.ReadKey();
                            }

                        }

                        break;
 

                    case 3://GERENCIAMENTO DE VENDAS E LOCAÇÕES
                        {
                            int op;
                            Console.Write("*****************************************************************\n");
                            Console.Write("***************  SELECIONE O QUE DESEJA GERENCIAR  **************\n");
                            Console.Write("*****************************************************************\n");
                            Console.Write("[1]  - GERENCIAMENTO DE VENDAS\n");
                            Console.Write("*****************************************************************\n");
                            Console.Write("[2]  - GERENCIAMENTO DE ALUGUÉIS\n");
                            Console.Write("*****************************************************************\n");

                            op = int.Parse(Console.ReadLine());
                            Console.WriteLine();

                            if (op == 1)//VENDA DE UM IMÓVEL
                            {

                                int opvenda;
                                Console.Write("*****************************************************************\n");
                                Console.Write("************  SELECIONE A VENDA QUE DESEA CADASTRAR  ************\n");
                                Console.Write("*****************************************************************\n");
                                Console.Write("[1]  - VENDA DE CASA\n");
                                Console.Write("*****************************************************************\n");
                                Console.Write("[2]  - VENDA DE TERRENO\n");
                                Console.Write("*****************************************************************\n");
                                Console.Write("[3]  - VENDA DE APARTAMENTO\n");
                                Console.Write("*****************************************************************\n");

                                opvenda = int.Parse(Console.ReadLine());
                                Console.WriteLine();

                                if (opvenda == 1)//CASA
                                {

                                    Cliente clienteNovo = new Cliente();
                                    Funcionario funcionarioNovo = new Funcionario();
                                    Venda vendaNova = new Venda();
                                    Aluguel aluguelNovo = new Aluguel();
                                    Endereco enderecoNovo = new Endereco();
                                    Casa casaNova = new Casa();
                                    Terreno terrenoNovo = new Terreno();
                                    Apartamento apartamentoNovo = new Apartamento();


                                    //OBS:
                                    // CODIGO DE BUSCA DO DADOS (CASA) NO ARRAY
                                    Console.Write("\nDIGITE A QUADRA DO IMÓVEL: ");
                                    int codigoquadra = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("\nDIGITE O LOTE DO IMÓVEL: ");
                                    string codigolote = (Console.ReadLine());

                                    //BUSCA CASA COM LOTE E QUADRA DIGITADOS
                                    Casa casa = buscarCasa(codigolote, codigoquadra);



                                    // CODIGO DE BUSCA DO DADOS (CLIENTE) NO ARRAY
                                    Console.Write("\nDIGITE O NOME DO CLIENTE: ");
                                    string codigocli = (Console.ReadLine());

                                    //BUSCA CLIENTE COM O NOME DIGITADO
                                    Cliente cli = buscarCliente(codigocli);



                                    // CODIGO DE BUSCA DO DADOS (FUNCIONARIO) NO ARRAY
                                    Console.Write("\nDIGITE O NOME DO FUNCIONARIO: ");
                                    string codigofun = (Console.ReadLine());

                                    //BUSCA FUNCIONÁRIO COM O NOME DIGITADO
                                    Funcionario fun = buscarFuncionario(codigofun);



                                    //VERIFICA SE EXISTE CASA, CLIENTE E FUNCIONÁRIO CADASTRADOS
                                    if ((casa != null) && (cli != null) && (fun != null))
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("** IMÓVEL, CLIENTE E FUNCIONÁRIO LOCALIZADOS **");
                                        Console.WriteLine("");

                                        if ((casa.getSituacao() == "1") && (cli.getLiberado() == true))
                                        {
                                            //CADASTRO DA VENDA
                                            Console.Write("CADASTRO DA VENDA\n");
                                            Console.Write("-----------------\n");
                                            vendaNova.cadastroVenda(vendaNova, listaDeVendas, casa, clienteNovo, funcionarioNovo);



                                            //ASSOCIAÇÃO CASA
                                            vendaNova.setImovel(casa);

                                            //ASSOCIAÇÃO CLIENTE
                                            vendaNova.setCliente(cli);

                                            //ASSOCIAÇÃO FUNCIONÁRIO
                                            vendaNova.setFuncionario(fun);



                                            //INSERIR VENDA NA LISTA DE VENDAS
                                            listaDeVendas.Add(vendaNova);



                                            Console.WriteLine("");
                                            Console.WriteLine("*************** CADASTRO REALIZADO COM SUCESSO *************");
                                            Console.WriteLine("");

                                            //IMPRIMIR DADOS CADASTRADOS
                                            //MOSTRAR DADOS DA VENDA
                                            vendaNova.mostraDadosVenda();

                                            Console.WriteLine("");
                                            Console.WriteLine("Aperte ENTER para continuar...\n");
                                            Console.ReadKey();

                                        }
                                        else
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("ATENÇÃO: IMÓVEL INDISPONÍVEL OU CLIENTE BLOQUEADO");
                                            Console.WriteLine("PARA QUE A VENDA SEJA CONCLUÍDA, É NECESSÁRIO QUE O IMÓVEL ESTEJA DISPONIVEL E O CLIENTE LIBERADO");
                                            Console.WriteLine("");
                                            Console.WriteLine("Aperte ENTER para continuar...\n");

                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("DADOS NÃO ENCONTRADOS. FAVOR CADASTRAR UM IMÓVEL, UM CLIENTE E UM FUNCIONÁRIO ANTES DE PROSSEGUIR COM A VENDA.");
                                        Console.WriteLine("");
                                        Console.WriteLine("Aperte ENTER para continuar...\n");

                                        Console.ReadKey();
                                    }
                 
                                }
                                else if (opvenda == 2)//TERRENO
                                {

                                    Cliente clienteNovo = new Cliente();
                                    Funcionario funcionarioNovo = new Funcionario();
                                    Venda vendaNova = new Venda();
                                    Aluguel aluguelNovo = new Aluguel();
                                    Endereco enderecoNovo = new Endereco();
                                    Casa casaNova = new Casa();
                                    Terreno terrenoNovo = new Terreno();
                                    Apartamento apartamentoNovo = new Apartamento();

                                    //OBS:
                                    // CODIGO DE BUSCA DO DADOS (TERRENO) NO ARRAY
                                    Console.Write("\nDIGITE  DO IMÓVEL: ");
                                    int codigoquadra = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("\nDIGITE O LOTE DO IMÓVEL: ");
                                    string codigolote = (Console.ReadLine());

                                    //BUSCA TERRENO COM LOTE E QUADRA DIGITADOS
                                    Terreno terreno = buscarTerreno(codigolote, codigoquadra);



                                    // CODIGO DE BUSCA DO DADOS (CLIENTE) NO ARRAY
                                    Console.Write("\nDIGITE O NOME DO CLIENTE: ");
                                    string codigocli = (Console.ReadLine());

                                    //BUSCA CLIENTE COM O NOME DIGITADO
                                    Cliente cli = buscarCliente(codigocli);



                                    // CODIGO DE BUSCA DO DADOS (FUNCIONARIO) NO ARRAY
                                    Console.Write("\nDIGITE O NOME DO FUNCIONARIO: ");
                                    string codigofun = (Console.ReadLine());

                                    //BUSCA FUNCIONÁRIO COM O NOME DIGITADO
                                    Funcionario fun = buscarFuncionario(codigofun);



                                    //VERIFICA SE EXISTE TERRENO, CLIENTE E FUNCIONÁRIO CADASTRADOS
                                    if ((terreno != null) && (cli != null) && (fun != null))
                                    {

                                        Console.WriteLine("");
                                        Console.WriteLine("** IMÓVEL, CLIENTE E FUNCIONÁRIO LOCALIZADOS **");
                                        Console.WriteLine("");


                                        if ((terreno.getSituacao() == "1") && (cli.getLiberado() == true))
                                        {
                                            Console.Write("CADASTRO DA VENDA\n");
                                            Console.Write("-----------------\n");
                                            vendaNova.cadastroVenda(vendaNova, listaDeVendas, terreno, clienteNovo, funcionarioNovo);



                                            //ASSOCIAÇÃO TERRENO
                                            vendaNova.setImovel(terreno);

                                            //ASSOCIAÇÃO CLIENTE
                                            vendaNova.setCliente(cli);

                                            //ASSOCIAÇÃO FUNCIONÁRIO
                                            vendaNova.setFuncionario(fun);



                                            //INSERIR VENDA NA LISTA DE VENDAS
                                            listaDeVendas.Add(vendaNova);



                                            Console.WriteLine("");
                                            Console.WriteLine("*************** CADASTRO REALIZADO COM SUCESSO *************");
                                            Console.WriteLine("");

                                            //IMPRIMIR DADOS CADASTRADOS
                                            //MOSTRAR DADOS DA VENDA
                                            vendaNova.mostraDadosVenda();

                                            Console.WriteLine("");
                                            Console.WriteLine("Aperte ENTER para continuar...\n");

                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("ATENÇÃO: IMÓVEL INDISPONÍVEL OU CLIENTE BLOQUEADO");
                                            Console.WriteLine("PARA QUE A VENDA SEJA CONCLUÍDA, É NECESSÁRIO QUE O IMÓVEL ESTEJA DISPONIVEL E O CLIENTE LIBERADO");
                                            Console.WriteLine("");
                                            Console.WriteLine("Aperte ENTER para continuar...\n");

                                            Console.ReadKey();
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("DADOS NÃO ENCONTRADOS. FAVOR CADASTRAR UM IMÓVEL, UM CLIENTE E UM FUNCIONÁRIO ANTES DE PROSSEGUIR COM A VENDA.");
                                        Console.WriteLine("");
                                        Console.WriteLine("Aperte ENTER para continuar...\n");

                                        Console.ReadKey();
                                    }

                                }
                                else if (opvenda == 3)//APARTAMENTO
                                {

                                    Cliente clienteNovo = new Cliente();
                                    Funcionario funcionarioNovo = new Funcionario();
                                    Venda vendaNova = new Venda();
                                    Aluguel aluguelNovo = new Aluguel();
                                    Endereco enderecoNovo = new Endereco();
                                    Casa casaNova = new Casa();
                                    Terreno terrenoNovo = new Terreno();
                                    Apartamento apartamentoNovo = new Apartamento();


                                    //OBS:
                                    // CODIGO DE BUSCA DO DADOS (APARTAMENTO) NO ARRAY
                                    Console.Write("\nDIGITE A QUADRA DO IMÓVEL: ");
                                    int codigoquadra = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("\nDIGITE O LOTE DO IMÓVEL: ");
                                    string codigolote = (Console.ReadLine());

                                    //BUSCA APARTAMENTO COM LOTE E QUADRA DIGITADOS
                                    Apartamento apartamento = buscarApartamento(codigolote, codigoquadra);



                                    // CODIGO DE BUSCA DO DADOS (CLIENTE) NO ARRAY
                                    Console.Write("\nDIGITE O NOME DO CLIENTE: ");
                                    string codigocli = (Console.ReadLine());

                                    //BUSCA CLIENTE COM NOME DITADO
                                    Cliente cli = buscarCliente(codigocli);



                                    // CODIGO DE BUSCA DO DADOS (FUNCIONARIO) NO ARRAY
                                    Console.Write("\nDIGITE O NOME DO FUNCIONARIO: ");
                                    string codigofun = (Console.ReadLine());

                                    //BUSCA FUNCIONÁRIO COM NOME DIGITADO
                                    Funcionario fun = buscarFuncionario(codigofun);



                                    //VERIFICA SE EXISTE APARTAMENTO, CLIENTE E FUNCIONÁRIO CADASTRADOS
                                    if ((apartamento != null) && (cli != null) && (fun != null))
                                    {

                                        Console.WriteLine("");
                                        Console.WriteLine("** IMÓVEL, CLIENTE E FUNCIONÁRIO LOCALIZADOS **");
                                        Console.WriteLine("");


                                        if ((apartamento.getSituacao() == "1") && (cli.getLiberado() == true))
                                        {
                                            //CADASTRO DA VENDA
                                            Console.Write("CADASTRO DA VENDA\n");
                                            Console.Write("-----------------\n");
                                            vendaNova.cadastroVenda(vendaNova, listaDeVendas, apartamento, clienteNovo, funcionarioNovo);



                                            //ASSOCIAÇÃO APARTAMENTO
                                            vendaNova.setImovel(apartamento);

                                            //ASSOCIAÇÃO CLIENTE
                                            vendaNova.setCliente(cli);

                                            //ASSOCIAÇÃO FUNCIONÁRIO
                                            vendaNova.setFuncionario(fun);


                                            //INSERIR VENDA NA LISTA DE VENDAS
                                            listaDeVendas.Add(vendaNova);



                                            Console.WriteLine("");
                                            Console.WriteLine("*************** CADASTRO REALIZADO COM SUCESSO *************");
                                            Console.WriteLine("");

                                            //IMPRIMIR DADOS CADASTRADOS
                                            //MOSTRAR DADOS DA VENDA
                                            vendaNova.mostraDadosVenda();

                                            Console.WriteLine("");
                                            Console.WriteLine("Aperte ENTER para continuar...\n");

                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("ATENÇÃO: IMÓVEL INDISPONÍVEL OU CLIENTE BLOQUEADO");
                                            Console.WriteLine("PARA QUE A VENDA SEJA CONCLUÍDA, É NECESSÁRIO QUE O IMÓVEL ESTEJA DISPONIVEL E O CLIENTE LIBERADO");
                                            Console.WriteLine("");
                                            Console.WriteLine("Aperte ENTER para continuar...\n");

                                            Console.ReadKey();
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("DADOS NÃO ENCONTRADOS. FAVOR CADASTRAR UM IMÓVEL, UM CLIENTE E UM FUNCIONÁRIO ANTES DE PROSSEGUIR COM A VENDA.");
                                        Console.WriteLine("");
                                        Console.WriteLine("Aperte ENTER para continuar...\n");

                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.Write("");
                                    Console.Write("*************** OPÇÃO INVÁLIDA *************");
                                    Console.Write("");

                                    Console.Write("Aperte ENTER para continuar...\n");
                                    Console.ReadKey();
                                }


                            }

                            else if (op == 2)//ALUGUEL DE IMÓVEL
                            {

                                int opaluguel;
                                Console.Write("*****************************************************************\n");
                                Console.Write("***********  SELECIONE O ALUGUEL QUE DESEA CADASTRAR  ***********\n");
                                Console.Write("*****************************************************************\n");
                                Console.Write("[1]  - ALUGUEL DE CASA\n");
                                Console.Write("*****************************************************************\n");
                                Console.Write("[2]  - ALUGUEL DE TERRENO\n");
                                Console.Write("*****************************************************************\n");
                                Console.Write("[3]  - ALUGUEL DE APARTAMENTO\n");
                                Console.Write("*****************************************************************\n");

                                opaluguel = int.Parse(Console.ReadLine());
                                Console.WriteLine();


                                if (opaluguel == 1)//CASA
                                {
                                    Cliente clienteNovo = new Cliente();
                                    Funcionario funcionarioNovo = new Funcionario();
                                    Venda vendaNova = new Venda();
                                    Aluguel aluguelNovo = new Aluguel();
                                    Endereco enderecoNovo = new Endereco();
                                    Casa casaNova = new Casa();
                                    Terreno terrenoNovo = new Terreno();
                                    Apartamento apartamentoNovo = new Apartamento();


                                    //OBS:
                                    // CODIGO DE BUSCA DO DADOS (CASA) NO ARRAY
                                    Console.Write("\nDIGITE A QUADRA DO IMÓVEL: ");
                                    int codigoquadra = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("\nDIGITE O LOTE DO IMÓVEL: ");
                                    string codigolote = (Console.ReadLine());

                                    //BUSCA CASA COM LOTE E QUADRA DIGITADOS
                                    Casa casa = buscarCasa(codigolote, codigoquadra);



                                    // CODIGO DE BUSCA DO DADOS (CLIENTE) NO ARRAY
                                    Console.Write("\nDIGITE O NOME DO CLIENTE: ");
                                    string codigocli = (Console.ReadLine());

                                    //BUSCA CLIENTE COM O NOME DIGITADO
                                    Cliente cli = buscarCliente(codigocli);



                                    // CODIGO DE BUSCA DO DADOS (FUNCIONARIO) NO ARRAY
                                    Console.Write("\nDIGITE O NOME DO FUNCIONARIO: ");
                                    string codigofun = (Console.ReadLine());

                                    //BUSCA FUNCIONÁRIO COM O NOME DIGITADO
                                    Funcionario fun = buscarFuncionario(codigofun);



                                    //VERIFICA SE EXISTE CASA, CLIENTE E FUNCIONÁRIO CADASTRADOS
                                    if ((casa != null) && (cli != null) && (fun != null))
                                    {

                                        Console.WriteLine("");
                                        Console.WriteLine("** IMÓVEL, CLIENTE E FUNCIONÁRIO LOCALIZADOS **");
                                        Console.WriteLine("");


                                        if ((casa.getSituacao() == "1") && (cli.getLiberado() == true))
                                        {
                                            //CADASTRO DO ALUGUEL
                                            Console.Write("CADASTRO DO ALUGUEL\n");
                                            Console.Write("-------------------\n");
                                            aluguelNovo.cadastroAluguel(aluguelNovo, listaDeAlugueis, casa, clienteNovo, funcionarioNovo);



                                            //ASSOCIAÇÃO CASA
                                            aluguelNovo.setImovel(casa);

                                            //ASSOCIAÇÃO CLIENTE
                                            aluguelNovo.setCliente(cli);

                                            //ASSOCIAÇÃO FUNCIONÁRIO
                                            aluguelNovo.setFuncionario(fun);



                                            //INSERIR ALUGUEL NA LISTA DE AUGUEIS
                                            listaDeAlugueis.Add(aluguelNovo);



                                            Console.WriteLine("");
                                            Console.WriteLine("*************** CADASTRO REALIZADO COM SUCESSO *************");
                                            Console.WriteLine("");

                                            //IMPRIMIR DADOS CADASTRADOS
                                            //MOSTRAR DADOS DO ALUGUEL
                                            aluguelNovo.mostraDadosAluguel();


                                            Console.WriteLine("");
                                            Console.WriteLine("Aperte ENTER para continuar...\n");
                                            Console.ReadKey();

                                        }
                                        else
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("ATENÇÃO: IMÓVEL INDISPONÍVEL OU CLIENTE BLOQUEADO");
                                            Console.WriteLine("PARA QUE A LOCAÇÃO SEJA CONCLUÍDA, É NECESSÁRIO QUE O IMÓVEL ESTEJA DISPONIVEL E O CLIENTE LIBERADO");
                                            Console.WriteLine("");
                                            Console.WriteLine("Aperte ENTER para continuar...\n");

                                            Console.ReadKey();
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("DADOS NÃO ENCONTRADOS. FAVOR CADASTRAR UM IMÓVEL, UM CLIENTE E UM FUNCIONÁRIO ANTES DE PROSSEGUIR COM A LOCAÇÃO.");
                                        Console.WriteLine("");
                                        Console.WriteLine("Aperte ENTER para continuar...\n");

                                        Console.ReadKey();
                                    }

                                }
                                else if (opaluguel == 2)//TERRENO
                                {
                                    Cliente clienteNovo = new Cliente();
                                    Funcionario funcionarioNovo = new Funcionario();
                                    Venda vendaNova = new Venda();
                                    Aluguel aluguelNovo = new Aluguel();
                                    Endereco enderecoNovo = new Endereco();
                                    Casa casaNova = new Casa();
                                    Terreno terrenoNovo = new Terreno();
                                    Apartamento apartamentoNovo = new Apartamento();



                                    //OBS:
                                    // CODIGO DE BUSCA DO DADOS (TERRENO) NO ARRAY
                                    Console.Write("\nDIGITE A QUADRA DO IMÓVEL: ");
                                    int codigoquadra = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("\nDIGITE O LOTE DO IMÓVEL: ");
                                    string codigolote = (Console.ReadLine());

                                    //BUSCA TERRENO COM LOTE E QUADRA DIGITADOS
                                    Terreno terreno = buscarTerreno(codigolote, codigoquadra);



                                    // CODIGO DE BUSCA DO DADOS (CLIENTE) NO ARRAY
                                    Console.Write("\nDIGITE O NOME DO CLIENTE: ");
                                    string codigocli = (Console.ReadLine());

                                    //BUSCA CLIENTE COM O NOME DIGITADO
                                    Cliente cli = buscarCliente(codigocli);



                                    // CODIGO DE BUSCA DO DADOS (FUNCIONARIO) NO ARRAY
                                    Console.Write("\nDIGITE O NOME DO FUNCIONARIO: ");
                                    string codigofun = (Console.ReadLine());

                                    //BUSCA FUNCIONÁRIO COM O NOME DIGITADO
                                    Funcionario fun = buscarFuncionario(codigofun);



                                    //VERIFICA SE EXISTE TERRENO, CLIENTE E FUNCIONÁRIO CADASTRADOS
                                    if ((terreno != null) && (cli != null) && (fun != null))
                                    {

                                        Console.WriteLine("");
                                        Console.WriteLine("** IMÓVEL, CLIENTE E FUNCIONÁRIO LOCALIZADOS **");
                                        Console.WriteLine("");


                                        if ((terreno.getSituacao() == "1") && (cli.getLiberado() == true))
                                        {
                                            //CADASTRO DA ALUGUEL
                                            Console.Write("CADASTRO DO ALUGUEL\n");
                                            Console.Write("-------------------\n");
                                            aluguelNovo.cadastroAluguel(aluguelNovo, listaDeAlugueis, terreno, clienteNovo, funcionarioNovo);



                                            //ASSOCIAÇÃO TERRENO
                                            aluguelNovo.setImovel(terreno);

                                            //ASSOCIAÇÃO CLIENTE
                                            aluguelNovo.setCliente(cli);

                                            //ASSOCIAÇÃO FUNCIONÁRIO
                                            aluguelNovo.setFuncionario(fun);



                                            //INSERIR VENDA NA LISTA DE ALUGUEIS
                                            listaDeAlugueis.Add(aluguelNovo);



                                            Console.WriteLine("");
                                            Console.WriteLine("*************** CADASTRO REALIZADO COM SUCESSO *************");
                                            Console.WriteLine("");

                                            //IMPRIMIR DADOS CADASTRADOS
                                            //MOSTRAR DADOS DO ALUGUEL
                                            aluguelNovo.mostraDadosAluguel();

                                            Console.WriteLine("");
                                            Console.WriteLine("Aperte ENTER para continuar...\n");

                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("ATENÇÃO: IMÓVEL INDISPONÍVEL OU CLIENTE BLOQUEADO");
                                            Console.WriteLine("PARA QUE A LOCAÇÃO SEJA CONCLUÍDA, É NECESSÁRIO QUE O IMÓVEL ESTEJA DISPONIVEL E O CLIENTE LIBERADO");
                                            Console.WriteLine("");
                                            Console.WriteLine("Aperte ENTER para continuar...\n");

                                            Console.ReadKey();
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("DADOS NÃO ENCONTRADOS. FAVOR CADASTRAR UM IMÓVEL, UM CLIENTE E UM FUNCIONÁRIO ANTES DE PROSSEGUIR COM A LOCAÇÃO.");
                                        Console.WriteLine("");
                                        Console.WriteLine("Aperte ENTER para continuar...\n");

                                        Console.ReadKey();
                                    }
                                }
                                else if (opaluguel == 3)//APARTAMENTO
                                {
                                    Cliente clienteNovo = new Cliente();
                                    Funcionario funcionarioNovo = new Funcionario();
                                    Venda vendaNova = new Venda();
                                    Aluguel aluguelNovo = new Aluguel();
                                    Endereco enderecoNovo = new Endereco();
                                    Casa casaNova = new Casa();
                                    Terreno terrenoNovo = new Terreno();
                                    Apartamento apartamentoNovo = new Apartamento();


                                    //OBS:
                                    // CODIGO DE BUSCA DO DADOS (APARTAMENTO) NO ARRAY
                                    Console.Write("\nDIGITE A QUADRA DO IMÓVEL: ");
                                    int codigoquadra = Convert.ToInt32(Console.ReadLine());

                                    Console.Write("\nDIGITE O LOTE DO IMÓVEL: ");
                                    string codigolote = (Console.ReadLine());

                                    //BUSCA APARTAMENTO COM LOTE E QUADRA DIGITADOS
                                    Apartamento apartamento = buscarApartamento(codigolote, codigoquadra);



                                    // CODIGO DE BUSCA DO DADOS (CLIENTE) NO ARRAY
                                    Console.Write("\nDIGITE O NOME DO CLIENTE: ");
                                    string codigocli = (Console.ReadLine());

                                    //BUSCA CLIENTE COM NOME DITADO
                                    Cliente cli = buscarCliente(codigocli);



                                    // CODIGO DE BUSCA DO DADOS (FUNCIONARIO) NO ARRAY
                                    Console.Write("\nDIGITE O NOME DO FUNCIONARIO: ");
                                    string codigofun = (Console.ReadLine());

                                    //BUSCA FUNCIONÁRIO COM NOME DIGITADO
                                    Funcionario fun = buscarFuncionario(codigofun);



                                    //VERIFICA SE EXISTE APARTAMENTO, CLIENTE E FUNCIONÁRIO CADASTRADOS
                                    if ((apartamento != null) && (cli != null) && (fun != null))
                                    {

                                        Console.WriteLine("");
                                        Console.WriteLine("** IMÓVEL, CLIENTE E FUNCIONÁRIO LOCALIZADOS **");
                                        Console.WriteLine("");


                                        if ((apartamento.getSituacao() == "1") && (cli.getLiberado() == true))
                                        {
                                            //CADASTRO DO APARTAMENTO
                                            Console.Write("CADASTRO DO ALUGUEL\n");
                                            Console.Write("-------------------\n");
                                            aluguelNovo.cadastroAluguel(aluguelNovo, listaDeAlugueis, apartamento, clienteNovo, funcionarioNovo);



                                            //ASSOCIAÇÃO APARTAMENTO
                                            aluguelNovo.setImovel(apartamento);

                                            //ASSOCIAÇÃO CLIENTE
                                            aluguelNovo.setCliente(cli);

                                            //ASSOCIAÇÃO FUNCIONÁRIO
                                            aluguelNovo.setFuncionario(fun);


                                            //INSERIR ALUGUEL NA LISTA DE ALUGUEIS
                                            listaDeAlugueis.Add(aluguelNovo);



                                            Console.WriteLine("");
                                            Console.WriteLine("*************** CADASTRO REALIZADO COM SUCESSO *************");
                                            Console.WriteLine("");

                                            //IMPRIMIR DADOS CADASTRADOS
                                            //MOSTRAR DADOS DO ALUGUEL
                                            aluguelNovo.mostraDadosAluguel();

                                            Console.WriteLine("");
                                            Console.WriteLine("Aperte ENTER para continuar...\n");

                                            Console.ReadKey();

                                        }
                                        else
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("ATENÇÃO: IMÓVEL INDISPONÍVEL OU CLIENTE BLOQUEADO");
                                            Console.WriteLine("PARA QUE A LOCAÇÃO SEJA CONCLUÍDA, É NECESSÁRIO QUE O IMÓVEL ESTEJA DISPONIVEL E O CLIENTE LIBERADO");
                                            Console.WriteLine("");
                                            Console.WriteLine("Aperte ENTER para continuar...\n");

                                            Console.ReadKey();
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("DADOS NÃO ENCONTRADOS. FAVOR CADASTRAR UM IMÓVEL, UM CLIENTE E UM FUNCIONÁRIO ANTES DE PROSSEGUIR COM A LOCAÇÃO.");
                                        Console.WriteLine("");
                                        Console.WriteLine("Aperte ENTER para continuar...\n");

                                        Console.ReadKey();
                                    }

                                }
                                else
                                {
                                    Console.Write("");
                                    Console.Write("*************** OPÇÃO INVÁLIDA *************\n");
                                    Console.Write("");

                                    Console.Write("Aperte ENTER para continuar...\n");
                                    Console.ReadKey();
                                }
                            }


                        }
                        break;
                        

                    case 4://CONSULTAR IMÓVEL PELA SITUAÇÃO
                        {
                            int opsitimovel = 0;

                            Console.Write("*****************************************************************\n");
                            Console.Write("******  SELECIONE A SITUAÇÃO DO IMÓVEL QUE DESEJA CONSULTAR *****\n");
                            Console.Write("*****************************************************************\n");
                            Console.Write("[1]  - IMÓVEIS DISPONIVEIS\n");
                            Console.Write("*****************************************************************\n");
                            Console.Write("[2]  - IMÓVEIS INDISPONIVEIS\n");
                            Console.Write("*****************************************************************\n");


                            opsitimovel = int.Parse(Console.ReadLine());
                            Console.WriteLine();


                            if (opsitimovel == 1)//IMOVEL DISPONIVEIS PARA VENDA E LOCAÇÃO
                            {
                                Console.WriteLine("");
                                Console.WriteLine("*************** IMÓVEIS DISPONÍVEIS *************");
                                Console.WriteLine("");

                                foreach (Casa casa in listaDeCasas)
                                {
                                    if (casa.getSituacao() == "1")
                                    {
                                        casa.mostraDadosCasa();
                                    }
                                }

                                foreach (Terreno terreno in listaDeTerrenos)
                                {
                                    if (terreno.getSituacao() == "1")
                                    {
                                        terreno.mostraDadosTerreno();
                                    }
                                }

                                foreach (Apartamento apartamento in listaDeApartamentos)
                                {
                                    if (apartamento.getSituacao() == "1")
                                    {
                                        apartamento.mostraDadosApartamento();
                                    }
                                }

                                Console.ReadKey();

                            }
                            else if (opsitimovel == 2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("*************** IMÓVEIS INDISPONÍVEIS *************");
                                Console.WriteLine("");

                                foreach (Casa casa in listaDeCasas)
                                {
                                    if (casa.getSituacao() == "2")
                                    {
                                        casa.mostraDadosCasa();
                                    }
                                }

                                foreach (Terreno terreno in listaDeTerrenos)
                                {
                                    if (terreno.getSituacao() == "2")
                                    {
                                        terreno.mostraDadosTerreno();
                                    }
                                }

                                foreach (Apartamento apartamento in listaDeApartamentos)
                                {
                                    if (apartamento.getSituacao() == "2")
                                    {
                                        apartamento.mostraDadosApartamento();
                                    }
                                }

                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("");
                                Console.Write("*************** OPÇÃO INVÁLIDA *************\n");
                                Console.Write("");
                                Console.Write("Aperte ENTER para continuar...\n");
                                Console.ReadKey();
                            }


                        }


                        break;


                    case 5://CONSULTA DE FUNCIONÁRIOS
                        {
                            Console.Write("\n******************************************");
                            Console.Write("\n*************  FUNCIONARIOS  *************");
                            Console.Write("\n******************************************");
                            foreach (Funcionario funcionario in listaDeFuncionarios)
                            {
                                funcionario.mostraDadosFuncionario();
                                Console.Write("\n--------------------------------------");
                            }
                            Console.ReadKey();

                        }
                        break;


                    case 6://CONSULTA DE CLIENTES
                        {

                            Console.Write("\n******************************************");
                            Console.Write("\n***************  CLIENTES  ***************");
                            Console.Write("\n******************************************");
                            foreach (Cliente cliente in listaDeClientes)
                            {
                                cliente.mostraDadosCliente();
                                Console.Write("\n--------------------------------------");
                            }
                            Console.ReadKey();

                        }

                        break;


                    case 7://CONSULTA DE IMÓVEIS POR CLIENTE
                        {
                            Console.WriteLine("");
                            Console.WriteLine("*************** IMÓVEIS DO CLIENTE *************");
                            Console.WriteLine("");



                            // CODIGO DE BUSCA DO DADOS (CLIENTE) NO ARRAY
                            Console.Write("\nDIGITE O NOME DO CLIENTE: ");
                            string codigocli = (Console.ReadLine());

                            //BUSCA FUNCIONÁRIO COM O NOME DIGITADO
                            Cliente cli = buscarCliente(codigocli);


                            //VERIFICA SE EXISTE CLIENTE
                            if (cli != null)
                            {

                                Console.Write("\n========================================================================");
                                Console.Write("\n******************************************");
                                Console.Write("\n***************  CASAS  ******************");
                                Console.Write("\n******************************************");
                                foreach (Casa casa in listaDeCasas)
                                {
                                    casa.mostraDadosCasa();
                                    Console.Write("\n--------------------------------------");
                                }

                                Console.Write("\n========================================================================");
                                Console.Write("\n******************************************");
                                Console.Write("\n**************  TERRENOS  ****************");
                                Console.Write("\n******************************************");
                                foreach (Terreno terreno in listaDeTerrenos)
                                {
                                    terreno.mostraDadosTerreno();
                                    Console.Write("\n--------------------------------------");
                                }

                                Console.Write("\n========================================================================");
                                Console.Write("\n******************************************");
                                Console.Write("\n************  APARTAMENTOS  **************");
                                Console.Write("\n******************************************");
                                foreach (Apartamento apartamento in listaDeApartamentos)
                                {
                                    apartamento.mostraDadosApartamento();
                                    Console.Write("\n--------------------------------------");
                                }


                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("***************************** CLIENTE NÃO ENCONTRADO *****************************");
                                Console.WriteLine("");
                                Console.WriteLine("Aperte ENTER para continuar...\n");

                                Console.ReadKey();
                            }



                            /*

                        foreach (Casa casa in listaDeCasas)
                        {
                            if (casa.getCliente().getNome() == nomeCliente)
                            {
                                casa.mostraDadosCasa();
                            }
                        }

                        foreach (Terreno terreno in listaDeTerrenos)
                        {
                            if (terreno.getCliente().getNome() == nomeCliente)
                            {
                                terreno.mostraDadosTerreno();
                            }
                        }

                        foreach (Apartamento apartamento in listaDeApartamentos)
                        {
                            if (apartamento.getCliente().getNome() == nomeCliente)
                            {
                                apartamento.mostraDadosApartamento();
                            }
                        }*/

                            Console.ReadKey();
                        }


                        break; 

                    case 8://CONSULTA DE SALARIO E COMISSÃO DE FUNCIONÁRIO
                        {

                            Console.WriteLine("");
                            Console.WriteLine("*************** IMÓVEIS DO CLIENTE *************");
                            Console.WriteLine("");



                            // CODIGO DE BUSCA DO DADOS (FUNCIONÁRIO) NO ARRAY
                            Console.Write("\nDIGITE O NOME DO FUNCIONÁRIO: ");
                            string codigofun = (Console.ReadLine());

                            //BUSCA FUNCIONÁRIO COM O NOME DIGITADO
                            Funcionario fun = buscarFuncionario(codigofun);


                            //VERIFICA SE EXISTE CLIENTE
                            if (fun != null)
                            {


                                Console.Write("\n******************************************");
                                Console.Write("\n*************  SALÁRIO  *************");
                                Console.Write("\n******************************************");
                                foreach (Funcionario funcionario in listaDeFuncionarios)
                                {
                                    funcionario.mostraSalarioSemCom();
                                    Console.Write("\n--------------------------------------");  
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("***************************** FUNCIONÁRIO NÃO ENCONTRADO *****************************");
                                Console.WriteLine("");
                                Console.WriteLine("Aperte ENTER para continuar...\n");

                                Console.ReadKey();
                            }
                           

                        }
                        break;

                    case 9://IMPRESSÃO DE LISTAS DE CADASTROS
                        {
                            Console.Write("\n========================================================================");
                            Console.Write("\n******************************************");
                            Console.Write("\n***************  CASAS  ******************");
                            Console.Write("\n******************************************");
                            foreach (Casa casa in listaDeCasas)
                            {
                                casa.mostraDadosCasa();
                                Console.Write("\n--------------------------------------");
                            }

                            Console.Write("\n========================================================================");
                            Console.Write("\n******************************************");
                            Console.Write("\n**************  TERRENOS  ****************");
                            Console.Write("\n******************************************");
                            foreach (Terreno terreno in listaDeTerrenos)
                            {
                                terreno.mostraDadosTerreno();
                                Console.Write("\n--------------------------------------");
                            }

                            Console.Write("\n========================================================================");
                            Console.Write("\n******************************************");
                            Console.Write("\n************  APARTAMENTOS  **************");
                            Console.Write("\n******************************************");
                            foreach (Apartamento apartamento in listaDeApartamentos)
                            {
                                apartamento.mostraDadosApartamento();
                                Console.Write("\n--------------------------------------");
                            }

                            Console.Write("\n========================================================================");
                            Console.Write("\n******************************************");
                            Console.Write("\n***************  VENDAS  *****************");
                            Console.Write("\n******************************************");
                            foreach (Venda venda in listaDeVendas)
                            {
                                venda.mostraDadosVenda();
                                Console.Write("\n--------------------------------------");
                            }

                            Console.Write("\n========================================================================");
                            Console.Write("\n******************************************");
                            Console.Write("\n**************  ALUGUEIS  ****************");
                            Console.Write("\n******************************************");
                            foreach (Aluguel aluguel in listaDeAlugueis)
                            {
                                aluguel.mostraDadosAluguel();
                                Console.Write("\n--------------------------------------");
                            }

                            Console.Write("\n========================================================================");
                            Console.Write("\n******************************************");
                            Console.Write("\n*************  FUNCIONARIOS  *************");
                            Console.Write("\n******************************************");
                            foreach (Funcionario funcionario in listaDeFuncionarios)
                            {
                                funcionario.mostraDadosFuncionario();
                                Console.Write("\n--------------------------------------");
                            }

                            Console.Write("\n========================================================================");
                            Console.Write("\n******************************************");
                            Console.Write("\n***************  CLIENTES  ***************");
                            Console.Write("\n******************************************");
                            foreach (Cliente cliente in listaDeClientes)
                            {
                                cliente.mostraDadosCliente();
                                Console.Write("\n--------------------------------------");
                            }


                            Console.ReadKey();
                        }

                        break;

                    default:
                        
                        Console.Write("");
                        Console.Write("*************** OPÇÃO INVÁLIDA *************");
                        Console.Write("");

                        Console.ReadKey();
                        break;
                }

            } while (Opcao != 0);
            Console.Write("*********************SAINDO*********************\n");


            Console.ReadKey();

        }
    }
}

