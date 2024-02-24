//Random random = new Random();
//int n;
//do
//{
//    n = random.Next(1, 11);
//    Console.Write(n + " ");
//}
//while (n != 7);

int num;
int sum = 0;
do
{
    Console.Write("Введите число:");
    num = int.Parse(Console.ReadLine());
    sum += num;
}
while (num !=0 );
Console.Write(sum);