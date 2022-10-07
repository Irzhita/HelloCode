// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n>99999 || n<10000)
{
    Console.Write("Введите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}    

if ((n/10000 == n%10) && (n/1000 % 10 == n/10 % 10))
    Console.WriteLine("Это число палиндром");
else 
    Console.WriteLine("Это число не палиндром");
