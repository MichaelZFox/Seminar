// Задача 39.Напишите программу, 
// которая перевернет одномерный массив 
// (последний элемент будет на первом месте,
// а первый на последнем и т.д.)
// [1,2,3,4,5] -> [5,4,3,2,1]
// [6,7,3,6]->[6,7,3,6]

Console.Clear();

void ReverseArray (int[] arr)
{
    int size = arr.Length;
    int index1 = 0;
    int index2 = size -1;

    while (index1 < index2)
    {
        int obj = arr[index1];
        arr[index1] = arr[index2];
        arr[index2] = obj;

        index1++;
        index2--;
    }
    
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}



void PrintArray(int[] arr) // Печатаем массив с помощью метода void
{
    int count = arr.Length;
    Console.Write("["); 
    
    for(int position = 0; position < count; position++)
    {
        Console.Write(arr[position]);
        if(position != arr.Length -1) Console.Write(",");
    }
    Console.WriteLine("]");
}

int[] array = CreateArrayRndInt(9, 1, 100);
PrintArray(array);
ReverseArray(array);
Console.WriteLine();
PrintArray(array);