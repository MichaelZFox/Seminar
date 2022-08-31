Console.Clear();


Console.WriteLine("Введите число для возведения в квадрат ");
int num = Convert.ToInt32(Console.ReadLine());

int res = 0;

res = num * num; 

Console.WriteLine($"Квадратный корень числа {num} равен {res}");