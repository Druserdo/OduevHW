PrintDirectiry(new DirectoryInfo(@"C:\Users\Mark\Desktop\Учеба\С#\project\OduewCW"), "", true);
void PrintDirectiry(DirectoryInfo directory, string indent, bool lastDirectory)
{
    Console.Write(indent);
    if (lastDirectory)
    {
        Console.Write("|--");
        indent += " ";
    }
    else
    {
        Console.Write("|--");
        indent += "| ";
    }
    Console.WriteLine(directory.Name);
    DirectoryInfo[] subDurrectories = directory.GetDirectories();
    for (int i = 0; i < subDurrectories.Length; i++)
    {

        PrintDirectiry(subDurrectories[i], indent, i == subDurrectories.Length - 1);

    }
}