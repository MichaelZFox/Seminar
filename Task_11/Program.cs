// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72

int num = new Random().Next(100, 1000);

int result = RemoveSecond(num);
Console.WriteLine($"{num} -> {result}");

int RemoveSecond(int num)
{
    int first = num / 100;
    int thrid = num % 10;
    return first * 10 + thrid;
}