using System;

namespace _09_InACircleOutOfARectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-3-operators-and-expressions/#_Toc362296398");
            Console.WriteLine("Exercise 9" + Environment.NewLine);

            Console.WriteLine("This program calculates if a given point {X, Y} is in a circle (R = 5) and out of rectangle ({-1, 1}, {5, 5}).");
            Console.Write("Enter X coordinate: ");
            double xCoord = GetCoord();
            Console.Write("Enter Y coordinate: ");
            double yCoord = GetCoord();
            double radius = 5;
            bool isPointInCircle = (xCoord * xCoord) + (yCoord * yCoord) <= radius * radius;
            bool isPointInRectangle = (xCoord >= -1 && xCoord <= 5) && (yCoord >= 1 && yCoord <= 5);

            if (isPointInCircle && !isPointInRectangle)
            {
                Console.WriteLine("Yes, the point is in the circle and out of the rectangle.");
            }
            else if (isPointInCircle && isPointInRectangle)
            {
                Console.WriteLine("The point is in the circle and in the rectangle.");
            }
            else if (!isPointInCircle && isPointInRectangle)
            {
                Console.WriteLine("The point is out of the circle and in the rectangle.");
            }
            else
            {
                Console.WriteLine("The point is out of the circle and rectangle.");
            }
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