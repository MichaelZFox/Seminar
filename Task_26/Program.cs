// Задача 26. Напишите программу, 
// которая принимает на вход число 
// и выдает колличество цифр в числе
// 456 -> 3;
// 78 -> 2;
// 89126 -> 5;

Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int GetDigitCount(int num)
{
    int res = 0;
    while (num >= 1)
    {
        num = num / 10;
        res++;
    }
    return res;
}
int result = GetDigitCount(number);
Console.WriteLine($"Количество цифр в числе {number} равняется {result}");

