// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



int[] arr = { 0, 1, 2, 3, -5, -6, 8, 9, 10, 13 };
int a = 0;
int N = arr.Length;
for (int i = 0; i< N; i++)
{
    if (arr[i]>0)
    {
        a = a+1;
    }
}
System.Console.WriteLine(N);
Console.WriteLine(a);



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
