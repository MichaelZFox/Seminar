// Напишите программу, которая 
// принимает на вход цифру, 
// обозначающую день недели
// и проверяет, является 
// ли этот день выходным


Console.Clear();
int Weekends(int num)
{
    if(num < 6) return 0;
    else return 1;
}

Console.WriteLine("Введити число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
int weekends = Weekends(num);
if(num > 7) Console.WriteLine($"Число {num} больше 7, попробуйте еще раз");
if(num <= 0) Console.WriteLine($"Число {num} меньше или равно 0. Введите число от 1 до 7");
if(weekends == 0) Console.WriteLine("День не является выходным");
else Console.WriteLine("День является выходным");