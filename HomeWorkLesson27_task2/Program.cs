namespace HomeWorkLesson27_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal start = decimal.Parse(Console.ReadLine());
            decimal ball = decimal.Parse(Console.ReadLine());
            decimal num = decimal.Parse(Console.ReadLine());
        BankAccountcs ballans=new BankAccountcs(ball,start);
            ballans.Replenishment(num);
        }
    }
}
