// Задача 65. Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

string ResultNumbers(int m, int n)
{
    if (n == m)
        return $"{m}";
    return ResultNumbers(m, n-1) + ", " + Convert.ToString(n);

}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ResultNumbers(m, n));