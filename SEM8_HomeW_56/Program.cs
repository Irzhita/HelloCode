// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 21);
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}

void FindPlaceOfMinimum(int[] array)
{
    int min = array[0];
    int num = 0;
    for (int i = 1; i < array.Length; i++)
        if (min > array[i]) 
        {
            min = array[i];
            num = i;
        }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {num+1} ");
}

Console.Clear();

Console.Write("Введите количество строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
FillMatrix(matrix); 
Console.WriteLine();

int[] sums = new int[matrix.GetLength(0)]; 
Console.Write($"Суммы строк: ");
{
    for (int i = 0; i < matrix.GetLength(0); i++ )
    {
        int sum = 0;
        {
        for (int j = 0; j < matrix.GetLength(1); j++)
            sum = sum + matrix[i, j];
            sums[i] = sum;
            Console.Write($"{sums[i]} ");
        }
    }
}
Console.WriteLine();
FindPlaceOfMinimum(sums);