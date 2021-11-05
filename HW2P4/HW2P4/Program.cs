using System;

namespace HW2P4
{
    class Program
    {
        static void Main(string[] args)
        {
            float suitNumber = 1;
            float suitPrice = 16597;
            float suitSum = suitNumber * suitPrice;

            float tieNumber = 2;
            float tiePrice = 499;
            float tieSum = tieNumber * tiePrice;

            float sum = suitSum + tieSum;

            string shopName = "Калина Молл";
            string address = "Приморский край, 690035, г. Владивосток, ул. Калинина, д. 8, пав2-25";
            string date = "25.05.21";

            Console.WriteLine("                КАССОВЫЙ ЧЕК                ");
            Console.WriteLine("ПРИХОД");
            Console.WriteLine("КОСТЮМ (48.176 черный)");
            Console.WriteLine($"01                  {suitNumber:0.00} * {suitPrice:0.00} ={suitSum:0.00}");
            Console.WriteLine(" ТОВАР");
            Console.WriteLine(" ПОЛНЫЙ РАСЧЕТ");
            Console.WriteLine("ГАЛСТУК (пустой, черный");
            Console.WriteLine($"01                  {tieNumber:0.00} * {tiePrice:0.00} ={tieSum:0.00}");
            Console.WriteLine(" ТОВАР");
            Console.WriteLine(" ПОЛНЫЙ РАСЧЕТ");
            Console.WriteLine($"ИТОГ                               ={sum:0.00}");
            Console.WriteLine($"Место расчетов                     {shopName}");
            Console.WriteLine($"Адрес                              {address}");
            Console.WriteLine($"Дата                               {date}");
            Console.ReadLine();
        }
    }
}
