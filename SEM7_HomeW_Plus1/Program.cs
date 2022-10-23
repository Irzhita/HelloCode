using System.Numerics;
// Состязание - 2
//
// В метании молота состязается n спортсменов. Каждый из них сделал m бросков.
// Победителем соревнований объявляется тот спортсмен, у которого максимален
// наилучший результат по всем броскам. Таким образом, программа должна найти
// значение максимального элемента в данном массиве, а также его индексы (то есть
// номер спортсмена и номер попытки).
// 
// Входные данные
// Программа получает на вход два числа n и m, являющиеся числом строк и столбцов в массиве.
// Далее во входном потоке идет n строк по m чисел, являющихся элементами массива.
//
// Выходные данные
// Программа выводит значение максимального элемента, затем номер строки и номер столбца, в
// котором он встречается. Если в массиве несколько максимальных элементов, то нужно вывести
// минимальный номер строки, в которой встречается такой элемент, а если в этой строке таких 
// элементов несколько, то нужно вывести минимальный номер столбца.

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {    matr[i, j] = new Random().Next(1, 10);
             Console.Write($"{matr[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int[] SearchTheBestResult(int [,] matrix)
{
    int[] maxres = new int[3]{0, 0, 0};
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[i,j] > maxres[0]) 
            {
                maxres[0] = matrix[i, j];
                maxres[1] = i;
                maxres[2] = j;
            }    
    return maxres;
}

Console.Clear();

Console.Write("Введите количество спортсменов n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество бросков m: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] resulttable = new int[n,m];
FillMatrix(resulttable);

int[] winner = new int[3];
winner = SearchTheBestResult(resulttable);

Console.WriteLine($"Результат победителя - {winner[0]}");
Console.WriteLine($"{winner[1]} {winner[2]}");
