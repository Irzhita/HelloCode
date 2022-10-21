//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void InputMatrix(double[,] matrix)
 {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {         
        for (int j = 0; j < matrix.GetLength(1); j++)         
        {             
            matrix[i, j] = Math.Round(new Random().NextDouble()*100,2);             
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

double[,] myarray = new double[n, m];

InputMatrix(myarray);
