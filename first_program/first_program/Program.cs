using System;

namespace first_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            String username = Console.ReadLine();
            Console.WriteLine($"Привет, {username}! Сегодня {DateTime.Today.ToString("d")}");
            Console.ReadLine();
        }
    }
}
