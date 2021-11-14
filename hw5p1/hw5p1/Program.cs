using System;
using System.IO;

namespace hw5p1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный текст");
            string text = Console.ReadLine();
            File.WriteAllText("text.txt", text);
        }
    }
}
