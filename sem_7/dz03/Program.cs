// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.Write($"{array[i, j]:000} ");
        }
        Console.WriteLine();
    }

}

void Arithm(int[,] array)
{
    int[] sum = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[j, i];
            //System.Console.Write($"{sum[i]} ");
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Средние арифметические столбцов равны:");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double arit = sum[j] * 1.0 / array.GetLength(0);
        System.Console.Write($"{arit:0.0} ");
    }
}

int[,] arr = CreateArray(4, 4);
PrintArray(arr);
Arithm(arr);


