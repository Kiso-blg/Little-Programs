using System;

namespace _13_QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-4-console-input-and-output/#_Toc362296407");
            Console.WriteLine("Exercise 13 (9)" + Environment.NewLine);

            Console.WriteLine("This program resolve quadratic equation ax^2 + bx + c = 0 by given a, b, c.");
            Console.Write("Enter number A = ");
            double a = GetNumber();
            Console.Write("Enter number B = ");
            double b = GetNumber();
            Console.Write("Enter number C = ");
            double c = GetNumber();

            Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");

            double d = ((b * b) - (4 * a * c));
            double x1;
            double x2;

            if (d < 0)
            {
                Console.WriteLine("The quadratic equation has no root.");
            }
            else if (d == 0)
            {
                Console.WriteLine($"x = -{b} / 2 * {a}");
                x1 = (-(b) / (2 * a));
                Console.WriteLine($"The root is {x1}");
            }
            else
            {
                Console.WriteLine($"x1,2 = -{b} +- Sqrt({d}) / 2 * {a}");
                x1 = ((-(b)) + Math.Sqrt(d)) / (2 * a);
                x2 = ((-(b)) - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"The roots are {x1} and {x2}.");
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