// Спиральное заполнение массива

int n = 6;
int[,] array = new int[n, n];
void FillArr(ref int[,] array1)
{
    int m = array1.GetUpperBound(0) + 1;
    //int i, j, k, l, o = 0;
    System.Console.WriteLine($"m = {m}");
    for (int i = 0; i < m; i++)
    {
        //идем по строке

        for (int j = 0; j < m; j++)
        {
            array1[i, j] = i*m + j;
        }


        //идем по столбцу

        //for (int j = m+1; j < m+m+1; j++)
        // {
        //     array1[j, i] = j * i;
        // }
        //System.Console.WriteLine();
        //System.Console.WriteLine($"i = {i}");
        //идем по строке
        // System.Console.WriteLine($"{j}");
        // System.Console.WriteLine();
        // for (l = j; l >= 0; l--)
        // {
        //     System.Console.Write($"{k}, {l}");
        //     System.Console.WriteLine();
        //     array1[k, l] = k * 10 + l;

        // }
        // // идем по столбцу
        // System.Console.WriteLine($"{k}");
        // System.Console.WriteLine();
        // for (o = l; o >= 0; o--)
        // {
        //     System.Console.Write($"{o}, {l}");
        //     System.Console.WriteLine();
        //     array1[o, l] = o * 10 + l;
        // }
    }
}

void PrintArr(ref int[,] array1)
{
    int m = array1.GetUpperBound(0);
    for (int i = 0; i <= m; i++)
    {

        for (int j = 0; j <= m; j++)
        {
            System.Console.Write($"{array1[i, j]:d2} ");
        }
        System.Console.WriteLine();
    }
}
FillArr(ref array);
PrintArr(ref array);