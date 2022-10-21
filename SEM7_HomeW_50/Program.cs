// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Convert.ToInt32(new Random().Next(1,21));
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

int[,] mymatrix = new int[n,m];

FillMatrix(mymatrix);
Console.WriteLine();

Console.Write("Введите номер строки для элемента массива: ");
int yourn = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца для элемента массива: ");
int yourm = Convert.ToInt32(Console.ReadLine());

while (yourn <= 0 || yourm <= 0 )
    {Console.WriteLine("Вы неверно ввели одну из позиций. Повторите!"); 
    Console.Write("Введите номер строки для элемента массива: ");
    yourn = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца для элемента массива: ");
    yourm = Convert.ToInt32(Console.ReadLine());
    }

if (yourn <= n && yourm <= m)
    Console.WriteLine(mymatrix[yourn-1, yourm-1]);
else
    Console.WriteLine("Такого элемента нет в данном массиве");
