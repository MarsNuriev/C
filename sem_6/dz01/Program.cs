// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



//int[] arr = { 0, 1, 2, 3, -5, -6, 8, 9, 10, 13 };
//int a = 0;
//int N = arr.Length;
System.Console.WriteLine("Введите число:");
int ArrLen = Convert.ToInt32(Console.ReadLine());
int [] array = new int [ArrLen];
for (int i = 0; i< array.Length; i++)
{
    System.Console.Write($"array[{i}]: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int [] array)
{
    for (int i = 0; i< array.Length; i++)
{
    System.Console.Write($"array[{i}]: {array[i]} ");
}
}

int PositCount (int[] array)
{
    int positivecount = 0;
    for (int i = 0; i < array.Length;i++)
    {
       if (array[i] > 0) {positivecount = positivecount + 1;}
    }
    return positivecount;
}

PrintArray(array);
System.Console.WriteLine();
int count = PositCount(array);
System.Console.WriteLine($"Число положительных эл-тов = {count}");

// int a = 1231546 - 65 - 7 - 8 - 910;
// int d = 0;
// int Count(int b)
// {
//     int c = b % 10;
//     if (c > 0)
//     {
//         return d = d + 1;
//         Count((b / 10));
//     }
//     else
//     {
//         return d = d;
//         Count((b / 10));
//     }
// }
// System.Console.WriteLine(Count(a));
