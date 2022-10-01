//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n>1)
{
    for (int i = 2; i<=n; i+=2)
    Console.Write(i + ", ");
}
else
    Console.Write("Введенное число меньше или равно 1");