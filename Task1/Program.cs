// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] OrderRow(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            int max = j;
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, max])
                {
                    max = k;
                }
            }
            int temp = arr[i, j];
            arr[i, j] = arr[i, max];
            arr[i, max] = temp;
        }

    }
    return arr;
}

Console.WriteLine("Задайте количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов: ");
int col = int.Parse(Console.ReadLine());

int[,] array = FillArray(row, col);
PrintArray(array);
Console.WriteLine();
int[,] result = OrderRow(array);
PrintArray(result);
