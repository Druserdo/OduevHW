int[] mas1 = { 1, 11, 23, 4 };

foreach (int i in mas1) Console.Write(i+" ");
int awgMas(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        sum += mas[i];

    }
    int sumAvg = sum/mas.Length;
    return sumAvg;
}
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое массива равно:{awgMas(mas1)}");