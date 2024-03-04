//Random random = new Random();
//int temperature = 0;
//for (int i = 1; ; i++)
//{
//    temperature = random.Next(1, 101);
//    Console.WriteLine("Температура равна:"+temperature);
//    if (temperature >=90)
//    { Console.WriteLine("Критическая температура");
//        break;
//    }
//}

        Console.Write("Укажите количество квадратов: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Укажите сторону квадрата: ");
        int weigth = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < quantity; i++)//будет продолжаться пока i меньше количества квадратов
        {
            for (int j = 0; j < weigth; j++)//будет выводить "* " пока j меньше стороны квадрата
            {
                Console.Write("*");
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int k = 0; k < weigth - 2; k++)//будет идти за предыдущим циклом и выводить * пока к<стороны квадрата -2, и выводить пробел пока l < стороны квадрата + сторона квадрата -2, затем снова * и пустая строка
            {
                Console.Write("*");
                for (int l = 0; l < weigth + weigth - 2; l++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }
            for (int m = 0; m < weigth; m++)//выводит *+пробел пока мменьше стороны квадрата
            {
                Console.Write("*");
                Console.Write(" ");
            }

            Console.WriteLine();
        }