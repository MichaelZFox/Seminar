Console.Clear();
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(0, 1);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < 0)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];
FillArray(array);
array[4] = 0;
array[6] = 1;
PrintArray(array);
Console.WriteLine();