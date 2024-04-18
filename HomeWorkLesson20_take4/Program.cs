
Random random = new Random();
int[,] mas1=new int[4,4];
int[,] mas2 = new int[4, 4];


for (int i = 0; i < mas1.GetLength(0); i++)
{
    for (int j = 0; j < mas1.GetLength(1); j++)
    {
        mas1[i, j] = random.Next(1, 100) - 50;
    }
}
for (int i = 0;i < mas2.GetLength(0);i++)
{
    for (int j = 0; j < mas2.GetLength(1); j++)
    { 
        mas2[i, j] = random.Next(1, 100) - 50;
    }
}

Console.WriteLine("Первый массив");
PrintMatrix(mas1);
Console.WriteLine("Второй массив");
PrintMatrix(mas2);
Console.WriteLine("Сумма двух предыдущих");
PrintMatrix(SummMass(mas1, mas2));


void PrintMatrix(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write(mas[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] SummMass(int[,] array, int[,] array2)
{
    int[,] masSum = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            masSum[i, j] = array[i, j] + array2[i, j];
        }
    }
    return masSum;
}

int[,] array = SummMass(mas1, mas2);
int max = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] > max)
        {
            max = array[i, j];
        }
    }
}
Console.WriteLine(max);