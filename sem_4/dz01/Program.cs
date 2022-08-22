// // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


int Step (int a, int b)
{
    int res = a;
    for (int i = 1; i < b; i++)
    {
        res = a*res;
    }
    return res;
}
int c = step(2,5);
Console.WriteLine(c);
