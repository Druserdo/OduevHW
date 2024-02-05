Console.Write("Введите радиус окружности:");
double r=double.Parse(Console.ReadLine());
double length=2*Math.PI*r;
double S = Math.PI * (r * r);
Console.WriteLine($"Длинна окружности с радиусом {r} равна {length:F2}");
Console.WriteLine($"Площадь окружности с радиусом {r} равна {S:F2}");