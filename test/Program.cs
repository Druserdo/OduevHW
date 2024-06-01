string name = Console.ReadLine()!;
string[] massElements = File.ReadAllLines($@"{name}");

foreach(string el in massElements )
{
   Console.WriteLine(el);
}