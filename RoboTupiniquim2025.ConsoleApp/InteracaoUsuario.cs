namespace RoboTupiniquim2025.ConsoleApp
{
    public class InteracaoUsuario
    {
        public int[] tamanhoDeArea = new int[2];
        public char[] instrucoes;
        public int posicaoX;
        public int posicaoY;
        public char direcao;


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

        public void EntradaDeDados()
        {
            Console.Write("Digite o tamanho da Area a ser Explorada: ");
            string[] resposta = Console.ReadLine()!.Split(' ');

            tamanhoDeArea[0] = int.Parse(resposta[0]);
            tamanhoDeArea[1] = int.Parse(resposta[1]);

            Console.Write($"Insira a posição inicial do Robo: ");
            string[] posicaoInicial = Console.ReadLine()!.ToUpper().Split(' ');

            posicaoX = int.Parse(posicaoInicial[0]);
            posicaoY = int.Parse(posicaoInicial[1]);
            direcao = char.Parse(posicaoInicial[2]);

            Console.WriteLine("Insira as instrunções do Robô: ");
            string respostaInstrucoes = Console.ReadLine()!.ToUpper();
            respostaInstrucoes.ToCharArray();

            instrucoes = new char [respostaInstrucoes.Length];

            for (int i = 0; i < respostaInstrucoes.Length; i++)
            {
                instrucoes[i] = respostaInstrucoes[i];
            }

        }

        public void ExibirResultado()
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
            //Console.WriteLine($"{posR01X} {posR01Y} {direcaoAtR01}");
            //Console.WriteLine("Posição final Robô02-C3PO");
            //Console.WriteLine($"{posR02X} {posR02Y} {direcaoAtR02}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"{percentDados}% de dados Coletados processados com Sucesso.");
            Console.WriteLine("--------------------------------------");
        }


    }
}
