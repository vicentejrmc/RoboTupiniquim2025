namespace RoboTupiniquim2025.ConsoleApp
{
    internal class Exibicao
    {
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

        public static void ExibirResultado(int posR01X, int posR01Y, char direcaoAtR01, int posR02X, int posR02Y, char direcaoAtR02)
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
