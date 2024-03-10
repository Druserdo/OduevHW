int[] mas1 = new int[2];
int[] mas2 = new int[2];
int[] mas3 = new int[2];
int[] mas4 = new int[2];
Random rand = new Random();
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = rand.Next(10,100);
}
for (int i = 0;i < mas2.Length; i++)
{
    mas2[i] = rand.Next(10,100);
}
for (int i = 0; i<mas3.Length; i++)
{
    mas3[i] = rand.Next(10,100);
}
for (int i = 0; i < mas4.Length; i++)
{
    mas4[i] = rand.Next(10, 100);
}
double[] mas5 = new double[2];
for (int i = 0;i<mas5.Length;i++)
{
    mas5[i] = (mas1[i] + mas2[i]) / 2.0;
}
double[] mas6= new double[2];
for (int i = 0; i < mas6.Length; i++)
{
    mas6[i] = (mas3[i] + mas4[i]) / 2.0;
}
foreach (double item in mas5) Console.Write(item+" ");
Console.WriteLine();
foreach (double item in mas6) Console.Write(item + " ");
double proiz = 0;
Console.WriteLine();
for (int i = 0;i< mas5.Length;i++)
{
    proiz = mas5[i]*mas6[i];
    Console.Write($"{proiz:F2} ");
}
