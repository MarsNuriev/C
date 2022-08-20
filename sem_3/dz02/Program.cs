// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double dlina (int x1, int y1, int x2, int y2, int z1, int z2)
{
    double dl = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
    return dl;
}

Console.WriteLine(dlina (15, -5, 25, -5, 35, -5));
