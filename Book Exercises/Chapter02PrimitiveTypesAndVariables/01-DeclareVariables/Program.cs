using System;

namespace _01_DeclareVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-2-primitive-types-and-variables/#_Toc362296391");
            Console.WriteLine("Exercise 1" + Environment.NewLine);

            sbyte num1 = 52;
            byte num2 = 130;
            sbyte num3 = -115;
            int num4 = 4825932;
            sbyte num5 = 97;
            short num6 = -10000;
            short num7 = 20000;
            byte num8 = 224;
            int num9 = 970700000;
            sbyte num10 = 112;
            sbyte num11 = -44;
            int num12 = -1000000;
            short num13 = 1990;
            long num14 = 123456789123456789;

            Console.WriteLine($"Number {num1} it type {num1.GetType()}.");
            Console.WriteLine($"Number {num2} it type {num2.GetType()}.");
            Console.WriteLine($"Number {num3} it type {num3.GetType()}.");
            Console.WriteLine($"Number {num4} it type {num4.GetType()}.");
            Console.WriteLine($"Number {num5} it type {num5.GetType()}.");
            Console.WriteLine($"Number {num6} it type {num6.GetType()}.");
            Console.WriteLine($"Number {num7} it type {num7.GetType()}.");
            Console.WriteLine($"Number {num8} it type {num8.GetType()}.");
            Console.WriteLine($"Number {num9} it type {num9.GetType()}.");
            Console.WriteLine($"Number {num10} it type {num10.GetType()}.");
            Console.WriteLine($"Number {num11} it type {num11.GetType()}.");
            Console.WriteLine($"Number {num12} it type {num12.GetType()}.");
            Console.WriteLine($"Number {num13} it type {num13.GetType()}.");
            Console.WriteLine($"Number {num14} it type {num14.GetType()}.");
        }
    }
}