// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] FillArray(int x, int y)
{
    int[,] arr = new int[x, y];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrixProduct(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrixResult = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                matrixResult[i, j] = matrixResult[i, j] + matrixOne[i, k] * matrixTwo[k, j];
            }
        }
    }
    return matrixResult;
}

Console.WriteLine("Задайте количество строк в первой матрице: ");
int rowFirst = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов в первой матрице: ");
int colFirst = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество строк во второй матрице: ");
int rowSecond = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов в0 второй матрице: ");
int colSecond = int.Parse(Console.ReadLine());

if (colFirst == rowSecond)
{
    int[,] arrayFirst = FillArray(rowFirst, colFirst);
    Console.WriteLine("Первая матрица: ");
    PrintArray(arrayFirst);
    Console.WriteLine();
    int[,] arraySecond = FillArray(rowSecond, colSecond);
    Console.WriteLine("Вторая матрица: ");
    PrintArray(arraySecond);
    Console.WriteLine();
    int[,] result = GetMatrixProduct(arrayFirst, arraySecond);
    Console.WriteLine("Произведение первой и второй матриц матрица: ");
    PrintArray(result);
}
else Console.WriteLine("Такие матрицы нельзя перемножить, т.к. количество столбцов первой матрицы не равно количеству строк второй матрицы");

