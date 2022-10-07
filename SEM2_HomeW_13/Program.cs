// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет

Console.Clear();

Console.Write("Введите любое число: ");  
int n = Convert.ToInt32(Console.ReadLine());

if (n > -100 && n < 100)
    Console.WriteLine("третьей цифры нет");
else
{
    int copyn = n;
    n = n / 100;
    int count = 2;  // количество разрядов в числе n

    while (n > 0)
    {
        n = n / 10;
        count++;
    }
    n = 1;
    for (int i=1; i < count-2; i++) n = n*10;
    Console.Write("третья цифра : ");
    Console.WriteLine(copyn / n % 10);
}
