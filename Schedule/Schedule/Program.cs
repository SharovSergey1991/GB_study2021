using System;

namespace Schedule
{
    class Program
    {
        [Flags]
        public enum Days
        {
            Понедельник    = 0b_0000001,
            Вторник        = 0b_0000010,
            Среда          = 0b_0000100,
            Четверг        = 0b_0001000,
            Пятница        = 0b_0010000,
            Суббота        = 0b_0100000,
            Воскресенье    = 0b_1000000
        }

        static void Main(string[] args)
        {
            Days scheduleOffice1 = Days.Понедельник | Days.Вторник | Days.Среда | Days.Четверг | Days.Пятница | Days.Суббота;
            Days scheduleOffice2 = Days.Вторник | Days.Среда | Days.Четверг | Days.Пятница | Days.Воскресенье;
            Days scheduleOffice3 = Days.Понедельник | Days.Среда | Days.Четверг | Days.Суббота | Days.Воскресенье;

            Console.WriteLine($"Рабочие дни центрального офиса: {scheduleOffice1}.");
            Console.WriteLine($"Рабочие дни дополнительного офиса на Енисейской: {scheduleOffice2}.");
            Console.WriteLine($"Рабочие дни дополнительного офиса на Астафьева: {scheduleOffice3}.");
            Console.ReadLine();
        }
    }
}
