using System;

namespace hw4p3
{
    class Program
    {
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        static void Main(string[] args)
        {
            int month;
            Console.Write("Введите номер месяца: ");
            month = Int32.Parse(Console.ReadLine());

            do
            {                
                if (month >= 1 && month <= 12)
                {
                    switch (month)
                    {
                        case 12:
                        case 1:
                        case 2:
                            Console.WriteLine(Season.Winter);
                            break;
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine(Season.Spring);
                            break;
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine(Season.Summer);
                            break;
                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine(Season.Autumn);
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12:");
                    month = Int32.Parse(Console.ReadLine());
                }
            } while (true);

            Console.ReadLine();
        }
    }
}
