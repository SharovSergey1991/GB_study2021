using System;
using System.IO;

namespace hw5p3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите через пробел любые числа в диапазоне от 0 до 255: ");

            string numbers = Console.ReadLine();
            string[] arrNumbers = numbers.Split();
            var arrBytes = new byte[arrNumbers.Length];

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                arrBytes[i] = Convert.ToByte(arrNumbers[i]);
            }

            File.WriteAllBytes("binary.bin", arrBytes);
        }
    }
}
