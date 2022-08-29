//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
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
            Console.Write($"{array[i, j]:00} ");
        }
        Console.WriteLine();
    }

}

int[,] arr = CreateArray(4,4);
PrintArray(arr);

// System.Console.WriteLine("Введите коордианты массива: ");
// System.Console.Write("Строка = ");
// int arrrow = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Столбец = ");
// int arrcol = Convert.ToInt32(Console.ReadLine());

void ArrayPoint (int[,] array,int row, int col)
{
    if (row < array.GetLength(0) && col < array.GetLength(1))
    {
        int result = array[row, col];
        System.Console.WriteLine($"Значение элемента = {result}");
    }
    else
    {
        System.Console.WriteLine("Такого числа в массиве нет");
    }
}
ArrayPoint(arr,2,2);