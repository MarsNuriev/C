// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int value1 = 5;
int value2 = 5;
int value3 = 7;
if (value1 > value2 & value1 > value3)
    Console.WriteLine(value1);
else if(value2 > value1 & value2 > value3)
    Console.WriteLine(value2);
else
    Console.WriteLine(value3);