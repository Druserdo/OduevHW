string directoryPath = @"C:\Users\Mark\Desktop\Учеба\С#\project\HomeWorkLesson21_take3-4\obj\Debug\net8.0";
GetDir(directoryPath);
Console.Write("Введите папку для перехода:");
string namDir=Console.ReadLine();
Console.WriteLine($"{directoryPath}\\{namDir}");
void GetDir(string directoryPath)
{
    
    DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
    Console.WriteLine("Текущая дирректория: " + directoryInfo.FullName);
}
