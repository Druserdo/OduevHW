
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
    public int CalculateFactorial(int num)
    {
        int fact = 1;
        for (int i = 0; i < num; i++)
        {
            fact = fact * (i + 1);
        }
        return fact;
    }
    public string ConvertToBinary(int num)
    {
        if (num == 0)
        {
            return "0";
        }

        string result = "";
        while (num > 0)
        {
            int remainder = num % 2;
            result = remainder + result;
            num = num / 2;
        }
        return result;
    }
    public string ConvertToHex(int num)
    {
        string numOx = "0123456789ABCDEF";
        if (num == 0)
        {
            return "0";
        }
        string result = "";
        while (num > 0)
        {
            int remainder = num % 16;
            result = numOx[remainder] + result;
            num = num / 16;
        }
        return result;
    }
    public int CalculatePower(int num, int exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }
        else if (exponent > 0)
        {
            for (int i = 1; i <= exponent; i++)
            {
                num *= num;
            }
            return num;
        }
        else
        {
            return 1 / CalculatePower(num, -exponent);
        }
    }
}
