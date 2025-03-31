# Rob� Tupiniquim 2025

## Sobre o Projeto:

- O projeto tem como objetivo o desenvolvimento de habilidades relacionadas � l�gica de programa��o Sequencial e Estruturada, fazendo o uso da
Linguagem de Programa��o C#, e funcionando no modo ConsoleApp.

- Trata-se de um cen�rio h�potetico, onde a fun��o do desenvolvedor � criar o sistema de controle para dois rob�s que est�o em uma miss�o de explora��o em marte.

## Funcionalidades:

- O objetivo do sistema � receber parametros que determinar�o:
1. O tamanho da �rea a ser explorada pelos Rob�s.
2. A posi��o inicial de cada um deles sendo: (X, Y, Z).
	Posi��o X , Y (Plano cartesiano) Z (Letra que tetermina � sua dire��o sendo N, S, L, O. (Norte, Sul, Leste, Oeste))
3. Os comandos de orienta��o s�o enviados em forma de string e interpretados pelo programa
	a. Comandos(EMEMED (esquerda, mover, esquerda, mover, esquerda, direita))
	b. A cada letra lida o Programa execultara um comando de forma individual.
4. Ap�s o processamendo dos comandos, como resultado, devera ser apresentada a posi��o final de cada rob�.
5. O programa ap�s concluido, dar� a op��o para o usuario de iniciar uma nova "caminhada" inserindo novos par�metros. 

## Como Ultilizar:

1. Clone o repositorio ou baixe o codigo fonte.
2. Abra o Terminal ou prompt de Comando e navegue at� a pasta raiz.
3. Utilize o camando abaixo para restaurar as depend�ncias do projeto.
```
 dotnet restore
```

4. Compile a solu��o utilizando o comando:

```
 dotnet build --configuration Release
```

5.Para executar o projeto compilando em tempo real

```
 dotnet run --project RoboTupiniquim2025.ConsoleApp
```

6. Para executar o arquivo compilado, navegue at� a pasta ./RoboTupiniquim2025.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:  
 RoboTupiniquim.ConsoleApp.exe 

## Demosntra��o:

![](https://i.imgur.com/q74dXy8.gif)

