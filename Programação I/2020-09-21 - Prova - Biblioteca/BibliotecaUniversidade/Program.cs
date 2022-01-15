using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUniversidade
{
    class Program
    {
        //LISTAS
        static List<Livro> listaDeLivros = new List<Livro>();
        static List<Exemplar> listaDeExemplares = new List<Exemplar>();
        static List<Emprestimo> listaDeEmprestimos = new List<Emprestimo>();
        static List<Pessoa> listaDePessoas = new List<Pessoa>();
        static List<Endereco> listaDeEnderecos = new List<Endereco>();
        static List<Curso> listaDeCursos = new List<Curso>();
        static List<Aluno> listaDeAlunos = new List<Aluno>();
        static List<Professor> listaDeProfessores = new List<Professor>();
        static List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

        static Livro Livro1 = new Livro();
        static Exemplar Exemplar1 = new Exemplar();
        static Emprestimo Emprestimo1 = new Emprestimo();
        static Pessoa Pessoa1 = new Pessoa();
        static Endereco Endereco1 = new Endereco();
        static Curso Curso1 = new Curso();
        static Aluno Aluno1 = new Aluno();
        static Professor Professor1 = new Professor();
        static Funcionario Funcionario1 = new Funcionario();


        //FUNÇÃO BUSCAR LIVRO
        static Livro buscarLivro(int codigol)
        {
            foreach (Livro l in listaDeLivros)
            {
                if (l.getCodigo() == codigol)
                {
                    return l;
                }
            }
            return null;
        }


        //FUNÇÃO BUSCAR EXEMPLAR       
        static Exemplar buscarExemplar(int codigoex)
        {
            foreach (Exemplar ex in listaDeExemplares)
            {
                if (ex.getCodigo() == codigoex)
                {
                    return ex;
                }
            }
            return null;
        }

        //FUNÇÃO BUSCAR PESSOA       
        static Pessoa buscarPessoa(string codigop)
        {
            foreach (Pessoa p in listaDePessoas)
            {
                if (p.getCpf() == codigop)
                {
                    return p;
                }
            }
            return null;
        }


        //FUNÇÃO BUSCAR ENDEREÇO       
        static Endereco buscarEndereco(string codigoen)
        {
            foreach (Endereco en in listaDeEnderecos)
            {
                if (en.getCep() == codigoen)
                {
                    return en;
                }
            }
            return null;
        }

        //FUNÇÃO BUSCAR CURSO       
        static Curso buscarCurso(string codigoc)
        {
            foreach (Curso c in listaDeCursos)
            {
                if (c.getNome() == codigoc)
                {
                    return c;
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
                Console.Write("*************************************************************************************************\n");
                Console.Write("*************************************DIGITE A OPÇÃO DESEJADA*************************************\n");
                Console.Write("*************************************************************************************************\n");
                Console.Write("[1]  - INSERIR UM LIVRO\n");
                Console.Write("*************************************************************************************************\n");
                Console.Write("[2]  - INSERIR UM EXEMPLAR\n");
                Console.Write("ATENÇÃO: Para que um 'EXEMPLAR' seja cadastrado,\n");
                Console.Write("é necessário que tenha sido feito o cadastramento do 'LIVRO' anteriormente.\n");
                Console.Write("*************************************************************************************************\n");
                Console.Write("[3]  - INSERIR UM EMPRÉSTIMO\n");
                Console.Write("ATENÇÃO: Para que um 'EMPRÉSTIMO' seja cadastrado,\n");
                Console.Write("é necessário que tenha sido feito o cadastramento do 'EXEMPLAR' e da 'PESSOA' anteriormente.\n");
                Console.Write("*************************************************************************************************\n");
                Console.Write("[4]  - INSERIR UMA PESSOA\n");
                Console.Write("ATENÇÃO: Para que uma 'PESSOA' seja cadastrada,\n");
                Console.Write("é necessário que tenha sido feito o cadastramento do 'ENDEREÇO' anteriormente.\n");
                Console.Write("*************************************************************************************************\n");
                Console.Write("[5]  - INSERIR UM ENDEREÇO\n");
                Console.Write("*************************************************************************************************\n");
                Console.Write("[6]  - INSERIR UM CURSO\n");
                Console.Write("*************************************************************************************************\n");
                Console.Write("[7]  - INSERIR UM ALUNO\n");
                Console.Write("ATENÇÃO: Para que um 'ALUNO' seja cadastrado,\n");
                Console.Write("é necessário que tenha sido feito o cadastramento do 'CURSO' anteriormente.\n");
                Console.Write("*************************************************************************************************\n");
                Console.Write("[8]  - INSERIR UM PROFESSOR\n");
                Console.Write("*************************************************************************************************\n");
                Console.Write("[9]  - INSERIR UM FUNCIONÁRIO\n");
                Console.Write("*************************************************************************************************\n");
                Console.Write("[10] - IMPRIMIR TODOS OS DADOS INSERIDOS\n");
                Console.Write("*************************************************************************************************\n");
                Console.Write("[0]  - PARA SAIR\n");
                Console.Write("*************************************************************************************************\n");
                Console.Write(" \n");


                Opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();


                switch (Opcao)
                {



                    case 1: //OPÇÃO 01 - INSERINDO LIVRO

                        //Livro Livro1 = new Livro();

                        //INSERINDO DADOS DO LIVRO
                        Console.Write("************************\n");
                        Console.Write("INSIRA OS DADOS DO LIVRO\n");
                        Console.Write("************************\n");
                        Console.Write("\nCÓDIGO: ");
                        Livro1.setCodigo(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("\nNOME: ");
                        Livro1.setNome(Console.ReadLine());
                        Console.Write("\nAUTOR: ");
                        Livro1.setAutor(Console.ReadLine());
                        Console.Write("\nANO DE LANÇAMENTO: ");
                        Livro1.setAnoLancamento(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("\nEDITORA: ");
                        Livro1.setEditora(Console.ReadLine());
                        Console.Write("\nEDIÇÃO: ");
                        Livro1.setEdicao(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("");

                        //IMPRIMINDO DADOS LIVROS
                        Console.Write("******************************************");
                        Livro1.mostraDadosLivro();
                        Console.Write("\n******************************************");
                        Console.Write("\n");
                        Console.Write("\n");
                        Console.Write("**PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU INICIAL**\n");
                        Console.ReadKey();

                        //INSERE O LIVRO NA LISTA DE LIVROS
                        listaDeLivros.Add(Livro1);

                        break;



                    case 2: //OPÇÃO 02 - INSERINDO EXEMPLAR

                        //Exemplar Exemplar1 = new Exemplar();

                        //INSERINDO DADOS DO EXEMPLAR
                        Console.Write("***************************\n");
                        Console.Write("INSIRA OS DADOS DO EXEMPLAR\n");
                        Console.Write("***************************\n");
                        Console.Write("\nCÓDIGO: ");
                        Exemplar1.setCodigo(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("\nNÚMERO DO EXEMPLAR: ");
                        Exemplar1.setNroExemplar(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("\nEXCLUSIVO (SIM) ou (NÃO): ");
                        Exemplar1.setExclusivo(Convert.ToString(Console.ReadLine())); //MODIFICAÇÃO PARA STRING

                        //ASSOCIAÇÃO LIVRO
                        Exemplar1.setLivro(Livro1);


                        //OBS:
                        // CODIGO DE BUSCA DO DADOS (LIVRO) NO ARRAY
                        Console.Write("\nDIGITE O CÓDIGO DO LIVRO: ");
                        int codigol = Convert.ToInt32(Console.ReadLine());

                        //BUSCA LIVRO COM O CÓDIGO DIGITADO
                        Livro l = buscarLivro(codigol);

                        //VERIFICA SE EXISTE LIVRO COM O CÓDIGO DIGITADO
                        if (l != null)
                        {
                            Exemplar1.setLivro(l);

                            //INSERE O EXEMPLAR NA LISTA DE EXEMPLARES
                            listaDeExemplares.Add(Exemplar1);

                            //IMPRIMINDO DADOS EXEMPLAR
                            Console.Write("******************************************");
                            Exemplar1.mostraDadosExemplar();
                            Console.Write("\n******************************************");
                            Console.Write("\n");
                            Console.Write("\n");
                        }
                        else
                        {
                            Console.Write("\n");
                            Console.WriteLine("** LIVRO NÃO ENCONTRADO, FAVOR CADASTRAR O LIVRO ANTES DE REALIZAR O CADASTRAMENTO DO EXEMPLAR. **");
                        }



                        Console.WriteLine("");


                        Console.Write("**PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU INICIAL**\n");
                        Console.ReadKey();

                        break;



                    case 3: //OPÇÃO 03 - INSERINDO EMPRESTIMO

                        //Emprestimo Emprestimo1 = new Emprestimo();

                        //INSERINDO DADOS DO EMPRÉSTIMO
                        Console.Write("*****************************\n");
                        Console.Write("INSIRA OS DADOS DO EMPRÉSTIMO\n");
                        Console.Write("*****************************\n");
                        Console.Write("\nCÓDIGO: ");
                        Emprestimo1.setCodigo(Convert.ToInt32(Console.ReadLine()));

                        Emprestimo DataDoEmprestimo1 = new Emprestimo();
                        Console.Write("\nDATA DO EMPRÉSTIMO (DD/MM/AAAA): ");
                        DataDoEmprestimo1.setDataEmprestimo(Convert.ToDateTime(Console.ReadLine()));
                        Console.Write(DataDoEmprestimo1.getDataEmprestimo());

                        Emprestimo DataDaDevolucao1 = new Emprestimo();
                        Console.Write("\nDATA DA DEVOLUCAO (DD/MM/AAAA): ");
                        DataDaDevolucao1.setDataDevolucao(Convert.ToDateTime(Console.ReadLine()));
                        Console.Write(DataDaDevolucao1.getDataDevolucao());

                        Console.Write("\nVALOR DA MULTA: ");
                        Emprestimo1.setValorMulta(Convert.ToDouble(Console.ReadLine()));


                        //ASSOCIAÇÃO EXEMPLAR
                        Emprestimo1.setExemplar(Exemplar1);

                        //ASSOCIAÇÃO PESSOA
                        Emprestimo1.setPessoa(Pessoa1);



                        //OBS:
                        // CODIGO DE BUSCA DO DADOS (EXEMPLAR) NO ARRAY
                        Console.Write("\nDIGITE O CÓDIGO DO EXEMPLAR: ");
                        int codigoex = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nDIGITE O CPF DA PESSOA: ");
                        string codigop = (Console.ReadLine());

                        //BUSCA LIVRO COM O CÓDIGO DIGITADO
                        Exemplar ex = buscarExemplar(codigoex);
                        Pessoa p = buscarPessoa(codigop);


                        //VERIFICA SE EXISTE LIVRO COM O CÓDIGO DIGITADO
                        if ((ex != null) && (p != null))
                        {
                            Emprestimo1.setExemplar(ex);
                            Emprestimo1.setPessoa(p);

                            //INSERE O EMPRESTIMO NA LISTA DE EMPRESTIMO
                            listaDeEmprestimos.Add(Emprestimo1);

                            //IMPRIMINDO DADOS EXEMPLAR
                            Console.Write("******************************************");
                            Emprestimo1.mostraDadosEmprestimo();
                            Console.Write("\n******************************************");
                            Console.Write("\n");
                            Console.Write("\n");
                        }
                        if ((ex == null) && (p != null))
                        {
                            Console.Write("\n");
                            Console.WriteLine("** EXEMPLAR NÃO ENCONTRADO, FAVOR CADASTRAR O EXEMPLAR ANTES DE REALIZAR O CADASTRAMENTO DO EMPRÉSTIMO. **");
                        }
                        if ((ex != null) && (p == null))
                        {
                            Console.Write("\n");
                            Console.WriteLine("** PESSOA NÃO ENCONTRADA, FAVOR CADASTRAR A PESSOA ANTES DE REALIZAR O CADASTRAMENTO DO EMPRÉSTIMO. **");
                        }
                        if ((ex == null) && (p == null))
                        {
                            Console.Write("\n");
                            Console.WriteLine("** 'EXEMPLAR' E 'PESSOA' NÃO ENCONTRADOS, FAVOR CADASTRAR O 'EXEMPLAR' E A 'PESSOA' ANTES DE REALIZAR O CADASTRAMENTO DO EMPRÉSTIMO. **");
                        }


                        Console.WriteLine("");


                        Console.Write("**PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU INICIAL**\n");
                        Console.ReadKey();

                        break;



                    case 4: //OPÇÃO 04 - INSERINDO PESSOA

                        //Pessoa Pessoa1 = new Pessoa();

                        //INSERINDO DADOS DA PESSOA
                        Console.Write("*************************\n");
                        Console.Write("INSIRA OS DADOS PESSOAIS\n");
                        Console.Write("*************************\n");
                        Console.Write("\nCPF: ");
                        Pessoa1.setCpf(Console.ReadLine());
                        Console.Write("\nNOME: ");
                        Pessoa1.setNome(Console.ReadLine());
                        Console.Write("\nRG: ");
                        Pessoa1.setRg(Console.ReadLine());

                        Pessoa DataDeNascimento1 = new Pessoa();
                        Console.Write("\nDATA DE NASCIMENTO (DD/MM/AAAA): ");
                        DataDeNascimento1.setDataNascimento(Convert.ToDateTime(Console.ReadLine()));
                        Console.Write(DataDeNascimento1.getDataNascimento());

                        Console.Write("\nTELEFONE: ");
                        Pessoa1.setTelefone(Console.ReadLine());
                        Console.Write("\nEMAIL: ");
                        Pessoa1.setEmail(Console.ReadLine());
                        Console.Write("\nLIBERADO (SIM) ou (NÃO): ");
                        Pessoa1.setLiberado(Convert.ToString(Console.ReadLine()));//MODIFICAÇÃO PARA STRING


                        //ASSOCIAÇÃO ENDEREÇO
                        Pessoa1.setEndereco(Endereco1);

                        //OBS:
                        // CODIGO DE BUSCA DO DADOS (ENDEREÇO) NO ARRAY
                        Console.Write("\nDIGITE O CEP DO ENDEREÇO: ");
                        string codigoe = (Console.ReadLine());

                        //BUSCA ENDEREÇO COM O CEP DIGITADO
                        Endereco e = buscarEndereco(codigoe);

                        //VERIFICA SE EXISTE ENDEREÇO COM O CEP DIGITADO
                        if (e != null)
                        {
                            Pessoa1.setEndereco(e);

                            //INSERE A PESSOA NA LISTA DE PESSOAS
                            listaDePessoas.Add(Pessoa1);

                            //IMPRIMINDO DADOS DA PESSOA
                            Console.Write("******************************************");
                            Pessoa1.mostraDadosPessoa();
                            Console.Write("\n******************************************");
                            Console.Write("\n");
                            Console.Write("\n");
                        }
                        else
                        {
                            Console.Write("\n");
                            Console.WriteLine("** ENDEREÇO NÃO ENCONTRADO, FAVOR CADASTRAR O ENDEREÇO ANTES DE REALIZAR O CADASTRAMENTO DA PESSOA. **");
                        }



                        Console.WriteLine("");


                        Console.Write("**PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU INICIAL**\n");
                        Console.ReadKey();

                        break;



                    case 5: //OPÇÃO 05 - INSERINDO ENDEREÇO

                        //Endereco Endereco1 = new Endereco();

                        //INSERINDO DADOS DO ENDEREÇO
                        Console.Write("***************************\n");
                        Console.Write("INSIRA OS DADOS DO ENDEREÇO\n");
                        Console.Write("***************************\n");
                        Console.Write("\nCEP: ");
                        Endereco1.setCep(Console.ReadLine());
                        Console.Write("\nLOGRADOURO: ");
                        Endereco1.setLogradouro(Console.ReadLine());
                        Console.Write("\nBAIRRO: ");
                        Endereco1.setBairro(Console.ReadLine());
                        Console.Write("\nCIDADE: ");
                        Endereco1.setCidade(Console.ReadLine());
                        Console.Write("\nESTADO: ");
                        Endereco1.setEstado(Console.ReadLine());
                        Console.Write("\nNÚMERO: ");
                        Endereco1.setNumero(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("\nCOMPLEMENTO: ");
                        Endereco1.setComplemento(Console.ReadLine());

                        Console.WriteLine("");

                        //IMPRIMINDO DADOS ENDEREÇO
                        Console.Write("******************************************");
                        Endereco1.mostraDadosEndereco();
                        Console.Write("\n******************************************");
                        Console.Write("\n");
                        Console.Write("\n");
                        Console.Write("**PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU INICIAL**\n");
                        Console.ReadKey();

                        //INSERINDO ENDERECO NA LISTA
                        listaDeEnderecos.Add(Endereco1);

                        break;



                    case 6: //OPÇÃO 06 - INSERINDO CURSO

                        //Curso Curso1 = new Curso();

                        //INSERINDO DADOS DO CURSO
                        Console.Write("************************\n");
                        Console.Write("INSIRA OS DADOS DO CURSO\n");
                        Console.Write("************************\n");
                        Console.Write("\nNOME: ");
                        Curso1.setNome(Console.ReadLine());
                        Console.Write("\nÁREA: ");
                        Curso1.setArea(Console.ReadLine());
                        Console.Write("\nVALOR DA MENSALIDADE: ");
                        Curso1.setValorMensalidade(Convert.ToDouble(Console.ReadLine()));

                        Console.WriteLine("");

                        //IMPRIMINDO DADOS CURSO
                        Console.Write("******************************************");
                        Curso1.mostraDadosCurso();
                        Console.Write("\n******************************************");
                        Console.Write("\n");
                        Console.Write("\n");
                        Console.Write("**PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU INICIAL**\n");
                        Console.ReadKey();

                        //INSERINDO CURSO NA LISTA
                        listaDeCursos.Add(Curso1);

                        break;


                    case 7: //OPÇÃO 07 - INSERINDO ALUNO

                        //Aluno Aluno1 = new Aluno();

                        //USUÁRIO INSERINDO DADOS ALUNO
                        Console.Write("************************\n");
                        Console.Write("INSIRA OS DADOS DO ALUNO\n");
                        Console.Write("************************\n");
                        Console.Write("\nMATRÍCULA: ");
                        Aluno1.setMatricula(Convert.ToInt32(Console.ReadLine()));

                        Aluno DataDeInicio1 = new Aluno();
                        Console.Write("\nDATA DE INICIO (DD/MM/AAAA): ");
                        DataDeInicio1.setDataInicio(Convert.ToDateTime(Console.ReadLine()));
                        Console.Write(DataDeInicio1.getDataInicio());

                        Aluno DataDeConclusao1 = new Aluno();
                        Console.Write("\nDATA DE CONCLUSÃO (DD/MM/AAAA): ");
                        DataDeConclusao1.setDataConclusao(Convert.ToDateTime(Console.ReadLine()));
                        Console.Write(DataDeConclusao1.getDataConclusao());

                        Console.Write("\nVALOR DO DESCONTO: ");
                        Aluno1.setValorDesconto(Convert.ToDouble(Console.ReadLine()));
                        Console.Write("\nSITUAÇÃO: ");
                        Aluno1.setSituacao(Console.ReadLine());

                        //HERANÇA PESSOA
                        Console.Write("\nCPF: ");
                        Aluno1.setCpf(Console.ReadLine());
                        Console.Write("\nNOME: ");
                        Aluno1.setNome(Console.ReadLine());
                        Console.Write("\nRG: ");
                        Aluno1.setRg(Console.ReadLine());

                        Pessoa DataDeNascimento2 = new Pessoa();
                        Console.Write("\nDATA DE NASCIMENTO (DD/MM/AAAA): ");
                        Aluno1.setDataNascimento(Convert.ToDateTime(Console.ReadLine()));
                        Console.Write(Aluno1.getDataNascimento());

                        Console.Write("\nTELEFONE: ");
                        Aluno1.setTelefone(Console.ReadLine());
                        Console.Write("\nEMAIL: ");
                        Aluno1.setEmail(Console.ReadLine());
                        Console.Write("\nLIBERADO (SIM) ou (NÃO): ");
                        Aluno1.setLiberado(Convert.ToString(Console.ReadLine()));//MODIFICAÇÃO PARA STRING
                        Aluno1.setEndereco(Endereco1);


                        //ASSOCIAÇÃO CURSO
                        Aluno1.setCurso(Curso1);


                        //OBS:
                        // CODIGO DE BUSCA DO DADOS (CURSO) NO ARRAY
                        Console.Write("\nDIGITE O NOME DO CURSO: ");
                        string nome = (Console.ReadLine());

                        //BUSCA CURSO COM O NOME DIGITADO
                        Curso c = buscarCurso(nome);

                        //VERIFICA SE EXISTE CURSO COM O NOME DIGITADO
                        if (c != null)
                        {
                            Aluno1.setCurso(c);

                            //INSERE O ALUNO NA LISTA DE ALUNOS
                            listaDeAlunos.Add(Aluno1);

                            //IMPRIMINDO DADOS DO ALUNO
                            Console.Write("******************************************");
                            Aluno1.mostraDadosAluno();
                            Console.Write("\n******************************************");
                            Console.Write("\n");
                            Console.Write("\n");
                        }
                        else
                        {
                            Console.Write("\n");
                            Console.WriteLine("** CURSO NÃO ENCONTRADO, FAVOR CADASTRAR O CURSO ANTES DE REALIZAR O CADASTRAMENTO DO ALUNO. **");
                        }


                        Console.WriteLine("");


                        Console.Write("**PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU INICIAL**\n");
                        Console.ReadKey();

                        break;




                    case 8: //OPÇÃO 08 - INSERINDO PROFESSOR

                        //Professor Professor1 = new Professor();

                        //INSERINDO DADOS DO PROFESSOR
                        Console.Write("****************************\n");
                        Console.Write("INSIRA OS DADOS DO PROFESSOR\n");
                        Console.Write("****************************\n");
                        Console.Write("\nCÓDIGO: ");
                        Professor1.setCodigo(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("\nGRADUAÇÃO: ");
                        Professor1.setGraduacao(Console.ReadLine());

                        Professor DataDaAdmissao1 = new Professor();
                        Console.Write("\nDATA DA ADMISSÃO (DD/MM/AAAA): ");
                        DataDaAdmissao1.setDataAdmissao(Convert.ToDateTime(Console.ReadLine()));
                        Console.Write(DataDaAdmissao1.getDataAdmissao());

                        Console.Write("\nSALÁRIO: ");
                        Professor1.setSalario(Convert.ToDouble(Console.ReadLine()));

                        //HERANÇA PESSOA
                        Console.Write("\nCPF: ");
                        Professor1.setCpf(Console.ReadLine());
                        Console.Write("\nNOME: ");
                        Professor1.setNome(Console.ReadLine());
                        Console.Write("\nRG: ");
                        Professor1.setRg(Console.ReadLine());

                        Pessoa DataDeNascimento3 = new Pessoa();
                        Console.Write("\nDATA DE NASCIMENTO (DD/MM/AAAA): ");
                        Professor1.setDataNascimento(Convert.ToDateTime(Console.ReadLine()));
                        Console.Write(Professor1.getDataNascimento());

                        Console.Write("\nTELEFONE: ");
                        Professor1.setTelefone(Console.ReadLine());
                        Console.Write("\nEMAIL: ");
                        Professor1.setEmail(Console.ReadLine());
                        Console.Write("\nLIBERADO (SIM) ou (NÃO): ");
                        Professor1.setLiberado(Convert.ToString(Console.ReadLine()));//MODIFICAÇÃO PARA STRING
                        Professor1.setEndereco(Endereco1);

                        Console.WriteLine("");

                        //IMPRIMINDO DADOS PROFESSOR
                        Console.Write("******************************************");
                        Professor1.mostraDadosProfessor();
                        Console.Write("\n******************************************");
                        Console.Write("\n");
                        Console.Write("\n");
                        Console.Write("**PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU INICIAL**\n");
                        Console.ReadKey();

                        //INSERINDO PROFESSOR NA LISTA
                        listaDeProfessores.Add(Professor1);


                        break;



                    case 9://OPÇÃO 09 - INSERINDO FUNCIONÁRIO

                        //Funcionario Funcionario1 = new Funcionario();

                        //INSERINDO DADOS DO FUNCIONÁRIO
                        Console.Write("******************************\n");
                        Console.Write("INSIRA OS DADOS DO FUNCIONÁRIO\n");
                        Console.Write("******************************\n");
                        Console.Write("\nCÓDIGO: ");
                        Funcionario1.setCodigo(Convert.ToInt32(Console.ReadLine()));
                        Console.Write("\nCARGO: ");
                        Funcionario1.setCargo(Console.ReadLine());

                        Funcionario DataDeAdmissao1 = new Funcionario();
                        Console.Write("\nDATA DA ADMISSÃO (DD/MM/AAAA): ");
                        DataDeAdmissao1.setDataAdmissao(Convert.ToDateTime(Console.ReadLine()));
                        Console.Write(DataDeAdmissao1.getDataAdmissao());

                        Console.Write("\nSALÁRIO: ");
                        Funcionario1.setSalario(Convert.ToDouble(Console.ReadLine()));

                        //HERANÇA PESSOA
                        Console.Write("\nCPF: ");
                        Funcionario1.setCpf(Console.ReadLine());
                        Console.Write("\nNOME: ");
                        Funcionario1.setNome(Console.ReadLine());
                        Console.Write("\nRG: ");
                        Funcionario1.setRg(Console.ReadLine());

                        Pessoa DataDeNascimento4 = new Pessoa();
                        Console.Write("\nDATA DE NASCIMENTO (DD/MM/AAAA): ");
                        Funcionario1.setDataNascimento(Convert.ToDateTime(Console.ReadLine()));
                        Console.Write(Funcionario1.getDataNascimento());

                        Console.Write("\nTELEFONE: ");
                        Funcionario1.setTelefone(Console.ReadLine());
                        Console.Write("\nEMAIL: ");
                        Funcionario1.setEmail(Console.ReadLine());
                        Console.Write("\nLIBERADO (SIM) ou (NÃO): ");
                        Funcionario1.setLiberado(Convert.ToString(Console.ReadLine()));//MODIFICAÇÃO PARA STRING
                        Funcionario1.setEndereco(Endereco1);

                        Console.WriteLine("");

                        //IMPRIMINDO DADOS FUNCIONARIO
                        Console.Write("******************************************");
                        Funcionario1.mostraDadosFuncionario();
                        Console.Write("\n******************************************");
                        Console.Write("\n");
                        Console.Write("\n");
                        Console.Write("**PRESSIONE QUALQUER TECLA PARA VOLTAR AO MENU INICIAL**\n");
                        Console.ReadKey();

                        //INSERINDO FUNCIONARIO NA LISTA
                        listaDeFuncionarios.Add(Funcionario1);

                        break;



                    case 10://OPÇÃO 10 - IMPRIMIR TUDO



                      /*  foreach (Exemplar exe in Exemplar1)
                        {
                            Console.WriteLine(exe.codigo);
                        }*/

                        /* foreach (Exemplar exemplar1 in listaDeExemplares)
                         {
                             Console.WriteLine(exemplar1.codigo);
                             Console.WriteLine(exemplar1.nroExemplar);
                             Console.WriteLine(exemplar1.exclusivo);
                             Console.WriteLine(exemplar1.livro1);
                         }*/

                          Livro1.mostraDadosLivroImprimir();
                          Exemplar1.mostraDadosExemplarImprimir();
                          Emprestimo1.mostraDadosEmprestimoImprimir();
                          Pessoa1.mostraDadosPessoaImprimir();
                          Endereco1.mostraDadosEnderecoImprimir();
                          Curso1.mostraDadosCursoImprimir();
                          Aluno1.mostraDadosAlunoImprimir();
                          Professor1.mostraDadosProfessorImprimir();
                          Funcionario1.mostraDadosFuncionarioImprimir();

                        Console.ReadKey();

                        break;

                }
            } while (Opcao != 0);
            Console.Write("*********************SAINDO*********************\n");


            Console.ReadKey();


        }

    }
}
