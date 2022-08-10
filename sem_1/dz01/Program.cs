// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int value1 = 10;
int value2 = 10;
if (value1 > value2)
    {Console.WriteLine("max = " + value1);}
else if (value2 == value1)
{
    Console.WriteLine(value1 + " равно " + value2);

}
else
{
    Console.WriteLine("max = " + value2);
}

