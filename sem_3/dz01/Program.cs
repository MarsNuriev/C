// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int RandomInt (int min, int max)
{
    return new Random().Next(min, max);
}

int val = RandomInt(12021, 12023);


Console.WriteLine(val);
// int[] array = new int[5];
// for (int i = 4; i >= 0; i--)
// {   
//     int array(i) = val % 10;
//     val = val /10;
// }
// Console.WriteLine(array);
int val4 = val % 10;
Console.WriteLine(val4);
int val3 = (val / 10) % 10;
Console.WriteLine(val3);
int val1 = (val / 1000) % 10;
Console.WriteLine(val1);
int val0 = (val / 10000) % 10;
Console.WriteLine(val0);
if (val4 == val0 && val3 == val1)
{
    Console.WriteLine("Число палиндром");
}
else
{
    Console.WriteLine("Число не палиндром");
}