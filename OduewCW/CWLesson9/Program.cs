// a<<2 (два раза поделить на 2), a<<3 (три раза поделить на 2)
//a>>2(два раза умножить на 2), a>>3(три раза умножить на 2)
//int a = 10;
//Console.WriteLine(a >> 3);
//Console.WriteLine(a << 2);
//int b = 2;
//Console.WriteLine(a & b);
//int a = 5;
//int b = 22;
//Console.WriteLine(a | b);
Console.Write("Введите число:");
int a=int.Parse(Console.ReadLine());
if (a % 2 >= 1)
    {
     Console.WriteLine("Не чтное");
    }
else
    Console.WriteLine("Четное");