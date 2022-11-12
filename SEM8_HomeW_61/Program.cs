// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int factorial(int n)
{
    int x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

void PythagorasTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= (n - i); j++) // делаем отступы справа
            Console.Write("   "); 
        for (int j = 0; j <= i; j++)
            Console.Write($"    {factorial(i) / (factorial(j) * factorial(i - j))}"); //формула вычисления элементов треугольника
        Console.WriteLine();
        Console.WriteLine(); 
    }
}

Console.Clear();

Console.Write("Введите количество строк треугольника Пифагора: ");
int n = Convert.ToInt32(Console.ReadLine());

PythagorasTriangle(n);