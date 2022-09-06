// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""


void Natur(int m, int n)
{
    //     int a = 0;
    //     for (int i = m; i <= n; i++)
    //     {
    //         a = i;
    //         System.Console.WriteLine(a);
    //     }
    System.Console.WriteLine(n);

    if (n > m)
    { Natur(m, n - 1); }
}


Natur(2, 5);