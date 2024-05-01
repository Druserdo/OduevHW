Console.Write("Введите число:");
int userNum=int.Parse(Console.ReadLine()!);
OddNumberOutput(userNum);

void OddNumberOutput(int num)
{
    if (num > 1)
    {
        if (num % 2 == 0)
        {
            OddNumberOutput(num - 2);
            Console.Write((num - 1) + " ");
        }
        else OddNumberOutput(num - 1);
    }
}


