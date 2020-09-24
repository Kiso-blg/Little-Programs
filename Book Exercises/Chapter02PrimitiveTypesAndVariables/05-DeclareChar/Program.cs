using System;

namespace _05_DeclareChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-2-primitive-types-and-variables/#_Toc362296391");
            Console.WriteLine("Exercise 5" + Environment.NewLine);

            char ch = '\u0048';
            Console.WriteLine($@"{ch} is a {ch.GetType()} with value 72 and unicode '\u0048'.");
        }
    }
}