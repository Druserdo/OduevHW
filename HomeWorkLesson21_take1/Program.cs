Console.Write("Введите путь к папке:");
string path=Console.ReadLine();
Console.Write("Введите текст для записи:");
string content=Console.ReadLine();

File.WriteAllText(path, content);
if (File.Exists(@path))
    Console.WriteLine("Файл успешно записан!");
else Console.WriteLine("Попробуйте еще раз!");
File.WriteAllText(path, content);

FileInfo fileInf = new FileInfo(path);
Console.Write("Введите новый путь:");
string newPath=Console.ReadLine();
if (fileInf.Exists)
{
    fileInf.CopyTo(newPath, true);
}