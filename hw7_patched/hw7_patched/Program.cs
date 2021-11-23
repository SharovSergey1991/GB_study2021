// Decompiled with JetBrains decompiler
// Type: hw7.Program
// Assembly: hw7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 674982E8-F919-4950-90BC-A1676B91D4B2
// Assembly location: D:\C#\Введение в C#\GB_study2021\hw7\hw7\bin\Debug\netcoreapp3.1\hw7.dll

using System;

namespace hw7
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Вычисление квадрата числа");
      Console.Write("Введите число: ");
      double d = (double) int.Parse(Console.ReadLine());
      Console.WriteLine();
      Console.WriteLine(string.Format("Квадрат числа {0} равен {1}", (object) d, (object) Math.Pow(d,2)));
      Console.ReadLine();
    }
  }
}
