using System;

namespace AverageTemp
{
    class Program
    {
        public enum Months
        {
            Январь   = 1,
            Февраль  = 2,
            Март     = 3,
            Апрель   = 4,
            Май      = 5,
            Июнь     = 6,
            Июль     = 7,
            Август   = 8,
            Сентябрь = 9,
            Октябрь  = 10,
            Ноябрь   = 11,
            Декабрь  = 12
        };

        static void Main(string[] args)
        {
            Console.Write("Введите минимальную температуру за прошедшие сутки: ");
            float minTemp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальную температуру за прошедшие сутки: ");
            float maxTemp = Convert.ToInt32(Console.ReadLine());
            float avgTemp = (minTemp + maxTemp) / 2;
            Console.WriteLine($"Средняя температура за прошедшие сутки: {avgTemp}");

            Console.WriteLine();

            Console.Write("Введите номер месяца (от 1 до 12): ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы выбрали месяц {(Months)monthNumber}.");
            
            if((monthNumber == 1 || monthNumber == 2 || monthNumber == 12) && avgTemp > 0)
            {
                Console.WriteLine("Дождливая зима");
            }

            if (monthNumber % 2 == 0)
            {
                Console.WriteLine("Номер месяца, введённый пользователем, является чётным.");
            }
            else
            {
                Console.WriteLine("Номер месяца, введённый пользователем, является нечётным.");
            }

            Console.ReadLine();
        }
    }
}
