namespace RoboTupiniquim2025.ConsoleApp
{
    internal class Orientacao
    {
        public static char GirarEsquerda(char direcaoAt)
        {
            //Girar Esquerda
            switch (direcaoAt)
            {
                case 'N':
                    direcaoAt = 'O';
                    break;
                case 'O':
                    direcaoAt = 'S';
                    break;
                case 'S':
                    direcaoAt = 'L';
                    break;
                case 'L':
                    direcaoAt = 'N';
                    break;
            }

            return direcaoAt;
        }

        public static char GirarDireita(char direcaoAt)
        {
            //Girar Direita
            switch (direcaoAt)
            {
                case 'N':
                    direcaoAt = 'L';
                    break;
                case 'L':
                    direcaoAt = 'S';
                    break;
                case 'S':
                    direcaoAt = 'O';
                    break;
                case 'O':
                    direcaoAt = 'N';
                    break;
            }

            return direcaoAt;
        }

    }
}
