using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Buble sorting
            Console.WriteLine("Сортування бульбашкою: ");

            int[] arrayInt = { 13, 41, 94, 5, 12, 54, 66, 41, 95};           
            for (int i = 0; i < arrayInt.Length-1; i++)
            {
                for (int j = i+1; j < arrayInt.Length; j++)
                {
                    if (arrayInt[i] > arrayInt[j])
                    {
                        int tmp = arrayInt[i];
                        arrayInt[i] = arrayInt[j];
                        arrayInt[j] = tmp;
                    }
                }
            }
            foreach (int a in arrayInt)
            {
                Console.Write($"{a} ");
            }


            //Parse sorting
            Console.WriteLine("\n Сортування вставкою: ");
            // int[] arrayInt = { 13, 41, 94, 5, 12, 54, 66, 41, 95};
            int min;
            int minI;            
            for (int i = 0; i < arrayInt.Length-1; i++)
            {
                min = arrayInt[i];
                minI = i;
                for (int j = i+1; j < arrayInt.Length; j++)
                {
                    if (min > arrayInt[j])
                    {
                        minI = j;
                        min = arrayInt[j];
                    }
                }
                arrayInt[minI] = arrayInt[i];
                arrayInt[i] = min;
            }

            foreach (int a in arrayInt)
            {
                Console.Write($"{a} ");
            }

            // Array.Sort();
            Console.WriteLine("\n Сортування методом Array.Sort(): ");
            // int[] arrayInt = { 13, 41, 94, 5, 12, 54, 66, 41, 95};

            Array.Sort(arrayInt);
            foreach (int a in arrayInt)
            {
                Console.Write($"{a} ");
            }
            
            //Сортування string
            string[] arrayStr = { "apple", "welcome", "gnome", "member", "spring", "book" };
            Console.WriteLine("\n Сортування string методом Array.Sort(): ");
            Array.Sort(arrayStr);
            foreach (string a in arrayStr)
            {
                Console.Write($"{a} ");
            }
            //Інверування string
            Console.WriteLine("\n Iнвертування string методом Array.Reverse(): ");
            Array.Reverse(arrayStr);
            foreach (string a in arrayStr)
            {
                Console.Write($"{a} ");
            }

            Console.ReadKey();
        }        
    }
}
