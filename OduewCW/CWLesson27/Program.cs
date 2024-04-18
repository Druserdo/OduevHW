////File.WriteAllText("MyFile.txt","Привет мир");
////string[] lines =
////{
////    "Привет",
////    "Пока",
////    "Как дела",
////    "Цифра"
////};
////File.WriteAllLines(@"MyFileLines.txt", lines);
////string content = File.ReadAllText("MyFile.txt");
////Console.WriteLine(content);
////string[] content = File.ReadAllLines("MyFileLines.txt");
////for (int i = 0; i < content.Length; i++)
////{
////    Console.WriteLine(content[i]);
////}
////Directory.CreateDirectory
//string menu = "Выберете вариант:\n1.Создать файл\n2.Читать содержимое\n3.Удалить файл\n4.Создать папку\n5.Удалить папку";
//Console.WriteLine(menu);
//int choiceUser = int.Parse(Console.ReadLine());
//string nameFile;
//string pathName;
//string nameDir;
//string pathDir;

//switch (choiceUser)
//{
//    case 1:
//        Console.Write("Введите название файла:");
//        nameFile = Console.ReadLine();
//        Console.Write("Введите путь до файла:");
//        pathName = Console.ReadLine();
//        CreationFile(pathName,nameFile);
//        break;
//    case 2:
//        Console.Write("Введите путь до файла:");
//        pathName = Console.ReadLine();
//        readingFile(pathName);
//        break;
//    case 3:
//        Console.Write("Введите путь до удоляемого файла:");
//        pathName = Console.ReadLine();
//        dellFile(pathName);
//        break;
//    case 4:
//       Console.Write("Введите путь до папки:");
//        pathDir = Console.ReadLine();
//        CreationDir(pathDir);
//        break;
//    case 5:
//        Console.Write("Введите путь до папки:");
//        pathDir = Console.ReadLine();
//        dellDir(pathDir);
//        break;
//    default: Console.WriteLine("Нет такого варианта!"); break;
//}
//void CreationFile(string path,string nameFile)
//{
//    File.WriteAllText(nameFile + ".txt", "");
//}
//string readingFile(string path)
//{
//   string textinFile= File.ReadAllText(path);

//    return textinFile;
//}
//bool dellFile(string path)
//{
//   bool luck = true;
//        File.Delete(path);
//    return luck;
//}
//
//bool dellDir(string path)
//{
//    bool luckDir = true;
//    File.Delete(path);
//    return luckDir;
//}
Random random = new Random();
string pass()
{
    string aplphabet = "abcdefghigklmnoprtsuvwxyz";
    int lenght = 10;
    string result = "";
    do
    {
        for (int i = 0; i < lenght; i++)
        {
            result += aplphabet[random.Next(0, aplphabet.Length)];
        }
    }
    while (Directory.Exists(result));
   return result;
}
for (int i = 0; i <= 10; i++)
{
    string name = pass();
    if(name)
 Directory.CreateDirectory(name);
}
