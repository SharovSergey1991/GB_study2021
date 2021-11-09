using System;

namespace HW3P1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[6, 6] { {10, 76, 19, 23, 14, 41}, 
                                        {61, 20, 10, 58, 2, 36}, 
                                        {41, 23, 30, 36, 85, 14}, 
                                        {21, 56, 42, 40, 56, 3}, 
                                        {10, 20, 30, 40, 50, 62}, 
                                        {71, 36, 54, 48, 84, 60} };

            int rows = array.GetUpperBound(0) + 1; // получаем количество строк массива
            int columns = array.GetUpperBound(1) + 1; // получаем количество столбцов массива

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(array[i, j]); // выводим диагональные элементы матрицы.
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
