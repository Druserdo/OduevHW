using System;
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);

 
class Numbers
{
   public int CalculateAverage;
    public bool IsPrime;
    public bool IsEven;
    public bool IsOdd;

    public Numbers(int calculateAverage, bool isPrime, bool isEven, bool isOdd)
    {
        CalculateAverage = calculateAverage;
        IsPrime = isPrime;
        IsEven = isEven;
        IsOdd = isOdd;
       int calculateAverage(int[] mas)
        {
            int avg = 0;
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            avg = sum / mas.Length;
            return avg;
        }
       bool IsPrime( int num)
        {
            int count = 0;
            bool res;
            for (int i = 1; i < num; i++)
            {
                if (num % i != 0) count++;
            }
            if (count == 0) return res = true;
            else return res = false;
        }
         bool IsEven(int num)
        {
            bool res;
            if (num % 2 == 0)
            {
                return res = true;
            }
            else return res = false;
        }
        bool IsOdd(int num)
        {
            bool res;
            if (num % 2 == 0)
            {
                return res = false;
            }
            else return res = true;
        }
    }
}
