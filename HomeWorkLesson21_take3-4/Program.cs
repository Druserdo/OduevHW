string directoryPath = @"C:\Users\Mark\Desktop\Учеба\С#\project\HomeWorkLesson21_take3-4\obj\Debug\net8.0";
Console.WriteLine(GetDir(directoryPath));
Console.Write("Введите папку для перехода:");
string namDir=Console.ReadLine();
directoryPath += $"\\{namDir}";
Console.WriteLine(GetDir(directoryPath));
string GetDir(string dirPath)
{
    
    DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);
   string currentDir="Текущая дирректория: " + directoryInfo.FullName;
    return currentDir;
}
