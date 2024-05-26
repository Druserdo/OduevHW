//1
//Console.WriteLine("Hello, World!");
//Console.Write("Введите ваше имя:");
//string name=Console.ReadLine();
//Console.WriteLine($"Привет {name}");

//3
//Console.Write("Введите число:");
//int num1=int.Parse(Console.ReadLine());
//Console.Write("Введите число:");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine(num1+num2);

//4
//Console.Write("Введите число:");
//int num3 = int.Parse(Console.ReadLine());
//if (num3%2 == 0)
//{
//    Console.WriteLine("Четное");
//}
//else Console.WriteLine("Не четное");

//5
//Console.Write("Введите число:");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Введите число:");
//int num2 = int.Parse(Console.ReadLine());
//Console.Write("Введите число:");
//int num3 = int.Parse(Console.ReadLine());
//int max = Math.Max(num1, Math.Max(num2, num3));
//Console.WriteLine(max);

//6
//Console.Write("Введите число:");
//int num1 = int.Parse(Console.ReadLine());
//int fakt = 1;
//for (int i = 0; i < num1; i++)
//{
//    fakt = fakt * (i + 1);
//}
//Console.WriteLine(fakt);

//7
//Console.Write("Введите число:");
//int num1 = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = 0; i < num1; i++)
//{
//    sum +=i;
//}
//Console.WriteLine(sum);

//8
//Console.Write("Введите строку");
//string str= Console.ReadLine();
//Console.WriteLine(str.Length);

//9
//Console.Write("Введите число:");
//int num1;
//int.TryParse(Console.ReadLine()!, out num1);
//int count = 0;

//for (int i = 1; i < num1; i++)
//{
//    if (num1 % i != 0) count++;
//}
//if (count == 0) Console.WriteLine("Число простое");
//else Console.WriteLine("Число не простое");

//10
//Console.Write("Введите число:");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Введите число:");
//int num2 = int.Parse(Console.ReadLine());
//Console.Write("Введите число:");
//int num3 = int.Parse(Console.ReadLine());
//double avg=(num1+num2+num3);
//Console.WriteLine(avg);

//11
//Console.Write("Введите число:");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Введите число:");
//int num2 = int.Parse(Console.ReadLine());
//Console.Write("Введите число:");
//int num3 = int.Parse(Console.ReadLine());
//int min = Math.Min(num1, Math.Min(num2, num3));
//Console.WriteLine(min);

//12
//Console.Write("Введите строку:");
//string str=Console.ReadLine()!;
//string res = "";
//for (int i=str.Length-1;i>=0; i--)
//{
//  res+= str[i];
//}
//Console.WriteLine(res);

//13
//Console.Write("Введите строку:");
//string str = Console.ReadLine()!;
//string res = "";
//for (int i = str.Length - 1; i >= 0; i--)
//{
//    res += str[i];
//}
//if (res == str) Console.WriteLine("Полиндром");
//else Console.WriteLine("Не полиндром");

//14
//Console.Write("Введите число:");
//int num;
//int.TryParse(Console.ReadLine()!, out num);
//int summ = 0;
//for (int i=1; i<num; i++)
//{
//    if (num % i == 0) summ += i;
//}
//if (summ == num) Console.WriteLine("Число совершенно");
//else Console.WriteLine("Число не совершенно");

//15
//Console.Write("Введите число:");
//int num1;
//int.TryParse(Console.ReadLine()!, out num1);

//for (int i = 1; i <= 100; i++)
//{
//    int k = 0;
//    for (int j = 2; j < i; j++)
//    {
//        if (j % i == 0) k++;
//    }
//    if (k == 0) Console.Write(i+" ");
//}

//16
//Console.Write("Введите число:");
//int num1;
//int.TryParse(Console.ReadLine()!, out num1);
//int sum = 0;
//for (int i = 1; i < num1; i++)
//{
//    if (i % 2 == 0) sum += i;
//}
//Console.WriteLine(sum);

//17
//string abc = "";
//for (int i = (int)'а';i<= (int)'я';i++ )
//{
//    if (Char.IsLetter((char)i))abc += (char)i;
//}
//Console.WriteLine(abc);
//string res = "";
//string str =Console.ReadLine()!;
//for (int i = 0;i<str.Length;i++)
//{
//    if (!res.Contains(str[i]) && Char.IsLetter(str[i]))res += Char.ToLower(str[i]);
//}
//char[] mas=res.ToArray();
//Array.Sort(mas);
//res=new string(mas);
//Console.WriteLine(res);
//if (abc == res) Console.WriteLine("Annagram");
//else Console.WriteLine("NeAnagram");
