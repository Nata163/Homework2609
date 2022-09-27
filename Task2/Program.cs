// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
            Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
}

int[] GetSumElements(int[,] arr, int rowCount)
{
    int[] sum = new int[rowCount];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] = sum[i] + arr[i, j];
        }
    }
    return sum;
}

int GetRowNumberWithMinSum(int[] arr)
{
    int min = arr[0];
    int rowCount = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            rowCount = i + 1;
        }
    }
    return rowCount;
}

Console.WriteLine("Задайте количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов: ");
int col = int.Parse(Console.ReadLine());
if (row != col)
{
    int[,] array = FillArray(row, col);
    PrintArray(array);
    Console.WriteLine();
    int[] sumarray = GetSumElements(array, row);
    int result = GetRowNumberWithMinSum(sumarray);
    Console.WriteLine($"Строка с наименьшей суммой элементов под номером {result}");
}
else Console.Write("Введите новые данные, массив должен быть прямоугольный");
