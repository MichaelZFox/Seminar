Console.Clear();


Console.Write("Enter first integer number ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second integer number ");
int numB = Convert.ToInt32(Console.ReadLine());

int max = numA;
int min = numB;

if(numA > max)
{ max = numA;
  min = numB;
}
if(numB > max) 
{
    max = numB;
    min = numA;
}

if(min * min == max)
{
    Console.WriteLine($"Число {min} является квадратом числа {max}");
}

if(min * min != max)
{
    Console.WriteLine($"Число{min} не является квадратом числа {max}");
}