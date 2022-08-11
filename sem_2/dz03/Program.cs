// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int RandomInt (int min, int max)
{
    return new Random().Next(min, max);
}
int n = 0;
while (n < 10)
{
    int val = RandomInt(1,8);
        Console.WriteLine(val);
    if (val > 10)
    {
        Console.WriteLine("выходной");
    }
    else
    {
        Console.WriteLine("рабочий день");
    }
    n = n+1;
}
