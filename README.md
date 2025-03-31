# Robô Tupiniquim 2025

## Sobre o Projeto:

- O projeto tem como objetivo o desenvolvimento de habilidades relacionadas á lógica de programação Sequencial e Estruturada, fazendo o uso da
Linguagem de Programação C#, e funcionando no modo ConsoleApp.

- Trata-se de um cenário hípotetico, onde a função do desenvolvedor é criar o sistema de controle para dois robôs que estão em uma missão de exploração em marte.

## Funcionalidades:

- O objetivo do sistema é receber parametros que determinarão:
1. O tamanho da área a ser explorada pelos Robôs.
2. A posição inicial de cada um deles sendo: (X, Y, Z).
	Posição X , Y (Plano cartesiano) Z (Letra que tetermina à sua direção sendo N, S, L, O. (Norte, Sul, Leste, Oeste))
3. Os comandos de orientação são enviados em forma de string e interpretados pelo programa
	a. Comandos(EMEMED (esquerda, mover, esquerda, mover, esquerda, direita))
	b. A cada letra lida o Programa execultara um comando de forma individual.
4. Após o processamendo dos comandos, como resultado, devera ser apresentada a posição final de cada robô.
5. O programa após concluido, dará a opção para o usuario de iniciar uma nova "caminhada" inserindo novos parâmetros. 

## Como Ultilizar:

1. Clone o repositorio ou baixe o codigo fonte.
2. Abra o Terminal ou prompt de Comando e navegue até a pasta raiz.
3. Utilize o camando abaixo para restaurar as dependências do projeto.
```
 dotnet restore
```

4. Compile a solução utilizando o comando:

```
 dotnet build --configuration Release
```

5.Para executar o projeto compilando em tempo real

```
 dotnet run --project RoboTupiniquim2025.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta ./RoboTupiniquim2025.ConsoleApp/bin/Release/net8.0/ e execute o arquivo:  
 RoboTupiniquim.ConsoleApp.exe 

## Demosntração:

![](https://i.imgur.com/q74dXy8.gif)

