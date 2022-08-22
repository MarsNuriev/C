// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
double[] CreateRandArr(int N)
{
    double [] array = new double[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }

    return array;

}
void PrintArr(double[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
    System.Console.WriteLine();
}

double MaxMinusMin (double [] array)
{
    double max = array[0];
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    System.Console.WriteLine($"max = {max}");
    System.Console.WriteLine();
    double min = array[0];
    for (int i = 0; i < len; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double Razn = max - min;
    System.Console.WriteLine($"min = {min}");
    System.Console.WriteLine();
    return Razn;
}
double [] arr1 = CreateRandArr(4);
PrintArr(arr1);
double a = MaxMinusMin(arr1);
System.Console.WriteLine($"Разница = {a}");