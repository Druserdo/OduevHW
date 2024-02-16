Console.Write("Введите температуру:");
int t = int.Parse(Console.ReadLine());
if (t > 20 && t <= 35)
   Console.WriteLine("Можно выводить на прогулку слонов, жирафов и львов.");
else if (t < 20 && t >=10)
        Console.WriteLine("Можно выводить на прогулку медведей, волков и пингвинов.");
     else if(t==20)
            Console.WriteLine("Можно выводить на прогулку кенгуру.");
          else
            Console.WriteLine("Температура не входит в диапазон.");