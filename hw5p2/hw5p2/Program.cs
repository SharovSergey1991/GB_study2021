using System;
using System.IO;

namespace hw5p2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "startup.txt";
            File.AppendAllText(filename, DateTime.Now.ToString());
            File.AppendAllText(filename, Environment.NewLine);
        }
    }
}
