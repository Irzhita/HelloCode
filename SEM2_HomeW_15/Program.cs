// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным

Console.Clear();

Console.Write("Введите цифру дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись! Введите снова порядковый номер дня недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}

if (n == 6 || n == 7)
    Console.WriteLine("ура, выходной");
else
    Console.WriteLine("на работу!");