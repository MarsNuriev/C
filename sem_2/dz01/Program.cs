// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int RandomInt (int min, int max)
{
    return new Random().Next(min, max);
}

void ex01 (int val)
{
// int a = val / 100;
int b = val % 100;
int a = b / 10;

Console.WriteLine(val);
Console.WriteLine(a);
}

//if (a > b)
//    {Console.WriteLine(a);}
//else
//    {Console.WriteLine(b);}
//}

ex01(RandomInt(100, 1000));
