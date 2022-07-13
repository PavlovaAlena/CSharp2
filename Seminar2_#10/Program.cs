// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Программа показывает вторую цифру трёхзначного числа");
Console.WriteLine("");
Console.Write("Введите трехзначное число: ");
int digit3 = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(digit3) > 99 && Math.Abs(digit3) < 1000)
{
    Console.WriteLine($"Вторая цифра числа {digit3} это {Math.Abs(digit3) / 10 % 10}");
}
else
{
    Console.WriteLine($"Число {digit3} не является 3хзначным");
}