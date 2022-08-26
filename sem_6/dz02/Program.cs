// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[,] koord = new int[2, 2];

Console.WriteLine(koord);
void FillArr(int[,] array)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            array[i, j] = Random.Shared.Next(10);
        }
    }
}
void PrintArr(int[,] array)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            System.Console.Write($"{array[i, j],3}");
        }
        System.Console.WriteLine();
    }
}
FillArr(koord);
PrintArr(koord);

//int y1 = koord[0,0]*x + koord[0,1];
//int y2 = koord[1,0]*x + koord[1,1];
if (koord[0,0] == koord [0,1])
{
    System.Console.WriteLine("отрезки не пересекаются");
}
else
{
double x = (koord[1, 1] - koord[1, 0]) / (koord[0, 0] - koord[0, 1]);
System.Console.WriteLine($"k1 = {koord[0, 0]}, k2 = {koord[0, 1]}, b1 = {koord[1, 0]}, b2 = {koord[1, 1]}");
double y = koord[0, 0] * x + koord[0, 1];
System.Console.WriteLine($"точка пересечения: {x}, {y}");
}