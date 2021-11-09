using System;

namespace hw3p3_stringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любую строку: ");
            string str = Console.ReadLine();
            int length = str.Length;

            int i = length - 1; // записываем в переменную i индекс последнего элемента строки

            while (i >= 0)
            {
                Console.Write(str[i]); //выводим на экран элементы строки в обратном порядке
                i--;
            }
                        
            Console.ReadLine();
        }
    }
}
