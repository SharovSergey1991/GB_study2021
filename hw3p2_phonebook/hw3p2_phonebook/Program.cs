using System;

namespace hw3p2_phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new string[5, 2] { {"Крючков Артём Михайлович", "+7 (914) 439 42 17, art21@gmail.com"},
                                               {"Карпова Анна Игоревна", "+7 (964) 728 64 20, abra6@mail.ru" },
                                               {"Сёмин Владислав Викторович", "+7 (924) 348 25 16"},
                                               {"Абрамова Татьяна Викторовна", "+7 (969) 654 28 71" },
                                               {"Королёв Максим Леонидович", "+7 (924) 438 52 41, MaxL@bk.ru"} };

            int rows = phonebook.GetUpperBound(0) + 1; // получаем количество строк массива.
            int columns = phonebook.GetUpperBound(1) + 1; // получаем количество столбцов массива.

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(phonebook[i, j]); // выводим элементы массива.
                    if (j != columns - 1)
                    {
                        Console.Write(", "); // если элемент не из поледнего столбца, то ставим запятую, пробел и оставляем курсор в той же строке.
                    }
                    else
                    {
                        Console.WriteLine(); // если элемент из последнего столбца массива, то переводим курсор на следуюдщую строку.
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
