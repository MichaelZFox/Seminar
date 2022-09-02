// Напишите программу, которая принимает на вход координаты точки (X и Y) 
// Причем точки (x, y) != 0. И выдвет номер четверти плоскости, 
// в которой находится эта точка. 

Console.Clear();

Console.WriteLine("Введите координаты точки ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y");
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc, int yc)
{
if (x > 0 && y > 0) return "Первая четверть";
if (x < 0 && y > 0) return "Вторая четверть";
if (x < 0 && y < 0) return "Третья четверть";
if (x > 0 && y < 0) return "Четвертая четверть";
return "Введены некорректные данные";
}
string res = Quarter(x, y);
Console.WriteLine(res);