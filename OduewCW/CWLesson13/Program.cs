//инициализация-присвоение переменным учавствующим в цикле начальных значений.
// итерация- однократное выполнение тела цикла
//int i = 5;
//while (i>0)
//{
//    Console.WriteLine(i--);
//}
//Console.Write("Введите  число:");
//int n=int.Parse(Console.ReadLine());
//long fact=1;
//int i = 1;
//while (i <= n)
//{
//    fact = fact * i;//fact*=i++;
//    i = i + 1;
//}
//Console.WriteLine(fact)


//int a;
//double Sum = 0;
//int CountGreat10 = 0;
//int CountLess10 = 0;
//double avg = 0;
//int min=int.MaxValue;
//int max=int.MinValue;
//int i = 1;
//while (i <= 10)
//{
//    Console.Write($"Введите {i} число:");
//    a=int.Parse(Console.ReadLine());
//    Sum += a;
//    if(a>10) CountGreat10++;
//    if(a<10) CountLess10++;
//    if (a>max) max= a;
//    if (a<min) min= a;
//    i++;
//}
//Console.WriteLine("sum= " + Sum);
//Console.WriteLine("count>10= " + CountGreat10);
//Console.WriteLine("count<10= " + CountLess10);
//Console.WriteLine("min= " + min);
//Console.WriteLine("max= " + max);
//Console.WriteLine($"avg= {Sum / 10}");
//            ЦИКЛ С ПОСТ УСЛОВИЕМ
//do
//{
//    int n;
//    do
//    {
//        Console.Write("Введите положительное число:");
//        n = int.Parse(Console.ReadLine());
//        if (n <= 0) Console.WriteLine("Введите положительное число");
//    }
//    while (n <= 0);
//    int Sum = 0;
//    int i = 1;
//    do
//    {
//        Sum += i++;
//    }
//    while (i <= n);
//    Console.WriteLine(Sum);
//    Console.Write("Введите y/n:");
//    char answer = char.Parse(Console.ReadLine());
//    if (answer == 'y') break;
//}
//while (true);

//int sum = 0;
//int i = 1;
//Random rand = new Random();
//while(i<=50)
//{
//    int a=rand.Next(1,50);
//    if (a % 2 != 0) continue;
//    Console.Write(a+" ");
//    sum += a;
//    i++;
//}
//Console.WriteLine(sum);

//задача 2
//int num1;
//int num2;
//do
//{
//    Console.Write("Введите два различных числа:");
//    num1 = int.Parse(Console.ReadLine());
//    num2 = int.Parse(Console.ReadLine());
//}
//while(num1 == num2);
//if (num1<num2)
//{
//    int i = num1;
//    while(i <= num2)
//    {
//        Console.Write(i + " ");
//        i++;
//    }
//}
//else
//{
//    int i=num1;
//    while(i >= num2)
//    {
//        Console.Write(i + " ");
//        i--;
//    }
//}
//3 take
//Console.Write("Введите число:");
//int num= int.Parse(Console.ReadLine());
//int i = 1;
//while (i<=num)
//{
//    if (i % 2 != 0) Console.Write(i + " ");
//    i++;
//}
//Console.Write("Введите число:");
//int num = int.Parse(Console.ReadLine());
//int i = 1;
//while (i<=10)
//{
//    Console.WriteLine($"{num} * {i} = {num*i}");
//    i++;
//}