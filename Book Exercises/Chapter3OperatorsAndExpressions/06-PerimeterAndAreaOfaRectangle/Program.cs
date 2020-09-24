using System;

namespace _06_PerimeterAndAreaOfaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-3-operators-and-expressions/#_Toc362296398");
            Console.WriteLine("Exercise 6" + Environment.NewLine);

            Console.WriteLine("This program calculates the perimeter and area of a rectangle.");
            Console.Write("Enter first side: ");
            double sideA = GetSide();
            Console.Write("Enter second side: ");
            double sideB = GetSide();
            double perimeter = (sideA + sideB) * 2;
            double area = sideA * sideB;
            Console.WriteLine($"The perimeter is: {perimeter}");
            Console.WriteLine($"The area is: {area}");
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
