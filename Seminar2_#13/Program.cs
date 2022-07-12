Console.Write("Введите число: ");
int d1 = Convert.ToInt32(Console.ReadLine());

if (d1 > 99)
{
    int d2 = d1;
    while (d2 / 10 > 99)
    {
        d2 = d2/10;
    }
    Console.WriteLine($"Третья цифра числа {d1} это {d2 % 10}");
}
else
{
    Console.WriteLine($"У числа {d1} третьей цифры нет");
}