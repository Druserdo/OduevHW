int[] mas=new int[5];
Console.WriteLine(mas.Length);//длинна масива
Console.WriteLine(mas.Rank);//размерность
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10);
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
Console.WriteLine(mas[2]);
Console.WriteLine(mas.GetValue(2));//свойство узнать знаение
mas[3] = 6;
mas.SetValue(6, 3);//свойство поменять значение
Console.WriteLine(mas[3]);
//copy
int[] mas2 = { 3, 2, 1, 7, 2, 8 };
int[] mas3=new int[8];
mas2.CopyTo(mas3,2);
foreach (int i in mas3)
{
    Console.Write(i+" ");
}
Console.WriteLine();
//Сортировка
Array.Sort(mas3);
foreach (int item in mas3)
{
    Console.Write(item+" ");
}
Console.WriteLine();
//reverse
Array.Reverse(mas3);
foreach (int item in mas3)
{
    Console.Write(item + " ");
}
Console.WriteLine();
//индекс
Console.WriteLine(Array.IndexOf(mas2,2));//с начала 
Console.WriteLine(Array.LastIndexOf(mas2,2));// с конца
Console.WriteLine(Array.BinarySearch(mas3,7));// ищет в отсортированном массиве
//Обьединение Concat
int[]sumMas=mas.Concat(mas2).ToArray();
foreach (int item in sumMas)
{
    Console.Write(item+" ");
}
Console.WriteLine();
//Clear()  Очистка
Array.Clear(sumMas);
Console.WriteLine();
//Resize изменение размера массива
Array.Resize(ref mas2, 8);
foreach (int item in mas2)
{
    Console.Write(item + " ");
}
Console.WriteLine();