// Состязание - 4
//
// В метании молота состязается n спортсменов. Каждый из них сделал m бросков.
// Победитель определяется по лучшему результату. Определите количество
// участников состязаний, которые разделили первое место, то есть определите количество
// строк в массиве, которые содержат значение, равное наибольшему.
// 
// Входные данные
// Программа получает на вход два числа n и m, являющиеся числом строк и столбцов в массиве.
// Далее во входном потоке идет n строк по m чисел, являющихся элементами массива.
//
// Выходные данные
// Программа должна вывести одно число - количество победителей соревнования.

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(1, 10);
                Console.Write($"{matrix[i, j]} \t");
            }
        Console.WriteLine();     
    }    
}

int SearchWinnerResult(int[,] matr)
{
    int max = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            if (matr[i, j] > max) max = matr[i, j];
    return max;
}

Console.Clear();

Console.Write("Введите количество спортсменов n: "); 
int n = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите количество бросков m: "); 
int m = Convert.ToInt32(Console.ReadLine()); 

int[,] resulttable = new int[n, m];

FillMatrix(resulttable);

Console.WriteLine();

int count = 0;

for (int i = 0; i < resulttable.GetLength(0); i++)
    for (int j = 0; j < resulttable.GetLength(1); j++)
        if (resulttable[i, j] == SearchWinnerResult(resulttable)) count++;

Console.WriteLine($"Результат первого места - {SearchWinnerResult(resulttable)}, количество победителей - {count}");