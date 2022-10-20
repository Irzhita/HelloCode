// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем


Console.Clear();

Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (b1 == b2 && k1 == k2) 
    Console.WriteLine("Это одна и та же прямая, прямые совпадают");
else
    if (k1 == k2)
        Console.WriteLine("Это параллельные прямые, нет пересечения");
    else
    {
        double x = ((b2 - b1)/(k1 - k2));
        double y = k1 * x + b1;
        Console.Write($"Точка пересечения прямых  y = {k1} * x + {b1}  и  y = {k2} * x + {b2} : ({Math.Round(x, 2)}; {Math.Round(y, 2)})");
    }

Console.WriteLine();