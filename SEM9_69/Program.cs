// Задача 69. Напишите программу, которая на вход принимает два числа А и В, и
// возводит число А в целую степень В с помощью рекурсии.

int DegreeOfNumber(int a, int b)
{
    if (b == 0)
        return 1; // число в 0-ой степени равно 1
    return DegreeOfNumber(a, b-1) * a;
}

Console.Clear();
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DegreeOfNumber(a, b));