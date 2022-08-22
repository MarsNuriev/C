// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateRandArr(int N)
        {
            int [] array = new int[N];
            //System.Console.WriteLine(array);
            for (int i = 0; i < N; i++)
            {
                array[i] = new Random().Next(100, 1000);
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

int Chet (int [] array)
{
    int count1 = 0;
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (array[i] % 2 == 0)
        {
            count1 = count1 + 1;
        }
    }
    return count1;
}


int [] arr1 = CreateRandArr(10);
PrintArr(arr1);
int a = Chet(arr1);
System.Console.WriteLine(a);