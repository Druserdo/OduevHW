int[] mas = new int[10];
Random random = new Random();
int ewenNumbers = 0;
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10,100);
}
for (int i = 0;i < mas.Length; i++)
{
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
for (int i = 0; i<mas.Length; i++)
{
    if (mas[i]%2== 0)
    ewenNumbers++;
}
Console.WriteLine($"Четных чиел в массиве {ewenNumbers}");