Console.Write("Введите номер месяца:");
int numMonth=int.Parse(Console.ReadLine());
if (numMonth == 12 || numMonth == 1 || numMonth == 2)
{
    Console.Write("Введите температуру:");
    int t = int.Parse(Console.ReadLine());
    switch (numMonth)
    {
        case 12: Console.WriteLine("Декабрь"); break;
        case 1: Console.WriteLine("Январь"); break;
        case 2: Console.WriteLine("Февраль"); break;
    }
    if (t > 0)
        Console.WriteLine("Дождливая зима!");
}
else if (numMonth >= 3 && numMonth <= 11)
{
    switch (numMonth)
    {
        case 3: Console.WriteLine("Март"); break;
        case 4: Console.WriteLine("Апрель"); break;
        case 5: Console.WriteLine("Май"); break;
        case 6: Console.WriteLine("Июнь"); break;
        case 7: Console.WriteLine("Июль"); break;
        case 8: Console.WriteLine("Август"); break;
        case 9: Console.WriteLine("Сентябрь"); break;
        case 10: Console.WriteLine("Октябрь"); break;
        case 11: Console.WriteLine("Ноябрь"); break;
    }
}
else 
    Console.WriteLine("Такого месяца нет!");
