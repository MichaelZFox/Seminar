// Напишите программу, 
// которая принимает на вход число N 
// и выдает произведение чисел от 1 до N.

Console.WriteLine("Введите число");
double number = Convert.ToInt32(Console.ReadLine());

double GetDigit(double num)
{
    double count = 1;
    for (double i = 1; i <= num; i++)
    {
        count = count * i;
    }
    
    return count;
}

double result = GetDigit(number);
Console.WriteLine(result);