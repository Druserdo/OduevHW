Random random = new Random();
char[] rabbits = new char[random.Next(10, 20)];
int[,] rabbitGeo = new int[rabbits.Length, 2];
for (int i = 0; i < rabbitGeo.GetLength(0); i++)
{
    int k = random.Next(20);
    int m = random.Next(20);
    rabbitGeo[i, 0] = k;
    rabbitGeo[i, 1] = m;
}
char[] wolfs = new char[random.Next(5) + 2];
char[] female = new char[random.Next(5) + 2];
char[,] square = new char[20, 20];
int rCount = rabbits.Length;
int wCount = wolfs.Length;
int fCount = female.Length;
bool play = true;
do
{
    Console.Clear();
    for (int i = 0; i < square.GetLength(0); i++)
    {
        for (int j = 0; j < square.GetLength(1); j++)
        {
            square[i, j] = '.';
        }
    }
    for (int i = 0; i < rabbits.Length; i++)
    {
        int k;
        do
        {
            k = rabbitGeo[i, 0] + random.Next(-8, 8);
        }
        while (k < 0 || k > 19);

        int m;
        do
        {
            m = rabbitGeo[i, 1] + random.Next(-8, 8);
        }
        while (m < 0 && m > 19);
        square[k, m] = 'R';
        rabbitGeo[i, 0] = k;
        rabbitGeo[i, 1] = m;
        int probadly = (int)(random.NextDouble() * 100);
        if (probadly == 20)
        {
            rabbitGeo = new int[rabbits.Length, 2];
            Array.Resize(ref rabbits, rabbits.Length + 1);
        }
    }
    for (int i = 0; i < wolfs.Length; i++)
    {
        int k = random.Next(20);
        int m = random.Next(20);
        if (square[k, m] == 'R')
        {
            Array.Resize(ref rabbits, rabbits.Length - 1);
        }
        square[m, k] = 'W';
    }

    for (int i = 0; i < female.Length; i++)
{
    int k = random.Next(20);
    int m = random.Next(20);
    if (square[k, m] == 'R')
    {
        Array.Resize(ref rabbits, rabbits.Length - 1);
    }
        if (square[k, m] == 'W')
        {
            int probadly1 = (int)(random.NextDouble() * 50);
            if(probadly1>=50)
            {
                Array.Resize(ref wolfs, wolfs.Length + 1);
            }
            else Array.Resize(ref female, female.Length +1);
        }
    square[m, k] = 'F';
}
for (int i = 0; i < square.GetLength(0); i++)
    {
        for (int j = 0; j < square.GetLength(1); j++)
        {
            if (square[i, j] != 'R' && square[i,j]!='W' && square[i,j]!='F') square[i, j] = '.';
            Console.Write(square[i, j]);
        }
        Console.WriteLine();
    }
    Thread.Sleep(800);
}
}
while (play);

