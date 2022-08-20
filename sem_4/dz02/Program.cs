// // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int SumCifr (int a)
{
    int sum = 0;
    int lenghth = Convert.ToString(a).Length;
    for (int i = 0; i <= lenghth; i++)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
}
int c = SumCifr(4522);
Console.WriteLine(c);