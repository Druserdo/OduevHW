using System;
using System.IO;
Console.Write("Введите название папки для создания:");
string nameDir=Console.ReadLine();
Directory.CreateDirectory(nameDir);
string directoryPath = @"C:\Users\Mark\Desktop\Учеба\С#\project\HomeWorkLesson21_take3-4\obj\Debug\net8.0";
Console.WriteLine(GetDir(directoryPath));
Console.Write("Введите папку для перехода:");
string namDir1 = Console.ReadLine();
string directoryPath1 = $"{directoryPath}\\{namDir1}";
Console.WriteLine(GetDir(directoryPath1));
string GetDir(string dirPath)
{

    DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);
    string currentDir = "Текущая дирректория: " + directoryInfo.FullName;
    return currentDir;
}
Console.Write("Введите имя папки для удаления:");
string dirDell = Console.ReadLine();
string dellPath = $"{directoryPath}\\{dirDell}";
if (Directory.Exists(dellPath)==true)
{
    Console.Write($"Вы хотите удалить папку {dirDell}?\nнажмите 1:");
    byte n=byte.Parse( Console.ReadLine());
    if (n == 1) Directory.Delete(dellPath);
}



