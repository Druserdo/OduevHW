using System.ComponentModel.Design;

Console.Title = "Тема 10";
//Console.Write("Введите первое число:");
//double firstNumber = double.Parse(Console.ReadLine();
//Console.Write("Введите второе число:");
//double secondNumber = double.Parse(Console.ReadLine();
//double resultMax = Math.Max(firstNumber, secondNumber);
//Console.WriteLine(resultMax.ToString();
//double resultABSFitstNumber = Math.Abs(firstNumber);
//Console.WriteLine(resultABSFitstNumber);
//Console.WriteLine(Math.Floor(firstNumber);
//Console.WriteLine(Math.Ceiling(firstNumber);
////1
//Console.WriteLine("Введите х:");
//double x=double.Parse(Console.ReadLine();
//double y = (x >= 0) ? x : -x;
//Console.WriteLine($"|{x}| = {y}");
//2
//Console.WriteLine("Введите х:");
//int x=int.Parse(Console.ReadLine();
//string res = (x % 2 == 0) ? "Четное" : "Нечетное";
//Console.WriteLine(res);
//3
//Console.WriteLine("Введите х:");
//double x=double.Parse(Console.ReadLine();
//string res = (x > 0) ? "Положительное" : (x < 0) ? "Отрицательное" : "0";
//Console.WriteLine(res);
//Console.WriteLine("Введите х:");
//double x = double.Parse(Console.ReadLine();
//Console.WriteLine("Введите y:");
//double y = double.Parse(Console.ReadLine();
//if (x > y)
//    Console.WriteLine(x);
//else if (x < y)
//    Console.WriteLine(y);
//     else Console.WriteLine("=");

//Console.WriteLine("Введите х:");
//double x = double.Parse(Console.ReadLine();
//Console.WriteLine("Введите y:");
//double y = double.Parse(Console.ReadLine();
//Console.WriteLine("Введите z:");
//double z = double.Parse(Console.ReadLine();
//if (x > y && y > z)
//    Console.WriteLine(z);
//else if (y > z && z > x)
//    Console.WriteLine(x);
//else if (z > x && x > y)
//    Console.WriteLine(y);

//Console.WriteLine("Введите Рост:");
//int height = int.Parse(Console.ReadLine();
//Console.WriteLine("Введите Вес:");
//int weight = int.Parse(Console.ReadLine();
//if (height - 100 < weight)
//    Console.WriteLine("Жирная свинья");
//else if (height - 100 > weight)
//    Console.WriteLine("Не достаточный");
//else Console.WriteLine("Нормальный");
//Console.WriteLine("Ввудите номер месяца:");
//byte m=byte.Parse(Console.ReadLine();
//if 
Console.WriteLine("Введите площадь круга");
double s1=double.Parse(Console.ReadLine();
Console.WriteLine("Введите площадь квадрата");
double s2=double.Parse(Console.ReadLine();
double R = Math.Sqrt(s1 / Math.PI);
double a = Math.Sqrt(s2);
if (2 * R <= a)
    Console.WriteLine("Круг входит в квадрат.");
else Console.WriteLine("Круг не входит в квадрат.");
if (2 * R >= a) Console.WriteLine("Квадрат входит в круг.");
else Console.WriteLine("Квадрат не входит в круг.");