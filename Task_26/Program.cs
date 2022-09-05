Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int FindCountDigit(int num)
{
    int index = 1;
    int res = 0;
    while (index <= num)
    {
        res = res + 1;
        index = index * 10;
    }
    return res;
}

int result = FindCountDigit(number);
Console.WriteLine(result);
