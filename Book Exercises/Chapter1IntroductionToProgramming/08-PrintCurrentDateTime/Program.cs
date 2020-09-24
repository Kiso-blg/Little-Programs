using System;

namespace _08_PrintCurrentDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-1-introduction-to-programming/#_Toc362296382");
            Console.WriteLine("Exercise 8" + Environment.NewLine);

            Console.WriteLine($"{DateTime.Now:G}");
        }
    }
}