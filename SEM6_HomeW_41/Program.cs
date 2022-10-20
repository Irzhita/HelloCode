// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

int count = 0;
Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите последовательность чисел: ");

for (int i = 1; i <= m; i++)

    if (Convert.ToInt32(Console.ReadLine()) > 0) count = count +1;

Console.WriteLine($"Количество чисел больше 0: {count}");