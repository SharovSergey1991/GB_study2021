using System;

namespace hw3p4_warships
{
    class Program
    {
        static void Main(string[] args)
        {
            var warshipsField = new char[10,10];
            var rand = new Random(); // инициализация генератора случайных чисел
                                     // с его помощью будет определяться позиция корабля на поле боя

            for (int i = 0; i < 10; i++)
            {
                int  ship = rand.Next(0, 11); // с помощью генератора случайных чисел определяем, где будет располагаться корабль.
                                              // генерируем числа от 0 до 10.
                                              // таким образом в каждой строке может быть либо один корабль, либо не быть кораблей вообще.
                for (int j = 0; j < 10; j++)
                {
                    if (j == ship)
                    {
                        warshipsField[i, j] = 'X';
                    }
                    else
                    {
                        warshipsField[i, j] = 'O';
                    }
                    
                    if (j == 9)
                    {
                        Console.WriteLine(warshipsField[i, j]);
                    }
                    else
                    {
                        Console.Write(warshipsField[i, j]);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
