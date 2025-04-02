namespace RoboTupiniquim2025.ConsoleApp;

public class Robo
{
    char direcao;
    int posicaoY; 
    int posicaoX;


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

    public void ProcessarComandos()
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

}
