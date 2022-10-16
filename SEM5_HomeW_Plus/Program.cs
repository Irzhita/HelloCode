using System.ComponentModel;
using System;
// Дана последовательность из N целых чисел и число K. 
// Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов 
// вправо, если K – положительное и влево, если отрицательное.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void CyclicArrayShiftToLeft(int[] array, int k)
{
    int[] array1 = new int[array.Length];
    for (int i = 0; i < k; i++)
        array1[array.Length - k + i] = array[i];
    for (int i = 0; i < array.Length - k; i++) 
        array1[i] = array[i + k];
    Console.WriteLine($"[{string.Join(" ", array1)}]");
}

void CyclicArrayShiftToRight(int[] array, int k)
{
    int[] array1 = new int[array.Length];
    for (int i = 0; i < k; i++)
        array1[i] = array[array.Length - k + i];
    for (int i = k; i < array.Length; i++) 
        array1[i] = array[i - k];
    Console.WriteLine($"[{string.Join(" ", array1)}]");
}


Console.Clear();

Console.Write("Введите длину массива N (1 <= N <= 100000): ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 1 || n > 100001) 
{     Console.Write("Вы ошиблись! Введите число N в нужном диапазоне: ");
      n = Convert.ToInt32(Console.ReadLine());  
}

int[] array = new int[n];
FillArray(array);
Console.WriteLine($"[{string.Join(" ", array)}]");

Console.Write("Введите число K (-N <= K <= N): ");
int k = Convert.ToInt32(Console.ReadLine());

while (k < n*(-1) || k > n) 
{     
    Console.Write("Вы ошиблись! Введите число K в нужном диапазоне: ");
    k = Convert.ToInt32(Console.ReadLine());  
}

if (k > 0) 
    CyclicArrayShiftToRight(array, k);
else
{
    k = k*(-1);
    CyclicArrayShiftToLeft(array, k);
}       





