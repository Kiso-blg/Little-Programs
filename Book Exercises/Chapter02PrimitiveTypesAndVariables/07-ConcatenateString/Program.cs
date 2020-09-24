using System;

namespace _07_ConcatenateString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-2-primitive-types-and-variables/#_Toc362296391");
            Console.WriteLine("Exercise 7" + Environment.NewLine);

            string hello = "Hello";
            string world = "World";
            object hw = hello + " " + world;
            Console.WriteLine(hw);
            Console.WriteLine($"The variable '{nameof(hw)}' is type object containing type {hw.GetType()} and its value is {hw}");
        }
    }
}