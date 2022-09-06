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

void PrintArray(int[] coll) // Печатаем массив с помощью метода void
{
    int count = coll.Length;
    int position = 0; 
    while(position < count)
    {
      
        Console.Write($" {coll[position]} ");
        position++;
    }
}


int[] array = new int[8];
FillArray(array);
PrintArray(array);