using System;

namespace _08_InOrOutTheCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-3-operators-and-expressions/#_Toc362296398");
            Console.WriteLine("Exercise 8" + Environment.NewLine);

            Console.WriteLine("This program calculates if a given point {X, Y} is in a circle.");
            Console.Write("Enter X coordinate: ");
            double xCoord = GetCoord();
            Console.Write("Enter Y coordinate: ");
            double yCoord = GetCoord();
            Console.Write("Enter radius: ");
            double radius = GetCoord();
            bool isPointWithin = (xCoord * xCoord) + (yCoord * yCoord) <= radius * radius;
            Console.WriteLine($"The point {(isPointWithin ? "is" : "is not")} in the area of the circle.");
        }

        private static double GetCoord()
        {
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double coord))
            {
                Console.WriteLine("Incorrect input. Try again");
                coord = GetCoord();
            }

            return coord;
        }
    }
}