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
            ExibirMenu();

            //Leitura das coordenadas do canto superior direito da área.
            Console.Write("Canto Superior Direito:");
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
                    direcaoAtR01 = GirarEsquerda(direcaoAtR01);
                else if (processarComandosR01[i] == 'D')
                    direcaoAtR01 = GirarDireita(direcaoAtR01);
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
                    direcaoAtR02 = GirarEsquerda(direcaoAtR02);
                else if (processarComandosR02[i] == 'D')
                    direcaoAtR02 = GirarDireita(direcaoAtR02);
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

            ExibirResultado();

            Console.ReadLine();
        }
        public static char GirarEsquerda(char direcaoAt)
        {
            //Girar Esquerda
            switch (direcaoAt)
            {
                case 'N':
                    direcaoAt = 'O';
                    break;
                case 'O':
                    direcaoAt = 'S';
                    break;
                case 'S':
                    direcaoAt = 'L';
                    break;
                case 'L':
                    direcaoAt = 'N';
                    break;
            }

            return direcaoAt;
        }

        public static char GirarDireita(char direcaoAt)
        {
            //Girar Direita
            switch (direcaoAt)
            {
                case 'N':
                    direcaoAt = 'L';
                    break;
                case 'L':
                    direcaoAt = 'S';
                    break;
                case 'S':
                    direcaoAt = 'O';
                    break;
                case 'O':
                    direcaoAt = 'N';
                    break;
            }

            return direcaoAt;
        }

        public static void ExibirMenu()
        {
            Random batery = new Random();
            Random temp = new Random();
            double clima = temp.Next(-125, 22);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("------- Robô Tupiniquim 2025 ---------");
            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine($"Temperatura em marte: {clima}° Celcius.");

            Console.WriteLine("Status da Missão:");
            int percent = batery.Next(76, 100);
            Console.WriteLine($"Robo01-R2D2: Conecção Estável - Baterias: {percent.ToString("F1")}%");
            Console.WriteLine("--------------------------------------");
            batery.Next(76, 100);
            percent = batery.Next(76, 100);
            Console.WriteLine($"Robo02-C3PO: Conecção Estável - Baterias: {percent.ToString("F1")}%");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Insira os parametros necessarios:\n");
            Console.WriteLine("Ex: Canto superior Direito (5 5): Posição Inicial:(1 5 L) Comandos:(EMEMEMEEM)\n");
        }

        public static void ExibirResultado()
        {
            Random dadosProcessados = new Random();
            double percentDados = dadosProcessados.Next(60, 100);

            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("------- Robô Tupiniquim 2025 ---------");
            Console.WriteLine("--------------------------------------\n");

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Percurso Completado:");
            Console.WriteLine("Dados de Solo Coletados");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Posição final Robô01-R2D2:");
            Console.WriteLine($"{posR01X} {posR01Y} {direcaoAtR01}");
            Console.WriteLine("Posição final Robô02-C3PO");
            Console.WriteLine($"{posR02X} {posR02Y} {direcaoAtR02}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"{percentDados}% de dados Coletados processados com Sucesso.");
            Console.WriteLine("--------------------------------------");
        }
    }
}
