﻿// // Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

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
