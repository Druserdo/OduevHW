int[,] mas = new int[2, 2];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write("Введите значение от 1 до 10:");
        mas[i,j]=int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}
Console.Write("Введите число 200:");
mas[1,0]=int.Parse(Console.ReadLine());
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write(mas[i,j]+" ");
    }
    Console.WriteLine();
}