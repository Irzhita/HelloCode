// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11);
}

void SumOddPositions(int[] array)
{
    int sum = 0; 
    for (int i = 1; i < array.Length; i+=2)
        sum = sum + array[i];
    Console.WriteLine($"Сумма элементов на нечетных позициях в массиве равна {sum}");
}

Console.Clear();

Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");

SumOddPositions(array);