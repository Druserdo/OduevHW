﻿Console.Write("Введите число 1:");
int num1=int.Parse(Console.ReadLine());
Console.Write("Введите число 2:");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3:");
int num3 = int.Parse(Console.ReadLine());
Console.Write("Введите число 4:");
int num4 = int.Parse(Console.ReadLine());
Console.Write("Введите число 5:");
int num5 = int.Parse(Console.ReadLine());
Console.Write("Введите число 6:");
int num6 = int.Parse(Console.ReadLine());
Console.Write("Введите число 7:");
int num7 = int.Parse(Console.ReadLine());
Console.Write("Введите число 8:");
int num8 = int.Parse(Console.ReadLine());
Console.Write("Введите число 9:");
int num9 = int.Parse(Console.ReadLine());
Console.Write("Введите число 10:");
int num10 = int.Parse(Console.ReadLine());
int big = 0;
int small = 0;
int sum= num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
Console.WriteLine($"Сумма всех чисел равна:{sum}");
int max1 = Math.Max(num1, num2);
int max2 = Math.Max(max1, num3);
int max3 = Math.Max(max2, num4);
int max4 = Math.Max(max3, num5);
int max5 = Math.Max(max4, num6);
int max6 = Math.Max(max5, num7);
int max7 = Math.Max(max6, num8);
int max8 = Math.Max(max7, num9);
int max9=Math.Max(max8, num10);
Console.WriteLine($"Максимальное число {max9}");
int min1 = Math.Min(num1, num2);
int min2 = Math.Min(min1, num3);
int min3 = Math.Min(min2, num4);
int min4 = Math.Min(min3, num5);
int min5 = Math.Min(min4, num6);
int min6 = Math.Min(min5, num7);
int min7 = Math.Min(min6, num8);
int min8 = Math.Min(min7, num9);
int min9 = Math.Min(min8, num10);
Console.WriteLine($"Мнимальное число {min9}");

if (num1 > 10)
    big++;
if (num2 > 10) 
    big++;
if (num3 > 10) 
    big++;
if (num4 > 10)
    big++;
if (num5 > 10) 
    big++;
if (num6 > 10) 
    big++;
if (num7 > 10) 
    big++;
if (num8 > 10) 
    big++;
if (num9 > 10) 
    big++;
if (num10 > 10) 
    big++;
Console.WriteLine($"{big} чисел больше 10.");
if (num1 < -10)
    small++;
if (num2 < -10) 
    small++;
if (num3 < -10) 
    small++;
if (num4 < -10) 
    small++;
if (num5 < -10) 
    small++;
if (num6 < -10) 
    small++;
if (num7 < -10) 
    small++;
if (num8 < -10) 
    small++;
if (num9 < -10) 
    small++;
if (num10 < -10) 
    small++;
Console.WriteLine($"{small} чисел меньше -10.");
Console.WriteLine($"Среднее арифметическое {sum/10}");
