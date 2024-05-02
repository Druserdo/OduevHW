try
{
    Console.WriteLine("Введите путь к файлу:");
    string filePath = Console.ReadLine()!;
    Console.WriteLine("Введите текст для записи в файл:");
    string text = Console.ReadLine()!;
    File.WriteAllText(@filePath, text);
    Console.WriteLine("Файл успешно записан");
    File.WriteAllText("Файл2.txt", "Это содержимое файла 2");
    File.WriteAllText("Файл3.txt", "Это содержимое файла 3");
    string fileContents = File.ReadAllText(@filePath);
    Console.WriteLine("Содержимое файла " + Path.GetFileName(@filePath) + ":");
    Console.WriteLine(fileContents);
}
catch (Exception e)
{
    Console.WriteLine("Ошибка при чтении файла: " + e.Message);
}
    