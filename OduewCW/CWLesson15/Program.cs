//Console.WriteLine((int)'A');
//Console.WriteLine((int)'Z');
//Console.WriteLine((int)'a');
//Console.WriteLine((int)'z');
//Console.WriteLine((int)'0');
//Console.WriteLine((int)'1');

//инициализация
//int[] mas1 = new int[] { 4, 7, 3, 8, 2 };
//Ввод с клавиатуры
//int[] mas2 = new int[5];
//Console.WriteLine("Введите элементы массива");
//for (int i = 0; i < mas2.Length; i++)
//{
//    mas2[i]=int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < mas2.Length; i++)
//    Console.Write(mas2[i]+" ");
//Console.WriteLine();

//по формуле
//int[]mas3 = new int[10];
//for (int i = 0;i < mas3.Length; i++)
//{
//    mas3[i] = 2 * i + 1;
//    Console.Write(mas3[i]+" ");
//}
//Console.WriteLine();

//генератор случайных чисел
//int[]mas4 = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas4.Length; i++)
//{
//    mas4[i] = random.Next(10,100);
//    Console.Write(mas4[i]+" ");
//}
//Console.WriteLine();

//double[] mas5 = new double[10];
//Random random = new Random();
//for (int i = 0; i < mas4.Length; i++)
//{
//    mas5[i] = random.NextDouble()*100;
//    Console.Write($"{mas5[i]:F2} ");
//}
//Console.WriteLine();
//Console.Write("Введите размер массива:");
//int n = int.Parse(Console.ReadLine());
//int[] mas = new int[n];
//Random random = new Random();
//int sum = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100);
//    Console.Write(mas[i] + " ");
//    sum += mas[i];
//}
//Console.WriteLine("sum=" + sum);

//Console.Write("Введите размер массива:");
//int n = int.Parse(Console.ReadLine());
//int[] mas = new int[n];
//Random random = new Random();
//int sum = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100);
//    sum += mas[i];
//}
//foreach (int i in mas)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine("sum=" + sum);

//int[] mas = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(-7,8);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//Console.Write("Введите число от -7 до 7:");
//int num1=int.Parse(Console.ReadLine());
//int last=-1;
//int count =0;
//for (int i = 0;i < mas.Length; i++)
//{
//    if (mas[i] == num1) last = i;
//    if (mas[i]<num1) count++;
//}
//if (last != -1)
//Console.WriteLine(last);
//else Console.WriteLine("Такого числа нет!");
//Console.WriteLine(count);
//задача 4
//Console.WriteLine("Введите размер");
//int n = int.Parse(Console.ReadLine());
//string[] mas = new string[n];
//Console.WriteLine("Введите имена");
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = Console.ReadLine();
//}
//foreach(string i in mas)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();
//int[] mas = { 4, 6, 1, 7, 9, 0, 8, 5, 3, 2 };
//Console.WriteLine("Введите число");
//int n=int.Parse(Console.ReadLine());
//bool have=false;
//for (int i = 0; i <mas.Length; i++)
//{
//    if (mas[i] ==n)
//    {  have = true; break; }
//}
//if (have == true) Console.WriteLine(n);
//else Console.WriteLine("NO");

//double[] mas = new double[20];
//Random random = new Random();

//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.NextDouble();
//    if (mas[i]>0)
//    {
//        Console.WriteLine();
//    }
//}
int[] mas = new int[10];
Random random = new Random();
int sum =0;
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10,100);
    Console.WriteLine(mas[i]+" ");
    if (mas[i] % 3 == 0) sum += mas[i];
}
Console.WriteLine("sum"+sum);