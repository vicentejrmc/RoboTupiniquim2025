using System.Diagnostics.Metrics;
using System;

namespace RoboTupiniquim2025.ConsoleApp
{
    internal class Program
    {
        //Requisitos para implementação:
        //---------------------------------------------------------    


        //Ler os comandos de direcionamento dados ao robô.
        //Processar os comandos de direcionamento dados ao robô.
        //Mover o robô de acordo às coordenadas de entrada. (../Leitura e entrada:/2.b:)
        //a: Criar métodos para movimentação do robô. (Direita/Esquerda 90°)
        //b: Criar método para mover o robô conforme(Direção/Mover) ((x1, y0 = x, y+1) == x1, y1.)
        //Exibir a posição final do robô.


        static void Main(string[] args)
        {
            //Leitura das coordenadas do canto superior direito da área.
            Console.Write("Cantos Superior Direito: ");
            string[] cantoSuperiorDi = Console.ReadLine().Split(" ");
            cantoSuperiorDi.ToArray();

            int[] grid = new int[cantoSuperiorDi.Length];
            for (int i = 0; i < cantoSuperiorDi.Length; i++)
            {
                grid[i] = int.Parse(cantoSuperiorDi[i]);
            }



            





            Console.ReadLine();
        }

    }
}
