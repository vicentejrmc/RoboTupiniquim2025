using System.Diagnostics.Metrics;
using System;
using System.Security.Claims;
using System.Security.AccessControl;

namespace RoboTupiniquim2025.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        InteracaoUsuario menu = new InteracaoUsuario();

        menu.ExibirMenu();

        Console.Write("Digite o tamanho da Area a ser Explorada: ");
        string[] resposta = Console.ReadLine()!.Split(' ');

        int[] tamanhoDeArea = new int[2];

        tamanhoDeArea[0] = int.Parse(resposta[0]);
        tamanhoDeArea[1] = int.Parse(resposta[1]);

        Robo robos = new Robo();

        Console.Write($"Insira a posição inicial do Robo: ");
        robos.PosicaoInicialRobo();

        Console.WriteLine("Insira as instrunções do Robô: ");
        robos.ReceberProcessarInstruncoes();

        robos.PosicaoFinalRobo();

        Console.WriteLine("Os Robôs Retornarão a base para recarregar.");
        Console.Write("Pressione [Enter] para sair.");
        Console.ReadKey();

    }

}
