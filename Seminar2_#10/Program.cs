Console.Write("Введите трехзначное число: ");
int d1 = Convert.ToInt32(Console.ReadLine());

if (d1 > 99 && d1 < 1000)
{
    Console.WriteLine($"Вторая цифра числа {d1} это {d1 / 10 % 10}");
}
else
{
    Console.WriteLine($"Число {d1} не является 3хзначным");
}