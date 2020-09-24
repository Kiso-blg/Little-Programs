using System;

namespace _07_GreatestOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-5-conditional-statements/#_Toc362296414");
            Console.WriteLine("Exercise 7" + Environment.NewLine);

            Console.WriteLine("This program prints the greatest of given five numbers.");
            Console.Write("Enter the first number: ");
            double a = GetNumber();
            Console.Write("Enter the second number: ");
            double b = GetNumber();
            Console.Write("Enter the third number: ");
            double c = GetNumber();
            Console.Write("Enter the Fourth number: ");
            double d = GetNumber();
            Console.Write("Enter the fifth number: ");
            double e = GetNumber();
            Console.Write("The greatest number is ");

            if (a >= b && a >= c && a >= d && a >= e)
            {
                Console.WriteLine($"the first numer {a}.");
            }
            else if (b >= a && b >= c && b >= d && b >= e)
            {
                Console.WriteLine($"the second numer {b}.");
            }
            else if (c >= a && c >= b && c >= d && c >= e)
            {
                Console.WriteLine($"the third numer {c}.");
            }
            else if (d >= a && d >= b && d >= c && d >= e)
            {
                Console.WriteLine($"the fourth numer {d}.");
            }
            else if (e >= a && e >= b && e >= c && e >= d)
            {
                Console.WriteLine($"the fifth numer {e}.");
            }
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