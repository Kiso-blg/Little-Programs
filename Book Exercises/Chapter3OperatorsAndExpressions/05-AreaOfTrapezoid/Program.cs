using System;

namespace _05_AreaOfTrapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-3-operators-and-expressions/#_Toc362296398");
            Console.WriteLine("Exercise 5" + Environment.NewLine);

            Console.WriteLine("This program calculates the area of a trapezoid.");
            Console.Write("Enter first side: ");
            double sideA = GetSide();
            Console.Write("Enter second side: ");
            double sideB = GetSide();
            Console.Write("Enter the height: ");
            double height = GetSide();

            double area = (sideA + sideB) * height / 2;
            Console.WriteLine($"The area of the trapezoid is {area}");
        }

        private static double GetSide()
        {
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double side))
            {
                Console.WriteLine("Incorrect input. Try again");
                side = GetSide();
            }

            return side;
        }
    }
}