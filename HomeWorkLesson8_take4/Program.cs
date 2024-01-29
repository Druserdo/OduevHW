using System.ComponentModel.Design;

const string ADDRESS = "г.Калмнмнград ул.Шмудлера д.5";
DateTime currentDate = DateTime.Now;
const string ORGANIZATIONNAME = "OOO\"Семейный магазин\"";
const string CHECKLIST = "Название\tЦена\t\tКол-во\t\tСумма\n\n*****************************************************\n\n";

Console.Write("Введите количество денег:");
decimal money = decimal.Parse(Console.ReadLine());
decimal butter = 150;
decimal bread = 50;
decimal tea = 40;
decimal shirt = 120;
decimal gloves = 12;
decimal cap = 100;
string price = $"Масло = {butter}\nХлеб = {bread}\nЧай = {tea}";
string price_2 = $"\nРубашка = {shirt}\nПерчатки = {gloves}\nШапка = {cap}";
Console.WriteLine(price);
Console.WriteLine($"\n{price_2}");
Console.Write("Введите количество Масла:");
int quanttityButter = int.Parse(Console.ReadLine());
decimal qButter = (decimal)quanttityButter * (decimal)butter;
Console.Write("Введите количество Хлеб:");
int quanttityBread = int.Parse(Console.ReadLine());
decimal qBread = (decimal)quanttityBread * (decimal)bread;
Console.Write("Введите количество Чай:");
int quanttityTea = int.Parse(Console.ReadLine());
decimal qTea = (decimal)quanttityTea * (decimal)tea;
Console.Write("Введите количество Рубашка:");
int quanttityShirt = int.Parse(Console.ReadLine());
decimal qShirt = (decimal)quanttityShirt * (decimal)shirt;
Console.Write("Введите количество Перчатки:");
int quanttityGloves = int.Parse(Console.ReadLine());
decimal qGloves = (decimal)quanttityGloves * (decimal)gloves;
Console.Write("Введите количество Шапка:");
int quanttityCap = int.Parse(Console.ReadLine());
decimal qCap = (decimal)quanttityCap * (decimal)cap;
decimal total = qBread + qButter + qTea + qShirt + qGloves + qCap;
if (total <=money)
    Console.WriteLine($"\n\n\t{ORGANIZATIONNAME}\n\t{ADDRESS}\n\t{currentDate}\n{CHECKLIST}\nМасло\t\t{butter}\t\t{quanttityButter}\t\t{qButter}\nХлеб\t\t{bread}\t\t{quanttityBread}\t\t{qBread}\nЧай\t\t{tea}\t\t{quanttityTea}\t\t{qTea}\nРубашка\t\t{shirt}\t\t{quanttityShirt}\t\t{qShirt}\nПерчатки\t{gloves}\t\t{quanttityGloves}\t\t{qGloves}\nШапка\t\t{cap}\t\t{quanttityCap}\t\t{qCap}\n\n*****************************************************\n\n\t\tИТОГ:\t\t\t\t{total}\a");
else
    Console.WriteLine("Недостаточно средств!");