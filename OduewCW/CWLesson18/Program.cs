﻿//Console.Write("Введите число строк:");
//int n=int.Parse(Console.ReadLine());
//Console.Write("Введите число столбцов:");
//int m = int.Parse(Console.ReadLine());
//int[,] mas = new int[n, m];
//Random r = new Random();
//for (int i = 0;i<mas.GetUpperBound(0)+1;i++)
//{
//    for (int j = 0;j<mas.GetUpperBound(1)+1;j++)
//    {
//        mas[i, j] = r.Next(10, 100);
//        Console.Write(mas[i,j]+" ");
//    }
//    Console.WriteLine();
//}
//int[,] mas2 = { { 1, 2, 3 }, { 4,5,6 }, { 7,8,9} };

//1,2
//Random random = new Random();
//int n=random.Next(1,10);
//int m=random.Next(1,10);
//int[,] mas=new int[n,m];
//int sum = 0;
//double p = 1;
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//        sum += mas[i, j];
//        p *= mas[i, j];
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("Sum="+sum);
//Console.WriteLine($"Произведение={p:F2}");

//3
//Random random = new Random();
//int n = random.Next(1, 10);
//int m = random.Next(1, 10);
//int[,] mas = new int[n, m];
//int count = 0;
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//        for (int k = 0;k<count;k++) Console.Write(" ");
//        Console.WriteLine(mas[i, j] + " ");
//        count++;
//    }
//}
//4
//string[,] mas = { {"Tom","987456","Tom@gmail.com"},
//                  {"Jerry","784512","Jerry@gmail.com" },
//                  {"Max","458963","Max@gmail.com"} };
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//    {
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.Write("Введите имя:");
//string name=Console.ReadLine();
//bool isTrue=false;
//for (int i = 0;i<mas.GetUpperBound(0) + 1;i++)
//{
//    if (mas[i, 0] == name)
//    {
//        isTrue = true;
//        Console.WriteLine(mas[i,0]+" "+ mas[i,1]+" "+ mas[i,2]);
//    }
//}
//if(isTrue==false) Console.WriteLine("Элемента нет!");

//4
//Random random = new Random();
//int n = random.Next(5, 10);
//int m = random.Next(5, 10);
//int[,] mas = new int[n, m];
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//        Console.Write(mas[i, j] + " ");
//    }

//    Console.WriteLine();
//}
//for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
//{
//   double sum = 0;
//    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
//    {
//      sum += mas[i, j];
//    }
//    Console.WriteLine($"AVG {i+1}:{sum/ mas.GetUpperBound(1) + 1:F2}");
//}
Random random = new Random();
int n = random.Next(5, 10);
int m = random.Next(5, 10);
int[,] mas1 = new int[n, m];
int[,] mas2 = new int[m, n];
for (int i = 0; i < mas1.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < mas1.GetUpperBound(1) + 1; j++)
    {
        mas1[i, j] = random.Next(10, 100);
        Console.Write(mas1[i, j] + " ");
        mas2[j, i] = mas1[i, j];
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < mas2.GetUpperBound(0) + 1; i++)
{
    for (int j = 0; j < mas2.GetUpperBound(1) + 1; j++)
    {
        Console.Write(mas2[i, j] + " ");
    }
    Console.WriteLine();
}