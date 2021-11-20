using System;

namespace hw7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление квадратного корня числа");
            Console.Write("Введите число: ");
            double num = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Квадратный корень числа {num} равен {Math.Sqrt(num)}");

            Console.ReadLine();
        }
    }
}
