
// Задача 63. Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N. (через рекурсию)

void Numbers(int n, int j)
{
    if (n == j)
        Console.Write($" {n} ");
    else
    {
        Console.Write($" {j} "); 
        Numbers(n, ++j); 
    }
}


string ResultNumbers(int n)
{
    if (n == 1)
        return "1";
    return ResultNumbers(n-1) + ", " + Convert.ToString(n);

}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), j = 1;

Console.WriteLine(ResultNumbers(n));
Numbers(n, j);