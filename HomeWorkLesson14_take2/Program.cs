Console.Write("Укажите длинну пароля:");
int longPas = int.Parse(Console.ReadLine());
Random random = new Random();

string pass = "";
int pass0;
for (int i = 0; i < longPas; i++)
{
    pass0=random.Next(48,123);
    Console.Write((char)pass0);
}
//Console.WriteLine((int)'A');
//Console.WriteLine((int)'Z');
//Console.WriteLine((int)'a');
//Console.WriteLine((int)'z');
//Console.WriteLine((int)'0');
//Console.WriteLine((int)'1');