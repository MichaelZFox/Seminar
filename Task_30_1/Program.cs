// Задача 30. Напишите программу, 
// которая выводит массив из 8 элементов 
// заполненый 0 и единицами в случайном порядке;

Console.Clear();
void FillArray(int[] collection)  //Заполняем массив рандомными числами
{
    int length = collection.Length;
    int index = 0;
    while(index <  length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
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


int[] array = new int[8];
FillArray(array);
PrintArray(array);