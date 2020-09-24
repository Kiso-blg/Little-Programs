using System;

namespace _04_SortThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-5-conditional-statements/#_Toc362296414");
            Console.WriteLine("Exercise 4" + Environment.NewLine);

            Console.WriteLine("This program sorts three numbers in descending order using nested if statements.");
            Console.Write("Enter the first number: ");
            double a = GetNumber();
            Console.Write("Enter the second number: ");
            double b = GetNumber();
            Console.Write("Enter the third number: ");
            double c = GetNumber();

            if ((a >= b) && (a >= c))
            {
                if (c > b)
                {
                    double swap = b;
                    b = c;
                    c = swap;
                }
            }
            else if ((b >= a) && (b >= c))
            {
                if (a >= c)
                {
                    double swap = a;
                    a = b;
                    b = swap;
                }
                else
                {
                    double swap = a;
                    a = b;
                    b = c;
                    c = swap;
                }
            }
            else if (c > a && c > b)
            {
                if (a >= b)
                {
                    double swap = c;
                    c = b;
                    b = a;
                    a = swap;
                }
                else
                {
                    double swap = c;
                    c = a;
                    a = swap;
                }
            }

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

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