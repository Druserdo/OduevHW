Random random = new Random();
int num1=random.Next(0, 6);
Console.WriteLine("Введите число от 0 до 5:");
int numUser=int.Parse(Console.ReadLine());
if (numUser == num1)
{
    Console.WriteLine(num1);
    Console.WriteLine("Победа!");
}
else
{
    Console.WriteLine(num1);
    Console.WriteLine("Попробуйте снова(");
}
