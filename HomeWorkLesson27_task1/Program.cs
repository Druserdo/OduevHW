namespace HomeWorkLesson27_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("укажите количество рублей:");
            decimal count = decimal.Parse(Console.ReadLine());
            decimal dollars = RubleConverter.ToDollars(count);
            Console.WriteLine($"В долларах = {dollars.ToString()}");
            decimal euro = RubleConverter.ToEuros(count);
            Console.WriteLine($"В евро = {euro.ToString()}");
            decimal zlot = RubleConverter.ToZlotys(count);
            Console.WriteLine($"В злотых = {zlot.ToString()}");
            decimal yoant = RubleConverter.ToYuan(count);
            Console.WriteLine($"В юанях = {yoant.ToString()}");
            decimal rupes = RubleConverter.ToRupes(count);
            Console.WriteLine($"В рупиях = {rupes.ToString()}");
        }
    }
    class RubleConverter
    {

        public static decimal ToDollars(decimal rubles)
        {
            return rubles * 91.60m;
        }
        public static decimal ToEuros(decimal rubles)
        {
            return rubles * 98.68m;
        }
        public static decimal ToZlotys(decimal rubles)
        {
            return rubles * 22.76m;
        }
        public static decimal ToYuan(decimal rubles)
        {
            return rubles * 12.93m;
        }
        public static decimal ToRupes(decimal rubles)
        {
            return rubles * 1.10m;
        }
    }

}
