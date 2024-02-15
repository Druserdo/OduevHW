Console.Write("Введите катет:");
double catA=double.Parse(Console.ReadLine());
Console.Write("Введите гипотенузу:");
double gepotenuza=double.Parse(Console.ReadLine());
double catetB = Math.Sqrt((gepotenuza * gepotenuza) / (catA * catA));
Console.WriteLine($"Второй катет равен {catetB}");