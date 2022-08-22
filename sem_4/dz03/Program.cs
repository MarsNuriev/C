// // Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

internal class Program
{
    private static void Main(string[] args)
    {
        // 6, 1, 33 -> [6, 1, 33]
        int[] arr = { 1, 2, 3, 4 };
        void PrintArr(int[] array)
        {
            int count = array.Length;
            Console.Write("[");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.Write("]");
        }
        PrintArr(arr);

        System.Console.WriteLine();

        int[] CreateRandArr(int N)
        {
            int [] array = new int[N];
            //System.Console.WriteLine(array);
            for (int i = 0; i < N; i++)
            {
                array[i] = new Random().Next(100, 10000);
            }

            return array;

        }


        int[] arr3 = CreateRandArr(10);
        PrintArr(arr3);
    }
}