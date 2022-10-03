// 

int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 4};

int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (index == find)        
    {{
        Console.WriteLine(index);
        break; //ищется только первый элемент, равный find
    }}
index++;
}
