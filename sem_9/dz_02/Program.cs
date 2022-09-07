// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummNatur(int m, int n)
{
    int sum = m;

    if (n > m)
    {
        sum = sum + SummNatur(m + 1, n);
    }
    return sum;

}

int summa = SummNatur(1, 15);
System.Console.WriteLine(summa);