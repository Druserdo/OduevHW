Random random = new Random();
int n = random.Next(1, 6);
int[,] mas = new int[3,n];
double sumAll = 0;

for (int i = 0; i < mas.GetUpperBound(0) + 1; i++)
{
    int summ = 0;
    for (int j = 0; j < mas.GetUpperBound(1) + 1; j++)
    {
        mas[i, j] = random.Next(1, 10);
        Console.Write(mas[i, j] + " ");
        summ += mas[i, j];
    }
    sumAll += summ;
    Console.WriteLine();
    Console.WriteLine(summ+" ");
}
double awg=sumAll/(mas.GetLength(0)*mas.GetLength(1));
Console.Write($"Среднее арифметическое ={awg:F2}") ;