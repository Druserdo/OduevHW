Console.Write("Введите путь:");
string path=Console.ReadLine()!;
FileInfo fileInfo = new FileInfo(@path);

    Console.WriteLine($"Имя файла: {fileInfo.Name}");
    Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
    Console.WriteLine($"Размер: {fileInfo.Length}");
