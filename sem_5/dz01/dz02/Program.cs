// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int[] CreateRandArr(int N)
        {
            int [] array = new int[N];
            //System.Console.WriteLine(array);
            for (int i = 0; i < N; i++)
            {
                array[i] = new Random().Next(1, 10);
            }

            return array;
        }

void PrintArr(int[] array)
        {
            int count = array.Length;
            Console.Write("[");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.Write("]");
            System.Console.WriteLine();
        }
int SumNechEl (int [] array)
{
    int sum = 0;
    int count1 = array.Length;
    for (int i = 0; i < count1; i++)
    {
        if (i % 2 > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int [] arr = CreateRandArr(10);
PrintArr(arr);
int a = SumNechEl(arr);
System.Console.WriteLine(a);