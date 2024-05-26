using System.Collections;
ArrayList list1=new ArrayList();
Console.WriteLine(list1.Count);
Console.WriteLine(list1.Capacity);
list1.Add("first");
Console.WriteLine(list1.Count);
Console.WriteLine(list1.Capacity);
list1.Add(1);
list1.Add(2.0);
list1.Insert(2, "Second");
for (int i = 0; i < list1.Count; i++)
{
    Console.Write(list1[i]+" ");
}
Console.WriteLine();
list1[3] = 5.1;
foreach (var i in list1)
{
    Console.Write(i+" ");
}
Console.WriteLine();
list1.Remove('1');
list1.RemoveAt(1);
