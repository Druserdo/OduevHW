//int number = 11;
////Console.WriteLine(number);//1
////Console.WriteLine(++number);//2
////Console.WriteLine(number++);//2
////Console.WriteLine(number);//3
////Console.WriteLine(--number);//2
////Console.WriteLine(number--);//2
////Console.WriteLine(number);//1
//Console.WriteLine(number++ * 2);

//int animals = 0;
//Console.WriteLine($"В зоопарке {animals} животных.");
//animals = animals + 46;
//Console.WriteLine($"В зоопарке {animals} животных.");
//animals = animals + 12;
//Console.WriteLine($"В зоопарке {animals} животных.");
//animals = animals + 4;
//Console.WriteLine($"В зоопарке {animals} животных.");
//animals = animals + 8;
//Console.WriteLine($"В зоопарке {animals} животных.");
//animals = animals + 15;
//Console.WriteLine($"В зоопарке {animals} животных.");
//кенгуру
//double s = 240;
//double momV = 3;
//double sonV = 2;
//Console.WriteLine($"Мать будет ждать сына {Math.Abs((s/momV)-(s/sonV))}с");
//Console.WriteLine("Wwedite x");
//int x = int.Parse(Console.ReadLine());
//Console.WriteLine($"{x=x-x%100/10*10}");
//int firstNum = 15;
//firstNum = firstNum + 6;
//int secondNum = -firstNum;
//int result = -firstNum - 2 * secondNum;
//Console.WriteLine(result);

//int firstNum = 12 + 6 * 4;
//int secondNum = (firstNum % 5) + 19;
//firstNum = (secondNum / 10) + 3;
//int result = firstNum - secondNum;
//Console.WriteLine(result);
Console.Write("Введите количество денег:");
decimal money = decimal.Parse(Console.ReadLine());
decimal butter = 150;
decimal bread = 50;
decimal tea = 40;
string Price = $"Масло = {butter}\nХлеб = {bread}\nЧай = {tea}";
Console.WriteLine(Price);
Console.Write("Введите количество Масла:");
int quanttityButter=int.Parse(Console.ReadLine());
double qButter = (double)quanttityButter * (double)butter;
Console.Write("Введите количество Хлеб:");
int quanttityBread = int.Parse(Console.ReadLine());
double qBread = (double)quanttityBread * (double)bread;
Console.Write("Введите количество Чай:");
int quanttityTea = int.Parse(Console.ReadLine());
double qTea = (double)quanttityTea * (double)tea;
double check = qButter+qBread+qTea;
Console.WriteLine($"Сумма: {check}");
