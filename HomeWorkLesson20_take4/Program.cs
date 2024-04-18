Random random = new Random();
int[,] mas1 = new int[4, 3];
int[,] mas2 = new int[4, 3];
for (int i = 0; i < mas1.GetLength(0); i++)
{
    for (int j = 0; j < mas1.GetLength(1); j++)
    {
        mas1[i, j] = random.Next(-50, 51);
        Console.Write(mas1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < mas2.GetLength(0); i++)
{
    for (int j = 0; j < mas2.GetLength(1); j++)
    {
        mas2[i, j] = random.Next(-50, 51);
        Console.Write(mas2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] masSum = Sum(mas1, mas2);
for (int i = 0; i < masSum.GetLength(0); i++)
{
    for (int j = 0; j < masSum.GetLength(1); j++)
    {
        Console.Write(masSum[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Max=" + Max(masSum));
int[,] Sum(int[,] m1, int[,] m2)
{
    int[,] mas = new int[m1.GetLength(0), m1.GetLength(1)];
    for (int i = 0; i < m1.GetLength(0); i++)
    {
        for (int j = 0; j < m1.GetLength(1); j++)
        {
            mas[i, j] = m1[i, j] + m2[i, j];
        }
    }
    return mas;
}
int Max(int[,] mas)
{
    int max = mas[0, 0];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (mas[i, j] > max) max = mas[i, j];
        }
    }
    return max;
}