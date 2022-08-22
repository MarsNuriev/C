// // Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
int [] arr = {1,2,3,4};
void PrintArr(int [] array)
{
    int count = arr.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}
PrintArr(arr);

System.Console.WriteLine();

// int [] arr2 = new int [4];
int [] CreateRandArrSize (int min, int max)
{
    int N = new Random().Next(min,max);
    return new int[N];
}

void FillPrintRandArr (int [] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 10);
        System.Console.Write($"{array[i]} ");
    }
}
int [] arr3 = CreateRandArrSize(1,9);
FillPrintRandArr(arr3);