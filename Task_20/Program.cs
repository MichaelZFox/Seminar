// Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки ");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки ");
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки ");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки ");
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetDistance(x1, y1, x2, y2));

double GetDistance( int xa, int ya, int xb, int yb) //metod
{
    return Math.Round(Math.Sqrt(((xb - xa) * (xb - xa)) + ((yb - ya) * (yb - ya))), 2, MidpointRounding.ToZero);
}
