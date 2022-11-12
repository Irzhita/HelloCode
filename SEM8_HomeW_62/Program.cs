// Напишите программу, которая заполнит спирально массив 4 на 4.

void FillMatrixInSpiral(int[,] matrix) // Работает только для матриц с одинаковым количеством строк и столбцов
{
    int a = 1, i = 0, j = 0;
    while (a <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = a;
        a++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;    
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else 
            i--;    
    }  
    for (i = 0; i < matrix.GetLength(0); i++)  
    {
        for (j = 0; j < matrix.GetLength(1); j++)  
           Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine(); 
    }
}

Console.Clear();

Console.Write("Введите размер квадратной матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
FillMatrixInSpiral(matrix); 