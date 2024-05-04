using System.ComponentModel.Design;

namespace ClassLibrary1
{
    public class Class1
    {
        private object[] mas;

        public Class1()
        {
            this.mas = mas;
        }
        public void Fill(int low, int high)
        { 
            Random random = new Random();
         if (mas[0].GetType() ==typeof(int))
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i]=random.Next(low,high);
                }
            }
         else {
                if (mas[0].GetType() == typeof(double))
                {
                    for (int i = 0; i < mas.Length; i++)
                    {
                        mas[i] = random.NextDouble()*(low+high)-high;
                    }
                }
            }
        }
        public void Fill(int high)
        {
            Random random = new Random();
            if (mas[0].GetType() == typeof(int))
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    string res = String.Empty;
                    for (int j = 0; j < high; j++)
                    {
                        res += (char)random.Next(60, 127);
                        mas[i] = res;
                    }
                }
            }
            else if (mas[0].GetType() == typeof(bool))
            {
                for(int i = 0;i < mas.Length; i++)
                {
                    if (random.Next(0, 2) == 0) mas[i] = false;
                    else mas[i] = true;
                }
            }

        }
    }
}
