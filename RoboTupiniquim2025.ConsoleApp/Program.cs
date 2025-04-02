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

        Robo[] robos = new Robo[2];
        robos[0] = new Robo();
        robos[1] = new Robo();

        for (int i = 0; i < robos.Length; i++)
        {
            Console.Write($"Insira a posição inicial do Robo 0{i + 1}: ");
            robos[i].PosicaoInicialRobo();

            Console.Write($"Insira as instrunções do Robô 0{i + 1}: ");
            robos[i].ReceberProcessarInstruncoes();
        }

        for (int i = 0;i < robos.Length;i++)
        {
            robos[i].PosicaoFinalRobo();
        }

        Console.WriteLine("Os Robôs Retornarão a base para recarregar.");
        Console.Write("Pressione [Enter] para sair.");
        Console.ReadKey();

    }

}
