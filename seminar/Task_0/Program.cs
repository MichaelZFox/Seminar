// Напишите решения 
// Напишите программу,
// 1. которая на вход
// принимает число и 
// 2. выдает его квадрат
// (число умноженное на сабо себя)
// Например: 
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Clear();
Console.Write("Enter integer number ");
int num = Convert.ToInt32(Console.ReadLine());
// int num = 4;
int res = num * num;
Console.WriteLine($"The square of the number {num} = {res}");