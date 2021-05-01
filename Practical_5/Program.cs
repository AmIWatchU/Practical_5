using System;

namespace Ex_2
{
    class Program
    {
        // Завдання 2. Ступінчастий масив.
        //Створити двовимірний ступінчатий масив з N строк, кожна строка
        //містить на 2 елементи більше ніж попередня, перша строка
        //містить 1 елемент.Значення елементів масиву впорядкувати за
        //зростання починаючи з 1. Вивести на екран масив та суму
        //максимальних елементів кожного виміру.
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            int N = int.Parse(n);
            string[][] strArray = new string[N][];
            strArray[0] = new string[1];
            for (int i = 1; i < N; i++)
            {
                strArray[i] = new string[i*2+1];
                

            }
            Console.ReadKey();
        }        
    }
}
