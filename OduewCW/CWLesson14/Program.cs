//for (int i=35;i<=87;i++)
//{
//    if (i %7==1||i%7==2||i%7==5)
//        Console.Write($"{i} ");
//}

//Console.Write("Введите n:");
//int n=int.Parse(Console.ReadLine());
//int s = 0;
//for (int i = 1; i <= n; s += i, i++) ;
//Console.WriteLine(s);
//take 1
//Console.WriteLine("Введите строку");
//string str = Console.ReadLine();
//for (int i =str.Length-1;i>=0;i--)
//    Console.Write(str[i]);
//take2
//Console.WriteLine("Введите строку");
//string str = Console.ReadLine();
//string rts = "";
//for (int i = str.Length - 1; i >= 0; i--)
//    rts += str[i];
//if (str == rts)
//    Console.WriteLine("Палиндром");
//else Console.WriteLine("Не палиндром ");
//Напишите программу, которая запрашивает у пользователя целое число и выводит на экран все его делители.
//Console.Write("Введите:");
//int num=int.Parse(Console.ReadLine());
//for (int i=1;i<=num;i++)
//{
//    if(num%i==0) Console.Write(i+" ");
//}

//Console.Write("Введите:");
//int num = int.Parse(Console.ReadLine());
//int i = 1;
//while (i<= num)
//{
//    int k = 0;
//    int j = 2; //внутренний счетчик
//    while (j<i)
//    { 
//        if (i % j == 0)
//            k++;
//            j++;
//    }
//    if (k==0) Console.Write(i+" ");
//    i++;
//}

//Console.Write("Введите:");
//int num = int.Parse(Console.ReadLine());
//for (int i = 1; i <= num; i++)
//{
//    int k = 0;//количество делителей
//    for (int j = 2; j < i; j++) if (i % j == 0) k++;
//    if (k == 0) Console.Write(i + " ");
//}

//Console.Write("Введите:");
//int num = int.Parse(Console.ReadLine());
//string str = "";

////while(num!=1)
////{
////    str += num % 2;
////    num /= 2; 
////}
////str += "1";
//for (; num != 1; str += num % 2, num /= 2) ;
//str += "1";
//for (int i = str.Length - 1; i >= 0; i--) 
//Console.Write(str[i]);



//Console.Write("Введите:");
//int num = int.Parse(Console.ReadLine());
//long fact = 1;
//for (int i = 1; i <= num; fact *= i++) ;
//    Console.WriteLine(fact);

//Console.Write("Введите число 1:");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Введите число 2:");
//int num2 = int.Parse(Console.ReadLine());
//for (int i = num1; i <= num2; i++) if (i%3==0 || i%5==0) Console.Write(i+" ");

Console.Write("Введите число 1:");
int num1 = int.Parse(Console.ReadLine());
int i = 1;
for (int j = 1; j <= num1; j+=i)
{
    Console.Write(j+" ");
    i = j - i;
}
