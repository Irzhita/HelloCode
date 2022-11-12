// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа n и m.

int AccermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
        if (n == 0)
            return AccermanFunction(m - 1, 1);
        else
            return AccermanFunction(m - 1, AccermanFunction(m, n-1));
}

Console.Clear();

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
while (m < 0)
{
    Console.Write("Число должно быть неотрицательным: ");
    m = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 0)
{
    Console.Write("Введите неотрицательное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine(AccermanFunction(m, n));
