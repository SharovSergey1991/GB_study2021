using System;

namespace hw4p1
{
    class Program
    {
        static void Main(string[] args)
        {
            void GetFullName(string lastName, string firstName, string patronymic)
            {
                Console.WriteLine($"{lastName} {firstName} {patronymic}");
            }

            var lastNames = new string[4] { "Карнавальный", "Артериальный", "Малахова", "Опронова" };
            var firstNames = new string[4] { "Артур", "Архаил", "Мария", "Елизавета" };
            var ar_patronymic = new string[4] { "Терионович", "Арилович", "Ричардовна", "Рафаиловна" };

            for (int i = 0; i < 4; i++)
            {
                GetFullName(lastNames[i], firstNames[i], ar_patronymic[i]);
            }

            Console.WriteLine();

            Console.WriteLine("А теперь введите данные о себе:");
            Console.Write("Ваша фамилия: ");
            var lName = Console.ReadLine();
            Console.Write("Ваше имя: ");
            var fName = Console.ReadLine();
            Console.Write("Ваше отчество: ");
            var patr = Console.ReadLine();

            GetFullName(lName, fName, patr);

            Console.ReadLine();
        }
    }
}
