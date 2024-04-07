Console.Write("Введите первое число:");
int num1=int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int num2=int.Parse(Console.ReadLine());
int addNumbers(int a, int b)
{
    int summ=a+b;
    return summ;
}
Console.WriteLine($"Сумма чисел равна:{addNumbers(num1, num2)}");