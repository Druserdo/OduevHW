//Random random = new Random();
//int[] mas = new int[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(0, 10);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//Array.Reverse(mas);
//foreach (int i in mas) Console.Write(i+" ");
//Console.WriteLine();

//string[] mas = new string[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = Console.ReadLine();
//}
//foreach (string i in mas) Console.Write(i + " ");
//Console.WriteLine();
//int max = mas[0].Length;
//string res = mas[0];
//for (int i = 1; i<mas.Length; i++)
//{
//    if (mas[i].Length >max)
//    { max = mas[i].Length;
//      res = mas[i];
//    }
//}
//Console.WriteLine(res);
//Random random = new Random();
//int[] mas1 = new int[5];
//int[] mas2 = new int[4];
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = random.Next(10);
//    Console.Write(mas1[i] + " ");
//}
//Console.WriteLine();
//for (int i = 0;i < mas2.Length; i++)
//{
//    mas2[i] = random.Next(10);
//    Console.Write(mas2[i] + " ");
//}
//Console.WriteLine();
//int[] sumMas = mas1.Concat(mas2).ToArray();
//double sum = 0;
//foreach (int i in sumMas)
//{ 
//    sum += i;
//    Console.Write(i+" "); 
//}
//Console.WriteLine();
//Console.WriteLine($"Avg:{sum/sumMas.Length:F2}");

//Random random = new Random();
//int[] mas1 = new int[10];
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = random.Next(10);
//    Console.Write(mas1[i] + " ");
//}
//Console.WriteLine();
//Console.WriteLine(mas1.Max());//показывает максимальное значение в массиве 
//Console.WriteLine(mas1.Min());//показывает минимальное значение в массиве
//string[] mas = new string[5];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = Console.ReadLine();
//}
//foreach (string i in mas) Console.Write(i+" ");
//Console.WriteLine();
//Console.Write("Введите символ:");
//char c=char.Parse(Console.ReadLine());
//foreach (string i in mas)
//{
//    if (Array.IndexOf(i.ToArray(), c) == 0)
//        Console.Write(i + " ");
//}
//Random random = new Random();
//string[] mas = new string[6];
//string name1 = "Mark";
//string name2 = "Bogdan";
//string name3 = "Vika";
//string name4 = "Dodora";
//string name5 = "Veronika";
//string name6 = "Warya";
//for (int i = 0; i < mas.Length; i++)
//{
//    switch(random.Next(6))
//    {
//        case 0:mas[i] = name1;break;
//        case 1: mas[i] = name2; break;
//        case 2: mas[i] = name3; break;
//        case 3: mas[i] = name4; break;
//        case 4: mas[i] = name5; break;
//        case 5: mas[i] = name6; break;
//    }
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//do 
//{
//    Console.Write("Введите имя:");
//    string nameUser=Console.ReadLine();
//    while(Array.IndexOf(mas, nameUser)!=-1)
//    {
//        mas[Array.IndexOf(mas, nameUser)] = "Dell";
//    }
//    Console.Write("Продолжить у/н:");
//    char answer =char.Parse(Console.ReadLine());
//    if (answer == 'n') break;
//}
//while (true);
//foreach (string i in mas)  
//if (i !="Dell")  Console.Write(i+" ");
//Console.Write("Введите размер массива:");
//int n=int.Parse(Console.ReadLine());
//int[] mas1=new int[n];
//int[] mas2=new int[n];
//int[] mas3=new int[n];
//Random rand = new Random();
//for (int i = 0;i < mas1.Length; i++)
//{
//    mas1[i] = rand.Next(10,100);
//    mas2[i] = rand.Next(10, 100);
//    mas3[i] = mas1[i] - mas2[i];
//}
//foreach (int i in mas1) Console.Write(i+" ");
//Console.WriteLine();
//foreach (int i in mas2) Console.Write(i + " ");
//Console.WriteLine();
//foreach (int i in mas3) Console.Write(i + " ");
//Console.WriteLine();

//Console.Write("Введите размер массива:");
//int n = int.Parse(Console.ReadLine());
//double[] mas1 = new double[n];
//Random rand = new Random();
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = rand.NextDouble()*100;
//    Console.Write($"{mas1[i]:F2} ");
//}
//Console.WriteLine();
//Array.Reverse(mas1);
//string strMas1 = "";
//foreach (double i in mas1)
//{
//    Console.Write($"{i:F2} ");
//    strMas1 += i.ToString("F2")+ " ";
//}
//Console.WriteLine();
//Console.WriteLine(strMas1);
//Console.WriteLine(strMas1.Substring(0,strMas1.Length/2-1));
