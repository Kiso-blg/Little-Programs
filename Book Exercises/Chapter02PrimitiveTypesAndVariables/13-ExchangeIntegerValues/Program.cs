using System;

namespace _13_ExchangeIntegerValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-2-primitive-types-and-variables/#_Toc362296391");
            Console.WriteLine("Exercise 13" + Environment.NewLine);

            int x = 5;
            int y = 10;
            Console.WriteLine($"Variable '{nameof(x)}' = {x}");
            Console.WriteLine($"Variable '{nameof(y)}' = {y}");
            Console.WriteLine("Doing next exchange operation:");
            Console.WriteLine("x ^= y");
            Console.WriteLine("y ^= x");
            Console.WriteLine("x ^= y");

            x ^= y;
            y ^= x;
            x ^= y;                
            Console.WriteLine($"Variable '{nameof(x)}' = {x}");
            Console.WriteLine($"Variable '{nameof(y)}' = {y}");
        }
    }
}