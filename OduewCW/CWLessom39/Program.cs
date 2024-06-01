using System.Diagnostics;

namespace Test_1_Bogdan
{
    class Program
    {
        public static int[] bubble;
        public static int[] selection;

        public static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            CreateRandomArr(100000);

            sw.Start();
            BubbleSort(bubble);
            sw.Stop();

            long timeBubbleSort = sw.ElapsedMilliseconds;

            sw.Start();
            SelectionSort(selection);
            sw.Stop();

            long timeSelectionSort = sw.ElapsedMilliseconds;

            Console.WriteLine("Время сортировки пузырьком: " + timeBubbleSort);
            Console.WriteLine("Время сортировки выбором: " + timeSelectionSort);
        }

        public static void BubbleSort(int[] array)
        {
            int arrLength = array.Length - 1;

            for (int i = 0; i < arrLength; i++) // Количество обходов массива
            {
                for (int j = 0; j < arrLength; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j]; // Сохраняем в промеж. переменную
                        array[j] = array[j + 1]; // Меняем местами
                        array[j + 1] = temp; // Устанавливаем число обратнов массив
                    }
                }
            }

            Console.WriteLine("Пузырек все");
        }

        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minNumberIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minNumberIndex])
                    {
                        minNumberIndex = j;
                    }
                }
                int temp = array[minNumberIndex];
                array[minNumberIndex] = array[i];
                array[i] = temp;
            }


            Console.WriteLine("Выбор все");
        }

        public static void CreateRandomArr(int length)
        {
            Random rnd = new Random();

            bubble = new int[length];
            selection = new int[length];

            for (int i = 0; i < length; i++)
            {
                int temp = rnd.Next(int.MinValue, int.MaxValue);
                bubble[i] = temp;
                selection[i] = temp;
            }

            Console.WriteLine("Данные сгенерированы");
        }
    }
}