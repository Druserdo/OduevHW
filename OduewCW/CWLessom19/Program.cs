﻿//Console.Write("Введте максимальное количество задач:");
//int n=int.Parse(Console.ReadLine());
//string[,] mas = new string[n, 4];

//int count = 0;//количество задач
//int number;
//bool start=true;
//do
//{
//    Console.Clear();
//    Console.WriteLine($"Всего задач {n}\nСвободных {n-count}");
//    Console.WriteLine("Menu");
//    Console.Write($"1.Добавить задачу\n2.Удалить задачу\n3.Перезписать задачу\n4.Вывести список задач\n5.Выход\n");
//    try
//    {
//        Console.Write("Введите действие:");
//        number = int.Parse(Console.ReadLine());

//        switch (number)
//        {
//            case 1:
//                {
//                    if (count < n)
//                    {
//                        Console.Write("Введите название задачи:");
//                        string name = Console.ReadLine();
//                        Console.Write("Введите дату задачи:");
//                        string date = Console.ReadLine();
//                        Console.Write("Введите время задачи:");
//                        string time = Console.ReadLine();
//                        Console.Write("Введите приоритет задачи:");
//                        string priority = Console.ReadLine();
//                        mas[count, 0] = name;
//                        mas[count, 1] = date;
//                        mas[count, 2] = time;
//                        mas[count, 3] = priority;
//                        count++;
//                    }
//                    else
//                    {
//                        Console.Write("Нет свободных мест");
//                        Console.ReadKey();
//                    }
//                }
//                break;
//            case 2:
//                {

//                    Console.Write("Введите номер задачи для удаления:");
//                    int m = int.Parse(Console.ReadLine());
//                    for (int i = 0; i < mas.GetLength(1); i++)
//                    {
//                        mas[m - 1, i] = "";
//                    }
//                }
//                break;
//            case 3:
//                {
//                    Console.Write("Введите номер задачи для удаления:");
//                    int m = int.Parse(Console.ReadLine());
//                    Console.Write("Введите название задачи:");
//                    string name = Console.ReadLine();
//                    Console.Write("Введите дату задачи:");
//                    string date = Console.ReadLine();
//                    Console.Write("Введите время задачи:");
//                    string time = Console.ReadLine();
//                    Console.Write("Введите приоритет задачи:");
//                    string priority = Console.ReadLine();
//                    mas[m, 0] = name;
//                    mas[m, 1] = date;
//                    mas[m, 2] = time;
//                    mas[m, 3] = priority;
//                }
//                break;
//            case 4:
//                {
//                    for (int i = 0; i < count; i++)
//                    {
//                        Console.WriteLine($"{i + 1,-3}{mas[i, 0],-20}{mas[i, 1],-10}{mas[i, 2],-10}{mas[i, 3],5}"
//                            );
//                    }
//                    Console.ReadKey();
//                }
//                break;
//            case 5:
//                start = false;
//                break;
//            default:
//                break;

//        }
//    }
//    catch
//    {

//    }

//}
//while (start);
//int[,] mas = new int[9, 9];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i,j]=(i+1)*(j+1);
//        Console.Write($"{i+1}*{j+1}={mas[i,j]} ");
//    }
//    Console.WriteLine();
//}
//int[,] mas = new int[7, 7];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (i == j||i+j==mas.GetLength(0)-1)
//            mas[i, j] = 1;
//        if(i==mas.GetLength(0)/2) mas[i,j]=1;
//        if (j == mas.GetLength(1) / 2) mas[i, j] = 1;
//        Console.Write(mas[i, j]+" ");

//    }
//    Console.WriteLine();
//}
