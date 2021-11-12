using System;

namespace hw4p4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fibonachi (int n)
            {
                if(n == 0 || n == 1)
                {
                    return 1;
                }

                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }

            Console.WriteLine("Сколько элементов ряда Фибоначи необходимо вывести?");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{n} первых элементов ряда Фибоначи: ");
            
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                {
                    Console.Write(Fibonachi(i) + ", ");
                }
                else
                {
                    Console.Write(Fibonachi(i));
                }
                
            }
            
            Console.ReadLine();
        }
    }
}
