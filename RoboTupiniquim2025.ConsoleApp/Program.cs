using System.Diagnostics.Metrics;
using System;
using System.Security.Claims;

namespace RoboTupiniquim2025.ConsoleApp
{
    internal class Program
    {
        public static int posR01X, posR01Y;
        public static int posR02X, posR02Y;
        public static int eixoX, eixoY;
        public static char direcaoAtR01, direcaoAtR02;

        static void Main(string[] args)
        {
            Exibicao.ExibirMenu();

            // Estrutura de Repetição. 
            while (true)
            {
                //Leitura das coordenadas do canto superior direito da área.
                Console.Write("Canto Superior Direito: ");
                string[] cantoSuperiorDi = Console.ReadLine().Split(" ");
                cantoSuperiorDi.ToArray();

                int[] grid = new int[cantoSuperiorDi.Length];
                for (int i = 0; i < cantoSuperiorDi.Length; i++)
                    grid[i] = int.Parse(cantoSuperiorDi[i]);

                eixoX = grid[0];
                eixoY = grid[1];

                // posicão incial do Robô01
                Console.Write("Posicao inicial Robo01: ");
                string[] posIncialRo01 = Console.ReadLine().ToUpper().Split(" ");

                int[] posRobo01 = new int[posIncialRo01.Length - 1];
                for (int i = 0; i < posIncialRo01.Length - 1; i++)
                    posRobo01[i] = int.Parse(posIncialRo01[i]);

                posR01X = posRobo01[0];
                posR01Y = posRobo01[1];

                direcaoAtR01 = char.Parse(posIncialRo01[2]);

                //Ler os comandos de direcionamento dados ao Robô01.
                Console.Write("Enviar Comandos Robo01: ");
                string comandosRobo01 = Console.ReadLine().ToUpper();
                comandosRobo01.ToArray();

                char[] processarComandosR01 = new char[comandosRobo01.Length];

                for (int i = 0; i < comandosRobo01.Length; i++)
                    processarComandosR01[i] = (comandosRobo01[i]);

                for (int i = 0; i < processarComandosR01.Length; i++)
                {
                    if (processarComandosR01[i] == 'E')
                        direcaoAtR01 = Orientacao.GirarEsquerda(direcaoAtR01);
                    else if (processarComandosR01[i] == 'D')
                        direcaoAtR01 = Orientacao.GirarDireita(direcaoAtR01);
                    else if (processarComandosR01[i] == 'M')
                    {
                        switch (direcaoAtR01)
                        {
                            case 'N':
                                posR01Y++;
                                break;
                            case 'S':
                                posR01Y--;
                                break;
                            case 'O':
                                posR01X--;
                                break;
                            case 'L':
                                posR01X++;
                                break;
                        }
                    }
                }

                // Posicao inicial Robô02
                Console.Write("Posicao inicial Robo02: ");
                string[] posIncialRo02 = Console.ReadLine().ToUpper().Split(" ");

                int[] posRobo02 = new int[posIncialRo02.Length - 1];
                for (int i = 0; i < posIncialRo02.Length - 1; i++)
                    posRobo02[i] = int.Parse(posIncialRo02[i]);

                posR02X = posRobo02[0];
                posR02Y = posRobo02[1];
                direcaoAtR02 = char.Parse(posIncialRo02[2]);

                //Ler os comandos de direcionamento dados ao Robô02.
                Console.Write("Enviar Comandos Robo02: ");
                string comandosRobo02 = Console.ReadLine().ToUpper();
                comandosRobo01.ToArray();

                char[] processarComandosR02 = new char[comandosRobo02.Length];

                for (int i = 0; i < comandosRobo02.Length; i++)
                    processarComandosR02[i] = (comandosRobo02[i]);

                for (int i = 0; i < processarComandosR02.Length; i++)
                {
                    if (processarComandosR02[i] == 'E')
                        direcaoAtR02 = Orientacao.GirarEsquerda(direcaoAtR02);
                    else if (processarComandosR02[i] == 'D')
                        direcaoAtR02 = Orientacao.GirarDireita(direcaoAtR02);
                    else if (processarComandosR02[i] == 'M')
                    {
                        switch (direcaoAtR02)
                        {
                            case 'N':
                                posR02Y++;
                                break;
                            case 'S':
                                posR02Y--;
                                break;
                            case 'O':
                                posR02X--;
                                break;
                            case 'L':
                                posR02X++;
                                break;
                        }
                    }
                }

                Exibicao.ExibirResultado(posR01X, posR02Y, direcaoAtR01, posR02X, posR01Y, direcaoAtR02);

                Console.WriteLine("--------------------------------");
                Console.Write("Deseja verifica nova Área? [S/N]: ");
                string novaArea = Console.ReadLine().ToUpper();

                if (novaArea != "S")
                    break;
            }

            Console.WriteLine("Os Robôs Retornarão a base para recarregar.");
            Console.Write("Pressione [Enter] para sair.");
            Console.ReadKey();

        }
    }
}
