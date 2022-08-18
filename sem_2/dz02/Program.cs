// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

internal class Program
{
    private static void Main(string[] args)
    {
        int RandomInt(int min, int max)
        {
            return new Random().Next(min, max);
        }

        int val = RandomInt(10, 1000);
        if (val < 100)
        {
            Console.WriteLine(val);
            Console.WriteLine("третьей цифры нет");
        }
        else
        {
            int i = Convert.ToString(val).Length;
            int step = i - 3;
            double del = 1;
            del = Math.Pow(10, step);
            int delInt = Convert.ToInt32(del);
            int val1 = val / delInt;
            int val2 = val1 % 10;

            Console.WriteLine(val);
            Console.WriteLine(delInt);
            Console.WriteLine(val2);
        }
    }
}