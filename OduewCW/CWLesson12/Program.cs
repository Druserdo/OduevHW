//Console.Write("Введите номер дня недели:");
//byte n=byte.Parse(Console.ReadLine());
//switch (n)
//{
//        case 1:Console.WriteLine("Понедельник"); break;
//        case 2: Console.WriteLine("Вторник"); break;
//        case 3: Console.WriteLine("Среда"); break;
//        case 4: Console.WriteLine("Четверг"); break;
//        case 5: Console.WriteLine("Пятница"); break;
//        case 6: Console.WriteLine("Суббота"); break;
//        case 7: Console.WriteLine("Воскресенье"); break;
//        default: Console.WriteLine("Такого дня нет");break;
//}

//Console.Write("Введите номер месяца:");
//byte n = byte.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1: case 2: case 12: Console.WriteLine("Зима"); break;
//    case 3: case 4: case 5: Console.WriteLine("Весна"); break;
//    case 6: case 7: case 8: Console.WriteLine("Лето"); break;
//    case 9: case 10: case 11: Console.WriteLine("Осень"); break;
//    default: Console.WriteLine("Такого месяца нет"); break;
//}
//Random random = new Random();
//Console.WriteLine("Выберете какие числа сгенерировать?\n 1 - целые\n2 - с плавающей точкой\n3 - диапазон чисел");
//Console.Write("Введите число:");
//byte num=byte.Parse(Console.ReadLine());

//switch (num)
//{
//    case 1:
//        {
//           Console.Write("Введите максимальное значение: ");
//           int max = int.Parse(Console.ReadLine());
//           Console.WriteLine(random.Next(max)+1);
//        }
//        break;
//    case 2:
//        {
//            Console.Write("Введите максимальное значение: ");
//            int max = int.Parse(Console.ReadLine());
//            Console.WriteLine($"{random.NextDouble() * max:F2}");
//        }
//        break;
//    case 3:
//        {
//            Console.Write("Введите минимальное значение: ");
//            int min = int.Parse(Console.ReadLine());
//            Console.WriteLine("Введите максимальное значение: ");
//            int max = int.Parse(Console.ReadLine());
//            if (min < max)
//            {
//                int temp=max;
//                max = min;
//                min = temp;
//            }
//            Console.WriteLine($"{random.Next(min,max)}");
//        }
//        break;
//    default:
//        Console.WriteLine("Такого варианта нет");
//        break;
//}

//Console.WriteLine("Выберете валюту\n1 - доллары\n2 - евро\n3 - рубли\n4 - юани\n5 - стерлинги");
//Console.Write("Введите номер:");
//byte num = byte.Parse(Console.ReadLine());
//Console.Write("Введите курс обмена:\n");
//decimal curs=decimal.Parse(Console.ReadLine());
//Console.WriteLine("Введите количество");
//int quantity=int.Parse(Console.ReadLine());
//switch (num)
//{
//        case 1: Console.WriteLine($"{quantity} долларов = {curs * quantity}");
//        break; 
//        case 2: Console.WriteLine($"{quantity} евро = {curs * quantity}");
//        break;
//        case 3: Console.WriteLine($"{quantity} рублей = {curs * quantity}");
//        break;
//        case 4: Console.WriteLine($"{quantity} юаней = {curs * quantity}");
//        break;
//        case 5: Console.WriteLine($"{quantity} стерлингов = {curs * quantity}");
//        break;
//        default: Console.WriteLine("Нет такого варианта");
//        break;
//}
//Console.Write("Введите камень, ножницы или бумага:");
//string choice = Console.ReadLine();
//Random random = new Random();
//string pc="" ;
//switch (random.Next(1,4))
//{
//    case 1: pc = "камень"; break;
//    case 2: pc = "ножницы"; break;
//    case 3: pc = "бумага"; break;
//}
//Console.Write(choice+" "+pc);
//Random random = new Random();
//int sum = 0;
//int n1= random.Next(100);
//int n2= random.Next(100);
//int var = 0;
//switch(random.Next(1,5))
//{
//    case 1: { var = n1 + n2; Console.Write($"{n1}+{n2}="); } break;
//    case 2: { var = n1 - n2; Console.Write($"{n1}-{n2}="); } break;
//    case 3: { var = n1 * n2; Console.Write($"{n1}*{n2}="); } break;
//    case 4: { var = n1 / n2; Console.Write($"{n1}/{n2}="); } break;
//}
//Console.WriteLine("Введите ответ:");
//int res = int.Parse( Console.ReadLine() );
//if (res == var) sum++;

