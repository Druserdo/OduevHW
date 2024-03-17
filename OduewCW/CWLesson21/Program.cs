//Console.Write("Введите строку:");
//string strUser=Console.ReadLine();
//Console.Write("Введите слово:");
//string strWord=Console.ReadLine();
//string result = "Результат:";
//if (strUser.Contains(strWord))  result +="Строка содержит слово.";
//else result += "Строка не содержит слово.";
//Console.WriteLine(result);

//Console.Write("Введите слово:");
//string word = Console.ReadLine();
//Console.Write("Введите символ:");
//char simvol = char.Parse(Console.ReadLine());
//Console.Write("Введите символ на который заменим:");
//char simvol2 = char.Parse(Console.ReadLine());
//word = word.Replace(simvol, simvol2);
//Console.WriteLine(word);

//Console.Write("Введите строку:");
//string strUser = Console.ReadLine();
//Console.Write("Введите слово для подсчета:");
//string strWord = Console.ReadLine();
//int count = 0;
//string[] mas = strUser.Split(" ");
//for (int i = 0; i < mas.Length; i++)
//{
//    if (mas[i].Contains(strWord))
//        count++;
//}
//Console.WriteLine(count);
// count = 0;
//int index = 0;
//while(strUser.IndexOf(strWord,index) != -1)
//{
//        count++;
//        index = strUser.IndexOf(strWord, index) + strWord.Length;
//}
//Console.WriteLine(count);

//Console.Write("Введите строку:");
//string strUser = Console.ReadLine();
//Console.Write("Введите слово для подсчета:");
//string strWord = Console.ReadLine();
//int index = 0;
//string replace = "";
//foreach (var item in strWord) replace += "*";

//    strUser=strUser.Replace(strWord, replace);

//Console.WriteLine(strUser);

Console.Write("Введите строку:");
string strUser = Console.ReadLine();
string[] mas = strUser.Split(" ");
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i].Contains(',')) Console.WriteLine(double.Parse(mas[i]).GetType());
    else Console.WriteLine(int.Parse(mas[i]).GetType());
}