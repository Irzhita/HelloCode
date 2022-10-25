// Миша и негатив
//
// Входные данные
// Первая строка входного файла INPUT.TXT содержит целые числа n и m (1 ≤ n, m ≤ 100) – высоту и ширину
// исходного изображения (в пикселях). Последующие n строк содержат описание исходного изображения. 
// Каждая строка состоит из m символов «B» и «W». Символ «B»  соответствует черному пикселю, а символ «W» -
// белому. Далее следует пустая строка, а после нее – описание выведенного Мишиной программой изображения 
// в том же формате, что и исходное изображение.
//
// Выходные данные
// В выходной файл OUTPUT.TXT необходимо вывести число пикселей негатива, которые неправильно сформированы Мишиной программой.

char[,] FillMatrixByChars(char[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {    int k = new Random().Next(0, 10);
            if (k <= 5) matrix[i, j] = 'B';
            else matrix[i, j] = 'W';
            Console.Write($"{matrix[i, j]}");
        }    
        Console.WriteLine(); 
    }    
    return matrix;
}

Console.Clear();

Console.Write("Введите высоту изображения n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите ширину изображения m: ");
int m = Convert.ToInt32(Console.ReadLine());

char[,] basepicture = new char[n, m];
char[,] mishaspicture = new char[n, m];

Console.Write("Исходное изображениe: ");
Console.WriteLine();
basepicture = FillMatrixByChars(basepicture);

Console.Write("Изображение Миши: ");
Console.WriteLine();
mishaspicture = FillMatrixByChars(mishaspicture);

int count = 0;

for (int i = 0; i < basepicture.GetLength(0); i++)
{
    for (int j = 0; j < basepicture.GetLength(1); j++)
        if (basepicture[i, j] == mishaspicture[i, j]) count++;
}        
Console.WriteLine($"Ошибок - {count}");


