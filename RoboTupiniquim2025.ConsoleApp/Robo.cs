namespace RoboTupiniquim2025.ConsoleApp;

public class Robo
{
    char direcao;
    public int posicaoY; 
    public int posicaoX;
    char[] instrucoes;


    public void PosicaoInicialRobo()
    {
        string[] posicaoInicial = Console.ReadLine()!.ToUpper().Split(' ');

        posicaoX = int.Parse(posicaoInicial[0]);
        posicaoY = int.Parse(posicaoInicial[1]);
        direcao = char.Parse(posicaoInicial[2]);
    }

    public void ReceberProcessarInstruncoes()
    {
        string respostaInstrucoes = Console.ReadLine()!.ToUpper();
        respostaInstrucoes.ToCharArray();

        instrucoes = new char[respostaInstrucoes.Length];

        for (int i = 0; i < respostaInstrucoes.Length; i++)
        {
            instrucoes[i] = respostaInstrucoes[i];

            if (instrucoes[i] == 'E')
                GirarEsquerda();
            else if (instrucoes[i] == 'D')
                GirarDireita();
            else if (instrucoes[i] == 'M')
                MoverRobo();

        }
    }

    public void GirarEsquerda()
    {
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
    }

    public void GirarDireita()
    {
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
    }

    public void MoverRobo()
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

    public void PosicaoFinalRobo()
    {
        Console.WriteLine($"{posicaoX} {posicaoY} {direcao}");
    }

}
