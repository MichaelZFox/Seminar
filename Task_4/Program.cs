// Напишите программу, которая на вход принимает 
// трехзначное число и на выходе 
// показывает последнюю цифру
// этого числа
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();

Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine()); 

if(num > 99)
{
    int lastDigit = num % 10;
Console.WriteLine($"Последняя цифра числа {num} равна {lastDigit}");
}

if(num < 99)
    {
    Console.Write("Число не является трехзначным");
    }