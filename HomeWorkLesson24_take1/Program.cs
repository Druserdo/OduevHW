Console.WriteLine("Введите слово:");
string word = Console.ReadLine()!.ToLower();

if (IsPalindrome(word, 0, word.Length - 1))
{
    Console.WriteLine("Is a palindrom");
}
else
{
    Console.WriteLine("Not a palindrom");
}

bool IsPalindrome(string word, int start, int end)
{
    if (start >= end)
    {
        return true;
    }
    if (word[start] != word[end])
    {
        return false;
    }
    return IsPalindrome(word, start + 1, end - 1);
}