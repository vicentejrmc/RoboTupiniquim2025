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

            // pocisao incial do robo

            Console.Write("Posicao inicial: ");
            string[] posicaoIncialRo = Console.ReadLine().ToUpper().Split(" ");
            posicaoIncialRo.ToArray();

            int[] posicaoRobo = new int[posicaoIncialRo.Length];
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










            Console.ReadLine();
        }

    }
}
