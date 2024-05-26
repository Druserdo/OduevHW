Main();
bool IsPalindrome(string word)
{
    int length = word.Length;
    for (int i = 0; i < length / 2; i++)
    {
        if (word[i] != word[length - i - 1])
        {
            return false;
        }
    }
    return true;
}

void Main()
{
    Console.Write("Введите слово:");
    string input = Console.ReadLine()!.ToLower();
    if (IsPalindrome(input))
    {
        Console.WriteLine("Is a palindrom");
    }
    else
    {
        Console.WriteLine("Not a palindrom");
    }
}