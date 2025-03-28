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

            // Teste (se) leitura correta.
            Console.WriteLine($"{eixoX} {eixoY}");
            Console.WriteLine($"{posicaoX} {posicaoY} {direcaoAt}");

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



            //Sistema  de decisão logica para Mover Robô
            switch (direcaoAt)
            {
                case 'N':
                    eixoY++;
                    break;
                case 'S':
                    eixoY--;
                    break;
                case 'O':
                    eixoX--;
                    break;
                case 'L':
                    eixoY++;
                    break;
            }


            Console.ReadLine();
        }

    }


}
