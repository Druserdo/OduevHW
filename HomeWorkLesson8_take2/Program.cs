//1 задача
int firstEggs = 10 + 8;
int leftoverEggs = 9;
int eatenEggs = firstEggs-leftoverEggs;
if (eatenEggs <= 4)
{
    Console.WriteLine($"{eatenEggs} яйца осталось.");
}
else
    Console.WriteLine($"{eatenEggs} яиц осталось.");
//2 задача
int magazineWidth = 25;
int newspaperWidth = magazineWidth - 16;
Console.WriteLine($"\n\nширина газеты {newspaperWidth}см.");
//3 задача
double potato = 44;
double beet = potato / 4;
double onion = beet / 2;
Console.WriteLine($"\n\nПовар потратил {onion} лука.");