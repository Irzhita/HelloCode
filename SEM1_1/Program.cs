// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя). 
Console.Write("Введите первое число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int x2 = Convert.ToInt32(Console.ReadLine());

if(x2 == x1 * x1)
    Console.WriteLine("Второе число является квадратом первого");
else
    Console.WriteLine("Второе число не является квадратом первого");