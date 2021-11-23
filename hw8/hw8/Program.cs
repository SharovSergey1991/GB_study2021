using System;
using hw8.Properties;
using System.Text.Json;
using System.IO;
using System.Threading;

namespace hw8
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo userinfo = new UserInfo();

            Console.WriteLine(Resources.Greeting);
            Console.WriteLine();

            if (!File.Exists("userinfo.json"))
            {
                Console.WriteLine("На данный момент мы о вас ничего не знаем. Введите, пожалуйста, информацию о себе.");
                Console.WriteLine();

                Console.Write("Ваше имя: ");
                userinfo.Name = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Ваш возраст: ");
                userinfo.Age = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Ваша профессия: ");
                userinfo.Profession = Console.ReadLine();
                Console.WriteLine();

                string json = JsonSerializer.Serialize(userinfo);
                File.WriteAllText("userinfo.json", json);

                Console.WriteLine($"Информация о вас успешно записана. До встречи {userinfo.Name}.");
                Thread.Sleep(3000);
            }
            else
            {
                string json = File.ReadAllText("userinfo.json");
                userinfo = JsonSerializer.Deserialize<UserInfo>(json);

                Console.WriteLine("Вот, что нам о вас известно:");
                Console.WriteLine();

                Console.Write($"Ваше имя: {userinfo.Name}");
                Console.WriteLine();

                Console.Write($"Ваш возраст: {userinfo.Age}");
                Console.WriteLine();

                Console.Write($"Ваша профессия: {userinfo.Profession}");
                Console.WriteLine();

                Console.ReadLine();
            }           
        }
    }
}
