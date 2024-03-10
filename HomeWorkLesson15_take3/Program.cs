int[] mas = new int[10];
int n= 0;
for (int i = 0; i <10; i++)
{ Console.WriteLine($"Введите число {i+1}");
    n = int.Parse(Console.ReadLine());
    mas[i] = n;
}
Console.WriteLine();
Array.Sort(mas);
foreach (int i in mas) Console.Write(i+" ");
Console.WriteLine();
Console.Write("Введите число для поиска:");
int m=int.Parse(Console.ReadLine());
int l=Array.BinarySearch(mas, m);
if (l < 0) Console.WriteLine("Нет такого числа");
else Console.WriteLine(l);