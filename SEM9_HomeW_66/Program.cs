// Задача 66. Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов 
// в промежутке от M до N (с помощью рекурсии).

int SumOfNumbers(int m, int n)
{
    if (n == m)
        return n;
    return SumOfNumbers(m, n-1) + n;

}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfNumbers(m, n));
