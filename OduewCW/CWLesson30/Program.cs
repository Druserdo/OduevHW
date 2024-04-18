//int number = 10;
//int min = 0;
//reducer(min, number);
//void reducer(int min,int max)
//{
//    Console.Write(min + ",");
//    min++;
//    if (min > max)
//    {
//        return;
//    }
//    reducer(min, number);
//}
//string alphabet = "abcdefghijklmnopqrstuvwxyz";
//int leng = alphabet.Length;
//Print(alphabet, 0);
//void Print(string text,int index)
//{
//    Console.Write(text[index] + " ");
//    index++;
//    if (index == text.Length)
//    {
//        return;
//    }
//    Print(text,index);
//}
Degree(4, 5);

void Degree(int numm,int power,int res = 1)
{
    res *= numm;
    power--;
    if (power == 0)
    {
        Console.WriteLine(res);
        return;
    }
    Degree(numm, power, res);
}