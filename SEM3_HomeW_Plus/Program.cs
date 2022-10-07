// Сбор черники https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=113&id_problem=695

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

Console.Clear();
int n = new Random().Next(3,11);
Console.Write($"Количество кустов черники: {n} с урожайностью ");
// Тестим пока для 10 кустов

int[] array = new int[n]; 

FillArray(array);
PrintArray(array);

int max = array[0]+array[1]+array[n-1];

for (int i = 2; i <= n-1; i++)
{
    int sum3 = array[i-2] + array[i-1] + array[i];
    if (max < sum3) max = sum3;
}

Console.WriteLine();
Console.WriteLine($"Максимальный сбор - {max}");