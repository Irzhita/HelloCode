//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");        
        }    
        Console.WriteLine();
    }    
}

void MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] multimatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    Console.WriteLine("Произведение матриц: ");
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {    
            multimatrix[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
                multimatrix[i, j] = multimatrix[i, j] + matrix1[i,k] * matrix2[k,j]; 
            Console.Write($"{multimatrix[i, j]} \t");     
        }
    Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите количество строк и столбцов для первой матрицы: ");
string[] num1 = Console.ReadLine().Split(' ');
int n1 = int.Parse(num1[0]);
int m1 = int.Parse(num1[1]);
int[,] matrix1 = new int[n1, m1];
FillMatrix(matrix1);
Console.WriteLine();

// Console.Write("Введите размеры n2 и m2 для второй матрицы (m2 должно равняться n1): ");
// string[] num2 = Console.ReadLine().Split(' ');
// int n2 = int.Parse(num2[0]);
// int m2 = int.Parse(num2[1]);
// while (m2 != n1)
// {
//    Console.Write("Введите правильное значение m2: ");
//    m2 = Convert.ToInt32(Console.ReadLine()); 
// }

Console.Write("Введите количество строк для второй матрицы: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix2 = new int[n2, n1];
FillMatrix(matrix2);
Console.WriteLine();

MatrixMultiplication(matrix1, matrix2);