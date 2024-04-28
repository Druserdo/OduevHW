////Person person1=new Person();
////Console.WriteLine(person1);
////class Person
////{
////    private string FIO;
////    private int age;
////    private double rost;
////    private double weght;
////    public string getFIO()
////    {
////        return FIO;
////    }
////    public void setFIO(string fio)
////    { 
////        FIO = fio; 
////    }
////}

//Console.Write("Введите Х:");
//double num1,num2;
//double.TryParse(Console.ReadLine(), out num1);
//Console.Write("Введите у:");
//double.TryParse(Console.ReadLine(), out num2);
//Calculate calc=new Calculate(num1,num2);
//Console.WriteLine(calc.Add());
//Console.WriteLine(calc.Division());
//Console.WriteLine(calc.Multiplication());
//Console.WriteLine(calc.Sub());
//class Calculate
//{
//    private double Num1;
//    private double Num2;

//    public Calculate(double num1,double num2)
//    {
//        Num1=num1;
//        Num2 =num2;
//    }

//    public double Add()
//    {
//        return Num1+Num2;
//    }
//    public double Sub()
//    { 
//        return Num1 - Num2; 
//    }
//   public double Multiplication()
//    {
//        return Num1 * Num2;
//    }
//    public double Division()
//    {
//        return Num1 / Num2;
//    }

//}
//Console.WriteLine("ВВедите строку");
//string str=Console.ReadLine();

//StringAnalizer analiz=new StringAnalizer(str);
//Console.WriteLine(analiz.GetLength);

//class StringAnalizer
//{
//    private string Stroka;

//    public StringAnalizer(string stroka)
//    {
//        Stroka = stroka;
//    }
//    public int GetLength()
//    { 
//        return Stroka.Length; 
//    }
//    public bool SubStr(string substr)
//    {
//        return Stroka.Contains(substr);
//    }
//    public void OurToUpper()
//    {
//        Stroka = Stroka.ToUpper();
//    }
//    public void OurToLower()
//    {
//        Stroka = Stroka.ToLower();
//    }
//}
//Random random = new Random();
//int[] mas= new int[random.Next(10,20)];
//mas=mas.Select(i => i+random.Next(1,100)).ToArray();
//Arrays arrays= new Arrays(mas);
//arrays.Print();
//Console.WriteLine(arrays.Max);
//class Arrays
//{
//    private int[] mas;

//    public Arrays(int[] mas)
//    {
//        mas = mas;
//    }
//    public int Sum()
//    {
//        return mas.Sum();
//    }
//    public int Max()
//    {
//        return mas.Max(); 
//    }
//    public int Min()
//    {
//        return mas.Min();
//    }
//    public void Sort()
//    {
//        Array.Sort(mas);
//    }
//    public void Print()
//    {
//        foreach(int i in mas) Console.Write(i+" ");
//        Console.WriteLine();
//    }
//}
using System.Text;

class FileManager
{
    private string fileName;

    public FileManager(string f)
    {
       fileName = f;
    }
    public bool Exists()
    {
        FileInfo fi = new FileInfo(fileName);
    return fi.Exists;
    }
    public async void Write(string text)
    {
        FileInfo fi = new FileInfo(fileName);
        if (fi.Exists) 
        {
            using (FileStream fs=fi.OpenWrite());
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                await fs.Write

            }
        }
    }
}