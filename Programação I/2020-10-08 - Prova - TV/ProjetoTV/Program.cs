using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTV
{
    class Program
    {

        static void Main(string[] args)
        {
            List<ModeloTV> listaDeTV = new List<ModeloTV>();
            ModeloTV tvAtiva = new ModeloTV();

            int Opcao = 5;

            do
            {

                //SALA DE TV
                Console.Clear();
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("                       TELEVISAO                         ");
                Console.WriteLine("---------------------------------------------------------");

                if (listaDeTV.Count == 0)
                {
                    Console.WriteLine("Nenhuma TV cadastra!");
                    Console.WriteLine("");

                    int op;

                    Console.WriteLine("1 - Cadastrar TV");
                    Console.WriteLine("2 - Sair\n");

                    op = Convert.ToInt32(Console.ReadLine());

                    if (op == 1)
                    {
                        Console.Clear();

                        tvAtiva = tvAtiva.cadastrarTV();
                        listaDeTV.Add(tvAtiva);

                    }else if (op == 2)
                    {
                        break;

                    }
                    else
                    {
                        Console.WriteLine("OPÇÃO INVÁLIDA!");
                        Console.WriteLine("");
                        Console.WriteLine("Digite ENTER para continuar!");

                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine("MARCA: " + tvAtiva.getMarca());
                    Console.WriteLine("MODELO: " + tvAtiva.getModelo());
                    Console.WriteLine("TAMANHO: " + tvAtiva.getTamanho() + " polegadas");
                    Console.WriteLine("CANAL: " + tvAtiva.getCanal());
                    Console.WriteLine("VOLUME: " + tvAtiva.getVolume());
                    Console.WriteLine("LIGADA: " + (tvAtiva.getLigada() ? "Sim" : "Não"));

                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("                     CONTROLE REMOTO                     ");
                    Console.WriteLine("---------------------------------------------------------");

                    Console.WriteLine("1 - Ligar / Desligar");
                    Console.WriteLine("2 - Mudar de Canal");
                    Console.WriteLine("3 - Aumentar Volume");
                    Console.WriteLine("4 - Diminuir Volume");
                    Console.WriteLine("");
                    Console.WriteLine("5 - Trocar de TV");
                    Console.WriteLine("6 - Consultar TVs Disponiveis");
                    Console.WriteLine("7 - Cadastrar nova TV");
                    Console.WriteLine("8 - Sair");
                    Console.WriteLine("---------------------------------------------------------");

                    Opcao = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (Opcao)
                    {
                        case 1:
                            {
                                // LIGAR / DESLIGAR TV
                                if (tvAtiva.getLigada() == false)
                                {
                                    tvAtiva.setLigada(tvAtiva.Ligar());
                                }
                                else
                                {
                                    tvAtiva.setLigada(tvAtiva.Desligar());
                                }
                            }
                            break;


                        case 2:
                            {
                                // MUDAR DE CANAL
                                if (tvAtiva.getLigada() == true)
                                {
                                    Console.Write("Digite o CANAL desejado: ");
                                    tvAtiva.setCanal(Convert.ToInt32(Console.ReadLine()));

                                }
                                else
                                {
                                    Console.WriteLine("TV DESLIGADA");
                                    Console.WriteLine("");
                                    Console.WriteLine("Digite ENTER para continuar!");
                                    Console.ReadKey();
                                }
                            }
                            break;

                        case 3:
                            {
                                // AUMENTAR VOLUME

                                if (tvAtiva.getLigada() == true)
                                {
                                    Console.WriteLine("VOLUME Atual " + tvAtiva.getVolume() + "\n");


                                    if (tvAtiva.getVolume() <= 50 && tvAtiva.getVolume() >= 0)
                                    {
                                        int volumeDesejado;

                                        Console.Write("Digite o quanto quer AUMENTAR: ");
                                        volumeDesejado = (Convert.ToInt32(Console.ReadLine()));

                                        if ((volumeDesejado + tvAtiva.getVolume()) > 50)
                                        {
                                            Console.WriteLine("Volume MÁXIMO É 50!\n");
                                            tvAtiva.setVolume(50);
                                            Console.WriteLine("Digite ENTER para continuar!");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            tvAtiva.AumentaVolume(volumeDesejado);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("TV DESLIGADA");
                                    Console.WriteLine("");
                                    Console.WriteLine("Digite ENTER para continuar!");

                                    Console.ReadKey();
                                }
                            }
                            break;


                        case 4:
                            {
                                // DIMINUIR VOLUME

                                if (tvAtiva.getLigada() == true)
                                {
                                    Console.WriteLine("VOLUME Atual " + tvAtiva.getVolume() + "\n");


                                    if (tvAtiva.getVolume() <= 50 && tvAtiva.getVolume() >= 0)
                                    {
                                        int volumeDesejado;

                                        Console.Write("Digite o quanto quer DIMINUIR: ");
                                        volumeDesejado = (Convert.ToInt32(Console.ReadLine()));

                                        if ((tvAtiva.getVolume() - volumeDesejado) < 0)
                                        {
                                            Console.WriteLine("Volume MÍNIMO É 0!\n");
                                            tvAtiva.setVolume(0);
                                            Console.WriteLine("Digite ENTER para continuar!");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            tvAtiva.DiminuiVolume(volumeDesejado);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("TV DESLIGADA");
                                    Console.WriteLine("");
                                    Console.WriteLine("Digite ENTER para continuar!");

                                    Console.ReadKey();
                                }
                            }
                            break;

                        case 5:
                            {
                                // TROCAR TV

                                Console.Clear();
                                Console.WriteLine("---------------------------------------------------------");
                                Console.WriteLine("                      TROCAR TV                          ");
                                Console.WriteLine("---------------------------------------------------------");

                                string marcaDesejada;
                                string modeloDesejado;
                                int contador = 0;

                                Console.Write("Digite a MARCA: ");
                                marcaDesejada = Console.ReadLine();
                                Console.Write("Digite o MODELO: ");
                                modeloDesejado = Console.ReadLine();

                                

                                foreach (ModeloTV item in listaDeTV)
                                {

                                    if (item.getMarca() == marcaDesejada && item.getModelo() == modeloDesejado)
                                    {
                                        tvAtiva = item;
                                        contador++;

                                        Console.Clear();
                                        Console.WriteLine("---------------------------------------------------------");
                                        Console.WriteLine("                      TROCAR TV                          ");
                                        Console.WriteLine("---------------------------------------------------------");
                                        Console.WriteLine("TV ALTERADA!");
                                    }
                                }

                                if (contador == 0)
                                {
                                    Console.WriteLine("TV NÃO ENCONTRADA!");
                                }

                                Console.WriteLine(".........................................................");
                                Console.WriteLine("");
                                Console.WriteLine("Digite ENTER para continuar!");
                                Console.ReadKey();

                            }
                            break;

                        case 6:
                            {
                                // CONSULTAR TVS DISPONIVEIS
                                int op;

                                Console.Clear();
                                Console.WriteLine("---------------------------------------------------------");
                                Console.WriteLine("                      CONSULTAR TV                       ");
                                Console.WriteLine("---------------------------------------------------------");
                                
                                Console.WriteLine("1 - Por MARCA");
                                Console.WriteLine("2 - Por MODELO");
                                Console.WriteLine("3 - Listar todas\n");

                                op = Convert.ToInt32(Console.ReadLine());

                                if (op == 1)
                                {
                                    // CONSULTA POR MARCA

                                    string marcaDesejada;

                                    Console.Write("Digite a MARCA desejada: ");
                                    marcaDesejada = Console.ReadLine();

                                    int contador = 0;

                                    foreach (ModeloTV item in listaDeTV)
                                    {
                                     
                                        if (item.getMarca() == marcaDesejada)
                                        {
                                            
                                            Console.WriteLine(".........................................................");
                                            Console.WriteLine("MARCA: " + item.getMarca());
                                            Console.WriteLine("MODELO: " + item.getModelo());
                                            Console.WriteLine("TAMANHO: " + item.getTamanho() + " polegadas");
                                            contador++;
                                        }
                                                                              
                                    }

                                    if (contador == 0)
                                    {
                                        Console.WriteLine("MARCA NÃO ENCONTRADA!");
                                    }

                                    Console.WriteLine(".........................................................");
                                    Console.WriteLine("");
                                    Console.WriteLine("Digite ENTER para continuar!");
                                    Console.ReadKey();

                                }
                                else if (op == 2)
                                {
                                    // CONSULTA POR MODELO

                                    string modeloDesejado;

                                    Console.Write("Digite o MODELO desejado: ");
                                    modeloDesejado = Console.ReadLine();

                                    int contador = 0;

                                    foreach (ModeloTV item in listaDeTV)
                                    {
                                        

                                        if (item.getMarca() == modeloDesejado)
                                        {
                                            Console.WriteLine(".........................................................");
                                            Console.WriteLine("MARCA: " + item.getMarca());
                                            Console.WriteLine("MODELO: " + item.getModelo());
                                            Console.WriteLine("TAMANHO: " + item.getTamanho() + " polegadas");

                                            contador++;
                                        }

                                        
                                    }

                                    if (contador == 0)
                                    {
                                        Console.WriteLine("MODELO NÃO ENCONTRADO!");
                                    }

                                    Console.WriteLine(".........................................................");
                                    Console.WriteLine("");
                                    Console.WriteLine("Digite ENTER para continuar!");
                                    Console.ReadKey();

                                }
                                else if (op == 3)
                                {
                                    // LISTAR TODOS

                                    foreach (ModeloTV item in listaDeTV)
                                    {
                                        Console.WriteLine(".........................................................");
                                        Console.WriteLine("MARCA: " + item.getMarca());
                                        Console.WriteLine("MODELO: " + item.getModelo());
                                        Console.WriteLine("TAMANHO: " + item.getTamanho() + " polegadas");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("OPÇÃO INVÁLIDA!");
                                    Console.WriteLine("");
                                    Console.WriteLine("Digite ENTER para continuar!");
                                }

                                Console.WriteLine(".........................................................");
                                Console.WriteLine("");
                                Console.WriteLine("Digite ENTER para continuar!");
                                Console.ReadKey();
                            }
                            break;

                        case 7:
                            {                                
                                // CADASTRAR NOVA TV
                                Console.Clear();

                                tvAtiva = tvAtiva.cadastrarTV();
                                listaDeTV.Add(tvAtiva);
                            }
                            break;

                        case 8:
                            {
                                // SAIR
                                Opcao = 0;
                            }
                            break;


                        default:
                            {
                                Console.WriteLine(" OPÇÃO INVÁLIDA! ");

                                Console.ReadKey();
                            }
                            break;
                    }
                }
               
            } while (Opcao != 0);

            Console.Clear();
            Console.WriteLine("---------------- VOCÊ SAIU DO PROGRAMA ------------------");
            Console.WriteLine("");
            Console.WriteLine("Digite ENTER para continuar!");
            Console.ReadKey();

        }
    }
}
