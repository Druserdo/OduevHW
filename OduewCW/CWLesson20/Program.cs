//Console.Write("Введите количество строк массива:");
//int n=int.Parse(Console.ReadLine());
//int[][] mas = new int[n][];
//Random rand = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] =new int [rand.Next(1, 10)];
//}
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = 0; j < mas[i].Length; j++)
//    {
//        mas[i][j] = rand.Next(10,100);
//        Console.Write(mas[i][j]+" ");
//    }
//    Console.WriteLine();
//}

//char[,] mas = new char[8,8];
//for (int i = 0; i <mas.GetLength(0); i++)
//{
//    for (int j = 0; j <mas.GetLength(1); j++)
//    {
//        if ((i + j) % 2 == 0) mas[i, j] = 'W';
//        else mas[i, j] = 'B';
//        Console.Write(mas[i,j]+" ");
//    }
//    Console.WriteLine();
//}
//string[] mast = new string[] { "пики","крести","червы","буби"};
//string[] nominal = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "валет", "дама", "король", "туз" };
//string[,,] players = new string[4, 2, 2];
//Random rand = new Random();
//for (int i = 0; i < players.GetLength(0); i++)
//{
//    Console.Write(i+". ");
//    for (int j = 0; j < players.GetLength(1); j++)
//    {
//        players[i, j,0] = mast[rand.Next(4)];
//        players[i, j,1] = nominal[rand.Next(13)];
//        Console.Write( players[i, j, 0] + " " + players[i, j, 1]+"\t");
//    }
//    Console.WriteLine();
//}
//int[,,] mas = new int[4, 6, 8];
//Random rand = new Random();
//for (int k = 0; k < mas.GetLength(2); k++)
//{

//    for (int i = 0; i < mas.GetLength(0); i++)
//    {

//        for (int j = 0; j< mas.GetLength(1); j++)
//        {
//            mas[i, j, k] = rand.Next(10, 100);
//            Console.Write(mas[i, j, k] + " ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}
//Console.Write("Введите элемент:");
//int m = int.Parse(Console.ReadLine());
//mas[3,5,7] = m;
//mas[0, 0, 0] = m;
//mas[1,2,3] = m;
//for (int k = 0; k < mas.GetLength(2); k++)
//{

//    for (int i = 0; i < mas.GetLength(0); i++)
//    {

//        for (int j = 0; j < mas.GetLength(1); j++)
//        { 
//            Console.Write(mas[i, j, k] + " ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}
//int[,] mas1 = new int[3, 3];
//int[,]mas2 = new int[3, 3];
//Random  rand = new Random();
//for (int i = 0; i < mas1.GetLength(0); i++)
//{
//    for (int j = 0; j < mas1.GetLength(1); j++)
//    {
//        mas1[i, j] = rand.Next(10,100);
//        Console.Write(mas1[i,j]+" ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//for (int i = 0; i < mas2.GetLength(0); i++)
//{
//    for (int j = 0; j < mas2.GetLength(1); j++)
//    {
//        mas2[i, j] = rand.Next(10, 100);
//        Console.Write(mas2[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//Console.WriteLine("1");
//int[,,] mas=new int[3,3,2];
//for (int k = 0; k < mas.GetLength(2); k++)
//{

//    for (int i = 0; i < mas.GetLength(0); i++)
//    {

//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//           if(k==0) mas[i,j,k]= mas1[i,j];
//            if (k == 1) mas[i, j, k] = mas2[i, j];
//            Console.Write(mas[i,j,k]+" ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}
