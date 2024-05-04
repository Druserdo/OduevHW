////RandomClass rc = new RandomClass();
////Console.WriteLine(rc.intRand(100));

////class RandomClass
////{
////    private Random random;

////    public RandomClass()
////    {
////        random = new Random();
////    }
////    public int intRand(int n) => random.Next(n);

////    public double doubleRand(int n) => random.NextDouble()*n;
////    public bool boolRand() => (random.Next(0, 2) == 0) ? false : true;
////}
//using System.Text;
//Console.Write("Введите строку:");
//MyString myString= new MyString(Console.ReadLine()!);
//Console.WriteLine(myString.Rev());
//Console.WriteLine(myString.IsPolindrom());
//Console.WriteLine("Wwedite");
//char ch=char.Parse(Console.ReadLine());
//foreach (var item in myString.Split(ch))
//{
//    Console.WriteLine(item);
//}
//class MyString
//{
//    private string str;

//    public MyString(string str)
//    {
//        this.str = str;
//    }
//    public string Rev()
//    {
//        string res = "";
//        for (int i=str.Length-1;i >=0; i--) res += str[i];
//        return res;
//    }
//    public bool IsPolindrom() => (Rev() == str) ? true: false;
//    public string[] Split(char c)=>str.Split(c);
//    public string[] Split(string c)=> str.Split(c);
//    public string ToUpper() =>str.ToUpper(); 
//    public string ToLower()=> str.ToLower();
//    public string[] Split(int index)
//    {
//        if (index >= 0 && index <= str.Length - 1)
//        {
//            char c = str[index];
//            return str.Split(c);
//        }
//        else throw new Exception("Выход за границы строки!");
//    }
//    public bool Find(string word)
//    {
//        return str.Contains(word);
//    }
//}
using ClassLibrary1;
int[] mas1 = new int[10];
ArrayClass arrayClass=new ArrayClass(mas1);
