using System.Diagnostics.Metrics;
using System;

namespace RoboTupiniquim2025.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eixoX, eixoY;
            int posicaoX, posicaoY;
            char direcaoAt;


            //Leitura das coordenadas do canto superior direito da área.
            Console.Write("Cantos Superior Direito: ");
            string[] cantoSuperiorDi = Console.ReadLine().Split(" ");
            cantoSuperiorDi.ToArray();

            int[] grid = new int[cantoSuperiorDi.Length];
            for (int i = 0; i < cantoSuperiorDi.Length; i++)
            {
                grid[i] = int.Parse(cantoSuperiorDi[i]);
            }
            eixoX = grid[0];
            eixoY = grid[1];

            // posicão incial do robô
            Console.Write("Posicao inicial: ");
            string[] posicaoIncialRo = Console.ReadLine().ToUpper().Split(" ");

            int[] posicaoRobo = new int[posicaoIncialRo.Length - 1];
            for (int i = 0; i < posicaoIncialRo.Length - 1; i++)
            {
                posicaoRobo[i] = int.Parse(posicaoIncialRo[i]);
            }
            posicaoX = posicaoRobo[0];
            posicaoY = posicaoRobo[1];
            direcaoAt = char.Parse(posicaoIncialRo[2]);

            //Ler os comandos de direcionamento dados ao robô.
            Console.Write("Enviar Comandos: ");
            string comandosEnviados = Console.ReadLine().ToUpper();
            comandosEnviados.ToArray();

            char[] processarComandos = new char[comandosEnviados.Length];
            for (int i = 0; i < comandosEnviados.Length; i++)
            {
                processarComandos[i] = (comandosEnviados[i]);
                //teste de implementação / leitura
                Console.WriteLine(processarComandos[i]);
            }


            for (int i = 0; i < processarComandos.Length; i++)
            {
                if (processarComandos[i] == 'E')
                    direcaoAt = GirarEsquerda(direcaoAt);

                else if (processarComandos[i] == 'D')
                    direcaoAt = GirarDireita(direcaoAt);
                else if (processarComandos[i] == 'M')
                {
                    switch (direcaoAt)
                    {
                        case 'N':
                            posicaoY++;
                            break;
                        case 'S':
                            posicaoY--;
                            break;
                        case 'O':
                            posicaoX--;
                            break;
                        case 'L':
                            posicaoX++;
                            break;

                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"{eixoX} {eixoY}");
            Console.WriteLine($"{posicaoX} {posicaoY} {direcaoAt}");

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

    }
}
