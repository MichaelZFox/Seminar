// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y)


Console.Clear();
Console.WriteLine("Введите номер четверти");
string num = (Console.ReadLine());

string Quarter(string number)
{
    if (number == "1") return "х - больше 0, у - больше 0";
    if (number == "2") return "x - меньше 0, у - больше 0";
    if (number == "3") return "x - меньше 0, y - меньше 0";
    if (number == "4") return "x - больше 0, у - меньше 0";
    return "Введены некоректные данные";
}

string result = Quarter(num);
Console.WriteLine(result);