//int a = 249;
//int b = 8;
//string result = Convert.ToString(a ^ b, 2);
//Console.WriteLine(result);


//3.11 в решебнике
//int x = 1, y = -1;
//Console.WriteLine(x * x + y + y <= 4);
//x = 1;y = 2;
//Console.WriteLine((x >= 0 )|| (y * y != 4));
//x = 2;y = 1;
//Console.WriteLine(x * y != 0 && y > x);
//3.31
//Console.Write("Введите N:");
//int n=int.Parse(Console.ReadLine());
//Console.WriteLine(n % 5 == 0 || n % 7 == 0);
//Console.WriteLine(n%4==0&&n%10==0);
//3.32
Console.Write("Введите X:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите Y:");
double y = double.Parse(Console.ReadLine());
if ((x >= 2) && (y >= 1 || y <= -1.5))
{
    Console.WriteLine("Popal!");
}
else
{
    Console.WriteLine("Ne Popal!");
}
//Console.Write("Введите х:");
//double x=double.Parse(Console.ReadLine());
//Console.Write("Введите у:");
//double y = double.Parse(Console.ReadLine());
//Console.WriteLine(y >= 1 && y <= -3);
//3.34
