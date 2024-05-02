try
{
    Console.Write("Введите путь к файлу:");
    string filePath = Console.ReadLine()!;
    if (File.Exists(filePath))
    {
        Console.WriteLine($"Файл {filePath} существует.");
        FileInfo fileInfo = new FileInfo(filePath);
        Console.WriteLine($"Размер файла: {fileInfo.Length} байт");
        Console.WriteLine($"Дата последнего изменения: {fileInfo.LastWriteTime}");
        Console.WriteLine($"Расширение файла: {fileInfo.Extension}");

    }
    else
    {
        Console.WriteLine($"Файла {filePath} не существует.");
    }
} catch ( Exception e ) 
{
    Console.WriteLine("Не правильный ввод!");
}

    
