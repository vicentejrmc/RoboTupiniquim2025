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
            InteracaoUsuario menu = new InteracaoUsuario();
            InteracaoUsuario entradaDeDados = new InteracaoUsuario();

            Robo robos = new Robo();

            menu.ExibirResultado();

            entradaDeDados.EntradaDeDados(robos);





            Console.WriteLine("Os Robôs Retornarão a base para recarregar.");
            Console.Write("Pressione [Enter] para sair.");
            Console.ReadKey();

        }

    }
}
