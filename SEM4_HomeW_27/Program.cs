// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (n > 0)
{    
    sum = sum + n % 10;
    n = n/10;
}    

Console.WriteLine(sum);