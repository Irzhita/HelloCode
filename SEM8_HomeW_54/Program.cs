//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.


void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,21);
            Console.Write($"{matrix[i, j]} \t");        
        }
    Console.WriteLine();
    }
}

void SortingOnMax(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition])
                maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

void SortingRowsInDescendingOrder(int[,] matrix)
{
    int[] row = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           row[j] = matrix [i, j];
        }
    SortingOnMax(row);
    for (int k = 0; k < row.Length; k++)
        Console.Write($"{row[k]} \t");
        Console.WriteLine();
    }
    
}

Console.Clear();

Console.WriteLine("Введите количество строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
Console.WriteLine();

int[,] matrix = new int[n, m];
FillMatrix(matrix);
Console.WriteLine();
SortingRowsInDescendingOrder(matrix);