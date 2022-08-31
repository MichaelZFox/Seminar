// 14. Напишите программу, которая принимает на
// вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Clear();
int Multiplicity(int number)
{

    int res1 = number % 7;
    int res2 = number % 23;

    if (res1 == 0 && res2 == 0 && number != 0)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int multiplicity = Multiplicity(num);
if (multiplicity == 1) Console.WriteLine($"Число {num} кратно числам 7 и 23");
else Console.WriteLine($"Число {num} не кратно числам 7 и 23");