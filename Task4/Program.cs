// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] FillArray(int z, int x, int y)
{
    Random r = new Random();
    int[,,] arr = new int[z, x, y];
    int temp;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = r.Next(1, 100);
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write(arr[i, j, k] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void PrintArrayWithIndex(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($" Под индексом ({i},{j},{k}) лежит значение {arr[i, j, k]}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задайте первый параметр трехмерного массива: ");
int z = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте второй параметр трехмерного массива: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте третий параметр трехмерного массива: ");
int y = int.Parse(Console.ReadLine());

int[,,] array = FillArray(z, x, y);
Console.WriteLine("Вывод трехмерного массива: ");
PrintArray(array);
Console.WriteLine();
PrintArrayWithIndex(array);



