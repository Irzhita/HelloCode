// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillThreeDimensionalArray(int[,,] cube)
{
    int step = 10;
    for (int i = 0; i < cube.GetLength(0); i++)
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                cube[i, j, k] = step; 
                step++;
                Console.Write($"{cube[i, j, k]} ({i},{j},{k}) \t");
            }
        Console.WriteLine();       
        }    
}

Console.Clear();
Console.Write("Введите количество строк, столбцов и рядов для трехмерного массива: ");  
string[] num = Console.ReadLine().Split(' ');
int x = int.Parse(num[0]);
int y = int.Parse(num[1]);
int z = int.Parse(num[2]);
while (x * y * z > 90) // 90 - количество неповторяющихся двузначных чисел
{
    Console.Write("Слишком большой массив! Необходимо уменьшить количество строк, столбцов или рядов для трехмерного массива: ");  
num = Console.ReadLine().Split(' ');
x = int.Parse(num[0]);
y = int.Parse(num[1]);
z = int.Parse(num[2]);
}

int[,,] cube = new int[x, y, z];
FillThreeDimensionalArray(cube);
Console.WriteLine();
