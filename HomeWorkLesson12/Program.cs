﻿Console.Write("Введите первое число:");
int firstNum=int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int secondNum=int.Parse(Console.ReadLine());
Console.Write("Выберете операцию:+,-,*,/");
char operation = Char.Parse(Console.ReadLine());
switch(operation)
{
    case '+':Console.WriteLine($"{firstNum}+{secondNum}={firstNum+secondNum}");break;
    case '-':Console.WriteLine($"{firstNum}-{secondNum}={firstNum - secondNum}"); break;
    case '*':Console.WriteLine($"{firstNum}*{secondNum}={firstNum * secondNum}"); break;
    case '/':Console.WriteLine($"{firstNum}/{secondNum}={firstNum / secondNum}"); break;
}