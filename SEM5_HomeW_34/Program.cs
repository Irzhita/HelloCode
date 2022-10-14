// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); 
}

void EvenNumbers(int[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) n = n +1;
    Console.WriteLine($"Четных чисел - {n}");
}

Console.Clear();

Console.Write("Задайте размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
FillArray(array);
Console.WriteLine($"[{string.Join(",",array)}]");

EvenNumbers(array);