//1 задача 
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());
int divisioRresult = number % 8;
Console.WriteLine(divisioRresult);
//2 задача 
Console.Write($"\n\nВведите первое число:");
int firstNumber=int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("Введите третье число:");
int thirdNumber=int.Parse(Console.ReadLine());
int summ=firstNumber+secondNumber+thirdNumber;
Console.WriteLine($"Сумма чисел {summ}.");
int multiplication=firstNumber*secondNumber*thirdNumber;
Console.WriteLine($"Произведение чисел {multiplication}.");