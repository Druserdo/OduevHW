Console.WriteLine("Menu\n1.New Game\n2.Statistics\n3.Exit\n");
int choice =int.Parse(Console.ReadLine());
Random random = new Random();
string[,] mins=new string[10,10];
int count = 0;
int wins = 0;
int loss = 0;
int attempt = 0;
bool exit=true;
string statistics = $"Попыток:{attempt}\nВыиграно:{wins}\nПроигрышей:{loss}";
for (int i = 0; i < mins.GetLength(0); i++)
{
    Console.Clear();
    for (int j = 0; j < mins.GetLength(1); j++)
    {
        int probablity=random.Next(100);
        if (probablity <= 50)
        {
            if (count <= 9)
            {
                mins[i, j] = "*";
                count++;
            }
        }
        else mins[i, j] = "-";
    }
    Console.WriteLine();
}

switch (choice)
{
    case 1:
        {
            string[,] userMass = new string[10, 10];
            for (int i = 0; i < userMass.GetLength(0); i++)
            {
                for (int j = 0; j < userMass.GetLength(1); j++)
                {
                    userMass[i, j] = $"{i + 1},{j + 1} ";
                    Console.Write(userMass[i, j]);
                }
                Console.WriteLine();
            }
            do
            {
                Console.Write("Введите горизонталь:");
                int userHorizontal = int.Parse(Console.ReadLine());
                Console.Write("Введите вертикаль:");
                int userVertical = int.Parse(Console.ReadLine());
                if (mins[userHorizontal - 1, userHorizontal - 1] == userMass[userHorizontal - 1, userVertical - 1])
                {
                    Console.WriteLine("БАМ");
                    attempt++;
                    loss++;
                    exit = false;
                }
                else
                {
                    Console.Clear();
                    for (int i = 0; i < userMass.GetLength(0); i++)
                    {
                        for (int j = 0; j < userMass.GetLength(1); j++)
                        {
                            userMass[userHorizontal - 1, userVertical - 1] = "## ";
                            Console.Write(userMass[i, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
            while (exit);
                {
                Console.Write(statistics);
                }
                break;
        }
    case 2:
        Console.WriteLine(statistics); 
        break;
    case 3:
        break;
        
}