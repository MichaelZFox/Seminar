Console.Clear();

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());

int i = 0;

if(num > 0)
{
i = num;
num = num * -1;
}
else
{
    i = -num;
}

while (i<=num)
{
    Console.Write($"{i}");
    i++;
}