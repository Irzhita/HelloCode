// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

Console.WriteLine("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

double result = 1;

for (int i = 1; i <= b; i++)
    result = result*a;
    
Console.WriteLine($"a ** b = {result}");
