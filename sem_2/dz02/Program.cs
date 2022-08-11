// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int RandomInt (int min, int max)
{
    return new Random().Next(min, max);
}

void ex01(int val)
{
    int a = val % 100;
    int b = a % 10;
    Console.WriteLine(val);
    Console.WriteLine(b);
}
//int val = RandomInt(10,1000);
//Console.WriteLine(val);
int val1 = RandomInt(10,1000);
if ( val1 < 100)
{    
    Console.WriteLine(val1);
    Console.WriteLine("третьей цифры нет");
}
else
{
    ex01(val1);
}
