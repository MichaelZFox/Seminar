// Напишите программу, которая принимает на вход координаты точки (X и Y) 
// Причем точки (x, y) != 0. И выдвет номер четверти плоскости, 
// в которой находится эта точка. 


Console.WriteLine("Введите параметры координт точки ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите параметры координт точки ");
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());


if (x > 0 && y > 0)
{
    Console.WriteLine("Первая четверть ");
}

else if (x < 0 && y > 0)
{
    Console.WriteLine("Вторая четверть ");
}

else if (x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть ");
}

else if (x > 0 && y < 0)
{
    Console.WriteLine("Первая четверть ");
}

else Console.WriteLine("Введенны не корректные данные");