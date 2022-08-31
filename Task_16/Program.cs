// 16. Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число");
int num2 = Convert.ToInt32(Console.ReadLine());

int min = num1;
int max = num1;
if( num1 > max ) max = num1;
if( num1 < max) min = num1;
if( num2 > max ) max = num2;
if( num2 < max) min = num2;

int res = max / min;
if(res == min) Console.WriteLine($"Число {max} являтеся квадратом {min}");
else Console.WriteLine($"Число {max} не являтеся квадратом {min}");