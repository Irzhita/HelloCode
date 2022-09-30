// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N. 

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i= (-1) * n; i <= n; i +=1) // i = i +1 <=> i++
    Console.Write(i + " ");

// Решение через while


Console.Write("Введите число: ");

n = Convert.ToInt32(Console.ReadLine());
int j = (-1) * n;

while(j <= n)
{
    Console.Write(j+" ");
    j++; 
}
