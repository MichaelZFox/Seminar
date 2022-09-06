Console.Clear();

Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());


int max = numA;
int min = numA;

if( numA > max ) max = numA;
if( numA < max) numA = min;
if(numB > max) max = numB;
if(numB < min) min = numB;

Console.WriteLine($"Минимальное число = {min}. Максимальное число = {max}");