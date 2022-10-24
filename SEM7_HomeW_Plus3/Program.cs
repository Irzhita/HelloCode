// Заполнение змейкой
//
// Даны числа n и m. Создайте массив A [n] [m] и заполните его змейкой (см. пример).
// 
// Выходные данные
// Программа должна вывести полученный массив, отводя на вывод каждого числа ровно 3 символа.

void FillMatrix(string[,] matr)
{
    string element = "  0";
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = element;
            count++;
            if (count < 10)
                element = "  " + Convert.ToString(count);
            else
                element = " " + Convert.ToString(count);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Введите количество строк массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива m: ");
int m = Convert.ToInt32(Console.ReadLine());

string[,] mymatrix = new string[n, m];
FillMatrix(mymatrix);