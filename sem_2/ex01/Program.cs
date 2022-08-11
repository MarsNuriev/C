// задать случайное число из диапазона чисел, выбрать максимальную цифру этого числа

int RandomInt (int min, int max)
{
    return new Random().Next(min, max);
}

void ex01 (int val)
{
int a = val / 10;
int b = val % 10;
Console.WriteLine(val);
if (a > b)
    {Console.WriteLine(a);}
else
    {Console.WriteLine(b);}
}

ex01(RandomInt(10, 100));

string ex02(int val1)
{
    string result = string.Empty;
    int a = val1 / 10;
    int b = val1 % 10;

    result = Convert.ToString(val1) + " ";

    if (a > b)
        {result = result + "max " + Convert.ToString(a);}
    else
        {result = result + "max " + Convert.ToString(b);}

    return result;
}

Console.WriteLine(ex02(RandomInt(10,100)));

