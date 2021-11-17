using System;
using System.Diagnostics;
using System.Threading;

namespace hw6
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = string.Empty; // переменная для записи действия пользователя (будем спрашивать пользователя, что он хочет сделать: убить процесс или выйти из приложения
            string param = string.Empty; // здесь будем хранить вариант завершения процесса: по имени или по id
            string procName = string.Empty; // переменная для хранения имени процесса
            string procID = string.Empty; // переменная для хранения id процесса

            do
            {
                Process[] processes = Process.GetProcesses(); // получаем список всех запущенных процессов

                Console.WriteLine("            Имя процесса              Id процесса     "); 
                Console.WriteLine("===============================   ====================");
                int y = Console.CursorTop; // запоминаем координату курсора по вертикали

                foreach (var proc in processes) // выводим на экран список процессов с из id
                {
                    Console.Write(proc.ProcessName);
                    Console.SetCursorPosition(40, y);
                    y++;
                    Console.WriteLine(proc.Id);
                }

                Console.WriteLine();

                Console.WriteLine("Введите команду 'kill', чтобы завершить процесс, или команду 'exit', чтобы выйти из программы:");
                action = Console.ReadLine(); // спрашиваем пользователя, что он хочет сделать: завершить процесс или выйти из приложения

                if (action == "kill") // если хочет завершить процесс...
                {
                    Console.WriteLine("Введите команду 'name', если хотите завершить процес по его имени, или команду 'id', чтобы завершить процесс по его идентификационному номеру:");
                    param = Console.ReadLine(); // ... спрашиваем, каким образом: по имени или по id
                    switch (param)
                    {
                        case "name": //если по имени, 
                            Console.Write("Введите имя процесса: "); // то просим ввести имя процесса
                            procName = Console.ReadLine();

                            try
                            {
                                foreach (var proc in Process.GetProcessesByName(procName))
                                {
                                    proc.Kill(); // пробуем завершить выбранные процессы
                                    proc.WaitForExit();
                                };
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;

                        case "id": // если по id, 
                            Console.Write("Введите id процесса: "); // то просим ввести id
                            procID = Console.ReadLine();
                            try
                            {
                                var proc = Process.GetProcessById(Int32.Parse(procID));
                                proc.Kill(); // пробуем завершить выбранные процессы
                                proc.WaitForExit();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                    }
                }
                else if (action == "exit") // если пользователь хочет выйти из приложения, то ...
                {
                    Console.WriteLine("Программа завершена"); // ... говорим ему, что программа завершена
                    break;
                }
                else
                {
                    Console.WriteLine("Введена неверная команда!"); // если пользователь ввел, что-либо несоответствующее предложенным вариантам, то говорим ему об этом
                }
                Console.WriteLine();
                //Thread.Sleep(500);
            }
            while (true);

            Console.ReadLine();

        }
    }
}
