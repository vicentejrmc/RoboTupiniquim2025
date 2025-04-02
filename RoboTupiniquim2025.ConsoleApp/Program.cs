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






            

            Console.WriteLine("Os Robôs Retornarão a base para recarregar.");
            Console.Write("Pressione [Enter] para sair.");
            Console.ReadKey();

        }
        public static char GirarEsquerda(char direcao)
        {
            //Girar Esquerda
            switch (direcao)
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

            return direcao;
        }

        public static char GirarDireita(char direcao)
        {
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

            return direcao;
        }

        public static void ProcessarComandos(char direcao, int posicaoY, int posicaoX)
        {
            switch (direcao)
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
