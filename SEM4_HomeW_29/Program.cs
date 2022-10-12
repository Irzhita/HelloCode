// Напишите программу, которая задаёт массив из 8 элементов (вводит пользователь) и выводит их на экран.

Console.Clear();
int[] array = new int[8]; 
Console.WriteLine("Введите элементы массива: ");
for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine($"[{string.Join(", ", array)}]");