//Console.WriteLine(ToRussia(PrintMassage()));
//string ToRussia(DayTime dayTime)
//{
//    switch(dayTime)
//    {
//        case DayTime.Morning: return "Доброе утро!!";
//        case DayTime.Afternoon: return "Добрый день!!";
//        case DayTime.Evening: return "Добрый вечер!!";
//    }
//    return "Доброй ночи!!";
//}
//DayTime PrintMassage()
//{
//    int hour = DateTime.Now.Hour;
//    DayTime dayTime;
//    if (hour > 5 && hour < 12) dayTime = DayTime.Morning;
//    else if (hour > 12 && hour < 17) dayTime = DayTime.Afternoon;
//    else if (hour > 17 && hour < 24) dayTime = DayTime.Evening;
//    else dayTime = DayTime.Night;
//    return dayTime;
//}
//enum DayTime
//{
//    Morning,
//    Afternoon,
//    Evening,
//    Night
//}

//    Console.Write("Введите первое число:");
//    double a = double.Parse(Console.ReadLine()!);
//    Console.Write("Введите второе число:");
//    double b = double.Parse(Console.ReadLine());
//    DoOperation(a, b, Operation.Add);
//    DoOperation(b, a, Operation.Subtract);
//    DoOperation(b, a, Operation.Multiply);
//    DoOperation(b, a, Operation.Divide);

//void DoOperation(double x, double y,Operation op)
//{
//    double result = op switch
//    {
//        Operation.Add => x + y,
//        Operation.Subtract => x - y,
//        Operation.Multiply => x * y,
//        Operation.Divide => x / y
//    };
//    Console.WriteLine(result);
//}

//enum Operation
//{
//    Add,
//    Subtract,
//    Multiply,
//    Divide
//}
string moon = "Moon";
if(!Enum.IsDefined(typeof(DistanceSun), moon))
{
    Console.WriteLine("Ne planeta");
}
foreach(DistanceSun item in Enum.GetValues(typeof(DistanceSun)))
{
    Console.WriteLine(item+" ");
}
enum DistanceSun: ulong
{
    Sun=0,
    Mercury=5790000,
    Venus=108200000,
    Earth=149600000,
    Mars=227900000,
    Jupiter=708300000,
    Saturn=142700000,
    Uranus=2870000000,
    Neptune=4496000000,
    Pluto=5946000000
}