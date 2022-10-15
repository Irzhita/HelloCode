// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble()*100, 2);
}

double SearchMaximum(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > max) max = array[i];
    Console.WriteLine($"max = {max}");
    return max; 
}

double SearchMinimum(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < min) min = array[i];
    Console.WriteLine($"min = {min}");
    return min; 
}

Console.Clear();

Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());

// double[] array = new double[n];
// Console.Write("Введите элементы массива, вещественные числа: ");
// for (int i = 0; i < array.Length; i++)
//    array[i] = Convert.ToDouble(Console.ReadLine());

double[] array = new double[n];
FillArray(array);

Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine($"max - min = {Math.Round((SearchMaximum(array) - SearchMinimum(array)),2) }");