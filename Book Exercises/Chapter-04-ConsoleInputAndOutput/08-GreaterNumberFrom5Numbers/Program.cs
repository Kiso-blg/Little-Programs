using System;

namespace _08_GreaterNumberFrom5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-4-console-input-and-output/#_Toc362296407");
            Console.WriteLine("Exercise 8" + Environment.NewLine);

            Console.WriteLine("This program prints the greater of five given numbers.");
            Console.Write("Enter number A : ");
            double a = GetNumber();
            Console.Write("Enter number B ");
            double b = GetNumber();
            Console.Write("Enter number C ");
            double c = GetNumber();
            Console.Write("Enter number D ");
            double d = GetNumber();
            Console.Write("Enter number E ");
            double e = GetNumber();
            Console.WriteLine($"The greater number is {Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(e, d))))}");
        }

        private static double GetNumber()
        {
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            return num;
        }
    }
}