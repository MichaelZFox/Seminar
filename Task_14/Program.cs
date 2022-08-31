// 14. Напишите программу, которая принимает на
// вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int res1 = num % 7;
int res2 = num % 23;

if(res1 == 0 && res2 == 0)
{
Console.WriteLine($"Число {num} кратно числам 7 и 23");
}
else
{
    Console.WriteLine($"Число {num} не кратно числам 7 и 23");
}
