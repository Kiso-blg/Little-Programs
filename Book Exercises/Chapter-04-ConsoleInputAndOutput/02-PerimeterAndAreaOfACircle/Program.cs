using System;

namespace _02_PerimeterAndAreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-4-console-input-and-output/#_Toc362296407");
            Console.WriteLine("Exercise 2" + Environment.NewLine);

            Console.WriteLine("This program calculates perimeter and area of a circle by given radius.");
            Console.Write("Enter a radius: R = ");
            double r = GetRadius();
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            Console.WriteLine($"The perimeter is {Math.Round(perimeter, 4)}");
            Console.WriteLine($"The area is {Math.Round(area, 4)}");
        }

        private static double GetRadius()
        {
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetRadius();
            }

            return num;
        }
    }
}