//1
//Console.WriteLine("Введите числа через ','");
//string offer=Console.ReadLine();
//string[] mas = offer.Split(",");
//int sum = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    sum+= int.Parse(mas[i]);
//}
//Console.Write(sum);
//2
Console.WriteLine("Введите предложение:");
string offer=Console.ReadLine();
string[] mas = offer.Split(" ");
Console.WriteLine($"Количество слов: {mas.Length}");