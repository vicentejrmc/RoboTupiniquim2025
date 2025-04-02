namespace RoboTupiniquim2025.ConsoleApp
{
    public class InteracaoUsuario
    {
       
        public void ExibirMenu()
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


    }
}
