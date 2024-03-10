//double[,] mas= new double[3,3];
//Random rand= new Random();
//for(int i=0; i<mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = rand.NextDouble() * 10;
//        Console.Write($"{mas[i, j]:F2} ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.Write("Сколько чисел вы хотите заменить:");
//int n=int.Parse(Console.ReadLine());
//for (int i = 0; i < n; i++)
//{
//    Console.Write("Введите число:");
//    double num = double.Parse(Console.ReadLine());
//    Console.Write("Введите строку:");
//    int m = int.Parse(Console.ReadLine());
//    Console.Write("Введите столбец");
//    int g = int.Parse(Console.ReadLine());
//    mas[m-1, g-1] = num;
//}
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write($"{mas[i, j]:F2} ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
string[,] mas = { { "w", "o", "d", "l", "r" },{ "l" ,  "f", "l" , "g", "d" } };
Console.WriteLine($"{mas[0, 0]}{mas[0, 1]}{mas[0, 4]}{mas[1, 0]}{mas[1,4]}");