// n1 = random.Next(100);
// n2 = random.Next(100);
// var = 0;
//switch (random.Next(1, 5))
//{
//    case 1: { var = n1 + n2; Console.Write($"{n1}+{n2}="); } break;
//    case 2: { var = n1 - n2; Console.Write($"{n1}-{n2}="); } break;
//    case 3: { var = n1 * n2; Console.Write($"{n1}*{n2}="); } break;
//    case 4: { var = n1 / n2; Console.Write($"{n1}/{n2}="); } break;
//}
//Console.WriteLine("Введите ответ:");
//res = int.Parse(Console.ReadLine());
//if (res == var) sum++;
//n1 = random.Next(100);
//n2 = random.Next(100);
//var = 0;
//switch (random.Next(1, 5))
//{
//    case 1: { var = n1 + n2; Console.Write($"{n1}+{n2}="); } break;
//    case 2: { var = n1 - n2; Console.Write($"{n1}-{n2}="); } break;
//    case 3: { var = n1 * n2; Console.Write($"{n1}*{n2}="); } break;
//    case 4: { var = n1 / n2; Console.Write($"{n1}/{n2}="); } break;
//}
//Console.WriteLine("Введите ответ:");
//res = int.Parse(Console.ReadLine());
//if (res == var) sum++;
//n1 = random.Next(100);
//n2 = random.Next(100);
//var = 0;
//switch (random.Next(1, 5))
//{
//    case 1: { var = n1 + n2; Console.Write($"{n1}+{n2}="); } break;
//    case 2: { var = n1 - n2; Console.Write($"{n1}-{n2}="); } break;
//    case 3: { var = n1 * n2; Console.Write($"{n1}*{n2}="); } break;
//    case 4: { var = n1 / n2; Console.Write($"{n1}/{n2}="); } break;
//}
//Console.WriteLine("Введите ответ:");
//res = int.Parse(Console.ReadLine());
//if (res == var) sum++;
//n1 = random.Next(100);
//n2 = random.Next(100);
//var = 0;
//switch (random.Next(1, 5))
//{
//    case 1: { var = n1 + n2; Console.Write($"{n1}+{n2}="); } break;
//    case 2: { var = n1 - n2; Console.Write($"{n1}-{n2}="); } break;
//    case 3: { var = n1 * n2; Console.Write($"{n1}*{n2}="); } break;
//    case 4: { var = n1 / n2; Console.Write($"{n1}/{n2}="); } break;
//}
//Console.WriteLine("Введите ответ:");
//res = int.Parse(Console.ReadLine());
//if (res == var) sum++;
//Console.Write("Введите количество месяцев:");
//int n=int .Parse(Console.ReadLine());
//switch(n%12+1)
//{
//    case 1:Console.WriteLine("Январь"); break;
//}
//Console.WriteLine("Введите число:");
//int num=int.Parse(Console.ReadLine());
//if (num % 100 >=11 && num % 100 <= 14) 
//    Console.WriteLine($"{num} рублей");
//else
//switch (num%10)
//{
//    case 1: Console.WriteLine($"{num} рубль"); break;
//    case 2:case 3: case 4: Console.WriteLine($"{num} рубля"); break;
//    default: Console.WriteLine($"{num} рублей"); break;
//}
//Console.Write("Введите номер карты:");
//int num = int.Parse(Console.ReadLine());
//Console.Write("Выберите масть:");
//int mast=int.Parse(Console.ReadLine());

//switch (num)
//{
//    case 6: Console.Write("шестерка "); break;
//    case 7: Console.Write("семерка "); break;
//    case 8: Console.Write("восьмерка "); break;
//    case 9: Console.Write("девятка "); break;
//    case 10: Console.Write("десятка "); break;
//    case 11: Console.Write("валет "); break;
//    case 12: Console.Write("дама "); break;
//    case 13: Console.Write("король "); break;
//    case 14: Console.Write("туз "); break;
//}
// switch (mast)
//{
//    case 1: Console.WriteLine("Пики");break;
//        case 2: Console.WriteLine("Трефы");break;
//        case 3: Console.WriteLine("Бубны");break;
//        case 4: Console.WriteLine("Червы");break;
//}

