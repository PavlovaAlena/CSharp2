Console.Write("Введите число дня недели: ");
int dn = Convert.ToInt32(Console.ReadLine());

if (dn >0 && dn < 8)
{
    if (dn < 6)
    {
        Console.WriteLine($"Числу {dn} соответствует будний день");
    }
    else
    {
        Console.WriteLine($"Числу {dn} соответствует выходной день");
    }
}
else
{
    Console.WriteLine($"Числу {dn} нет соответствия дня недели");
}