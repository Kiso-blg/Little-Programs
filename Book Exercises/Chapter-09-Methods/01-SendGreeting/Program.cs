using System;

namespace _01_SendGreeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-9-methods/#_Toc362296457");
            Console.WriteLine("Exercise 1" + Environment.NewLine);

            Console.WriteLine("This program takes a name as input and send greeting.");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            SendGreeting(name);
        }

        private static void SendGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}