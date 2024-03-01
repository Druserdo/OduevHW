Random random = new Random();
int numUser;
int numPc = random.Next(1, 6);
int i=0;
do
{
    
    Console.Write("Wwedite chislo:");
    numUser = int.Parse(Console.ReadLine());
    if (numUser == numPc)
        Console.WriteLine("Pobeda!");
    else Console.WriteLine($"попробуй еще");
    i++;
}
while (i!=3);
if (i == 3 || numUser != numPc)
{
    Console.Write($"{numPc}");
}