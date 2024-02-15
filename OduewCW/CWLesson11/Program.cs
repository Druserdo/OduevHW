//Console.Write("Введите a:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите b:");
//double b = double.Parse(Console.ReadLine()); 
//Console.Write("Введите c:");
//double c = double.Parse(Console.ReadLine());
//double D = b * b - 4 * a * c;
//if (D > 0)
//{
//    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
//    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
//    Console.WriteLine($"x1={x1:F2} x2={x2:F2}");
//}
//else if (D == 0)
//{
//    double x = -b / (2 * a);
//    Console.WriteLine($"x={x:F2}");
//}
//else Console.WriteLine("Корней нет");
//// задача 1 
//Console.Write("Введите год рождения");
//int age = int.Parse(Console.ReadLine());
//if (age % 4 == 0) 
//    Console.WriteLine("Високосный");
//else Console.WriteLine("Не високосный");
//Console.Write("Введите число");
//double x = double.Parse(Console.ReadLine());
//if (x >= 10 && x < 100)
//    Console.WriteLine("Лежит");
//else Console.WriteLine("Не лежит");

//Random random= new Random();
//int x= random.Next(1,11);
//Console.Write("Введите число от 1 до 10:");
//int num=int.Parse(Console.ReadLine());
//if (x == num)
//    Console.WriteLine("Угадал");
//else if (num < x)
//    Console.WriteLine("Меньше");
//else Console.WriteLine("Больше");
//Random random = new Random();
//double x=random.NextDouble()*10;
//Console.WriteLine($"{x:F2}");

//const string LOGIN1 = "administrator";
//const string LOGIN2 = "администратор";
//const int PASS1 = 2807988;
//const string LOGIN3 = "Богдан";
//const int PASS3 = 27111095;
//const string LOGIN4 = "Дмитрий";
//const int PASS4 = 12021917;
//Console.Write("Введите логин");
//string login = Console.ReadLine();
//if (login == LOGIN1 || login == LOGIN2)
//{
//    Console.Write("Введите пароль:");
//    int pass = int.Parse(Console.ReadLine());
//    if (pass == PASS1)
//        Console.WriteLine("Пароль верен. Добро пожаловать");
//    else Console.WriteLine("Пароль не верный");
//}
//else if (login == LOGIN3)
//{
//    Console.Write("Введите пароль:");
//    int pass = int.Parse(Console.ReadLine());
//    if (pass == PASS3)
//        Console.WriteLine("Пароль верен. Добро пожаловать");
//    else Console.WriteLine("Пароль не верный");
//}
//else if (login == LOGIN4)
//{
//    Console.Write("Введите пароль:");
//    int pass = int.Parse(Console.ReadLine());
//    if (pass == PASS4)
//        Console.WriteLine("Пароль верен. Добро пожаловать");
//    else Console.WriteLine("Пароль не верный");
//}
//else Console.WriteLine("Такого логина нет");
//Console.ForegroundColor=ConsoleColor.Red;
//Console.WriteLine("dddd");
//Console.ForegroundColor=ConsoleColor.Green;


//Random random = new Random();
//int intColor = random.Next(3);
//string Color;
//if (intColor == 0) Color = "Красный";
//else if (intColor == 1) Color = "Зеленый";
//else Color = "Синий";
//Console.WriteLine("Введите цвет");
//string userColor=Console.ReadLine();
//if (userColor == Color) Console.WriteLine("Победа");
//else
//{
//    if (userColor == "Красный") Console.WriteLine("Раньше");
//    else if (userColor == "Зеленый")
//    {
//        if (Color == "Красный") Console.WriteLine("Позже");

//        else Console.WriteLine("Раньше");
//    }
//    else Console.WriteLine("Позже");
//}
//Random random = new Random();
//int year = random.Next(1900,2024);
//Console.WriteLine(year);
//string result = (year % 4 == 0) ? "Да" : "Нет";
//Console.Write("Введите Да/Нет");
//string answer = Console.ReadLine();
//if (answer == result)
//    Console.WriteLine("угадал");
//else
//{
//    if (result=="Да") Console.WriteLine("Високосный");
//    else Console.WriteLine("Не високосный");
//}
//Random random = new Random();
//int dayWeek = random.Next(1, 8);
//string day;
//if (dayWeek == 1) day = "Понедельник";
//else if (dayWeek == 2) day = "Вторник";
//     else if (dayWeek == 3) day = "Среда";
//          else if (dayWeek == 4) day = "Четверг";
//               else if (dayWeek == 5) day = "Пятница";
//                    else if (dayWeek == 6) day = "Суббота";
//                         else day = "Воскресенье";
//Console.Write("Ведите день недели");
//string userDay=Console.ReadLine();
//if (userDay == day)
//    Console.WriteLine("Верно!");
//else Console.WriteLine(day);
Console.Write("Введите число от 1 до 365: ");
int k=int.Parse(Console.ReadLine());
Console.WriteLine("Введите день недели первого января:");
int d=int.Parse(Console.ReadLine());
int dayWeek = k % 7 + d-1;
if (dayWeek == 1)Console.WriteLine( "Понедельник");
else if (dayWeek == 2)Console.WriteLine( "Вторник");
else if (dayWeek == 3)Console.WriteLine( "Среда");
else if (dayWeek == 4)Console.WriteLine( "Четверг");
else if (dayWeek == 5)Console.WriteLine( "Пятница");
else if (dayWeek == 6)Console.WriteLine( "Суббота");
else Console.WriteLine( "Воскресенье");