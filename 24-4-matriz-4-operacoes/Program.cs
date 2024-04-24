int qtdlinhas = 3, qtdcolunas = 4;

float[,] matriz1 = new float[qtdlinhas, qtdcolunas];
float[,] matriz2 = new float[qtdlinhas, qtdcolunas];
float[,] matriz3 = new float[qtdlinhas, qtdcolunas];

//criacao da matriz 1
for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz1[linha, coluna] = new Random().Next(1, 10);//pode colocar pra iniciar em 0
    }
}
for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz1[linha, coluna] + " ");
    }
}

//criacao da matriz 2
for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz2[linha, coluna] = new Random().Next(1, 10);//pode colocar pra iniciar em 0
    }
}
Console.ReadLine();
for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz2[linha, coluna] + " ");
    }
}
Console.ReadLine();

//matriz3 soma
Console.Write("\nMatriz Soma");
for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
    }
}
for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz3[linha, coluna] + " ");
    }
}
Console.ReadLine();

//matriz 3 subtração
Console.Write("\nMatriz Subtração");
for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
    }
}
for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz3[linha, coluna] + " ");
    }
}
Console.ReadLine();

//matriz 3 multiplicacao
Console.Write("\nMatriz Multiplicação");
for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
    }
}
for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz3[linha, coluna] + " ");
    }
}
Console.ReadLine();

//matriz 3 divisão
Console.Write("\nDivisão");

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        if (matriz2[linha, coluna] != 0)
            matriz3[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
        else
            matriz3[linha, coluna] = float.NaN;   
    }
}
for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz3[linha, coluna] + " ");
    }
}
Console.WriteLine();