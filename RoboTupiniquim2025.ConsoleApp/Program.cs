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
            char direcao;


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
            direcao = char.Parse(posicaoIncialRo[2]);

            // Teste (se) leitura correta.
            Console.WriteLine($"{eixoX} {eixoY}");
            Console.WriteLine($"{posicaoX} {posicaoY} {direcao}");

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
            switch(direcao)
            {
                case 'N':
                    direcao = 'O';
                    break;
                case 'O':
                    direcao = 'S';
                    break;
                case 'S':
                    direcao = 'L';
                    break;
                case 'L':
                    direcao = 'N';
                    break;
            }

            //Girar Direita
            switch (direcao)
            {
                case 'N':
                    direcao = 'L';
                    break;
                case 'L':
                    direcao = 'S';
                    break;
                case 'S':
                    direcao = 'O';
                    break;
                case 'O':
                    direcao = 'N';
                    break;
            }

            Console.ReadLine();
        }

    }


}
