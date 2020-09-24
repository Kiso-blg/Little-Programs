using System;
using System.Diagnostics;

namespace _14_FloatingPointNumbersDifferens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-8-numeral-systems/#_Toc362296443");
            Console.WriteLine("Exercise 14" + Environment.NewLine);

            Console.WriteLine("This program sums up the number 0.000001, 50 000 000 times with real number types float, double and decimal.");
            Stopwatch sw = new Stopwatch();
            float floatType = 0f;
            Console.WriteLine($"Float type: {floatType:F12}");
            sw.Start();

            for (int i = 0; i < 50000000; i++)
            {
                floatType += 0.000001f;
            }

            sw.Stop();
            Console.WriteLine($"The result is {floatType:F12}");
            Console.WriteLine("The elapsed time is " + sw.Elapsed.TotalSeconds);
            Console.WriteLine();
            
            double doubleType = 0;
            Console.WriteLine($"Double type: {doubleType:F12}");
            sw.Restart();

            for (int i = 0; i < 50000000; i++)
            {
                doubleType += 0.000001;
            }

            sw.Stop();
            Console.WriteLine($"The result is {doubleType:F12}");
            Console.WriteLine("The elapsed time is " + sw.Elapsed.TotalSeconds);
            Console.WriteLine();

            decimal decimalType = 0m;
            Console.WriteLine($"Decimal type: {decimalType:F12}");
            sw.Restart();

            for (int i = 0; i < 50000000; i++)
            {
                decimalType += 0.000001m;
            }

            sw.Stop();
            Console.WriteLine($"The result is {decimalType:F12}");
            Console.WriteLine("The elapsed time is " + sw.Elapsed.TotalSeconds);
        }
    }
}