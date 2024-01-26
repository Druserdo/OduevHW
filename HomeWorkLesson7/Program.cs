const double PI = 3.14;
Console.Write("Введите радиус окружности:");
double radius=double.Parse(Console.ReadLine());
double areaOfCircle = PI * (radius * radius);
Console.WriteLine($"Площадь окружности равна {areaOfCircle}");