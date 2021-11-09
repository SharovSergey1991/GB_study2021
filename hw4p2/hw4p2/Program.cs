using System;

namespace hw4p2
{
    class Program
    {
        static void Main(string[] args)
        {
            void Sum(string numbers)
            {
                var arrayNumbers = numbers.Split(' ');
                int sum = 0;
                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    sum += Int32.Parse(arrayNumbers[i]);
                }
                Console.WriteLine($"Сумма введённых чисел: {sum}");
            }

            Console.Write("Введите числа через пробел: ");
            string numbers = Console.ReadLine();

            Sum(numbers);

            Console.ReadLine();
        }
    }
}
