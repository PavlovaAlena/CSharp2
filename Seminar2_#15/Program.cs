//Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Write("Программа проверяет цифру на соответствие дня недели выходному дню");
Console.WriteLine("");
Console.Write("Введите цифру дня недели: ");
int digitDay = Convert.ToInt32(Console.ReadLine());

//Первое решение задачи
if (digitDay > 0 && digitDay < 8)
{
    if (digitDay < 6)
    {
        Console.WriteLine($"Цифре {digitDay} не соответствует выходной день, это будний день");
    }
    else
    {
        Console.WriteLine($"Цифре {digitDay} соответствует выходной день");
    }
}
else
{
    Console.WriteLine($"Цифре {digitDay} нет соответствия дня недели");
}

//Второе решение задачи

/* switch (digitDay)
{
    case <= 0:
    case >= 8:
        Console.WriteLine($"Цифре {digitDay} нет соответствия дня недели");    
        break;
    case < 6:
        Console.WriteLine($"Цифре {digitDay} не соответствует выходной день, это будний день");
        break;
    default:
        Console.WriteLine($"Цифре {digitDay} соответствует выходной день");
        break;
} */