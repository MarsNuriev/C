// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine();
}

void MinSumArray(int[,] array)
{
    int[] sum = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
            //System.Console.Write($"{sum[i]} ");
        }
        //System.Console.WriteLine();
    }
    //System.Console.WriteLine();
    int minsum = sum[0];
    int minind = 0;
    //System.Console.WriteLine(minsum);
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] < minsum)
        {
            minsum = sum[i];
            minind = i;
        } 
    }
    System.Console.Write($"Cтрока {minind} имеет наименьшую сумму элементов, сумма = {minsum} ");
}

int[,] arr = CreateArray(4, 4);
PrintArray(arr);
MinSumArray(arr);