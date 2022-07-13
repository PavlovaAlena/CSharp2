//Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Write("Программа показывает третью цифру заданного числа");
Console.WriteLine("");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

//if (num > 99 | (num < 0 && -num > 99))
if (Math.Abs(num) > 99)
{
    int numCalc = Math.Abs(num);
    while (numCalc / 10 > 99)
    {
        numCalc = numCalc / 10;
    }
    Console.WriteLine($"Третья цифра числа {num} это {numCalc % 10}");
}
else
{
    Console.WriteLine($"У числа {num} третьей цифры нет");
}