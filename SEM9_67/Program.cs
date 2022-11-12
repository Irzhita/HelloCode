// Задача 67. Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

int NumbersSum(int n)
{
    if (n / 10 == 0)
        return n;
    return NumbersSum(n / 10) + n % 10;
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumbersSum(n));
