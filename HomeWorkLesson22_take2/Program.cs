try
{
    Console.Write("Введите список чисел разделенных пробелом:");
    string listNum = Console.ReadLine()!;
    int sum = 0;
    string[] masNum = listNum.Split(' ');
    int[] mas=new int[masNum.Length];
    for (int i = 0; i < masNum.Length; i++)
    {
        mas[i] = int.Parse(masNum[i]);
        sum += mas[i];
    }
    Console.WriteLine(sum);

}
 catch(FormatException e)//правильность формата ввода строки
{
    Console.WriteLine(e.Message);
}
catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}