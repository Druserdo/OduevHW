
class Numbers
{
    public void CalculateAverage(int[] mas)
    {
        int avg;
        int sum = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            sum += mas[i];
        }
        avg = sum / mas.Length;
    }
    public bool IsPrime(int num)
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
    public bool IsEven(int num)
    {
        bool res;
        if (num % 2 == 0)
        {
            return res = true;
        }
        else return res = false;
    }
    public bool IsOdd(int num)
    {
        bool res;
        if (num % 2 == 0)
        {
            return res = false;
        }
        else return res = true;
    }

}
