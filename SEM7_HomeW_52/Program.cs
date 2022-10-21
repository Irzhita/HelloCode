// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i,j] = new Random().Next(1, 21);
           Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();    
    }
}

Console.Clear();

Console.Write("Введите количество строк массива: "); 
int n = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите количество столбцов массива: "); 
int m = Convert.ToInt32(Console.ReadLine()); 

int[,] mymatrix = new int[n, m];
FillMatrix(mymatrix);

Console.WriteLine();
Console.WriteLine("Среднее арифметическое по столбцам: ");

double[] arithmean = new double[m];


for (int j = 0; j < mymatrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < mymatrix.GetLength(0); i++)
    {
        sum = sum + mymatrix[i, j];
    }
arithmean[j] = Math.Round(sum/n,2);
Console.Write($"{string.Join(" ", arithmean[j])} \t");
}

Console.WriteLine();
