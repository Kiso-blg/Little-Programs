using System;
using System.Numerics;

namespace _23_Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#Stairs" + Environment.NewLine);

            Console.Write("Enter the number of steps of the staircase: ");
            int stepsCount = GetStepsCount();

            BigInteger n = 1;
            BigInteger result = 0;

            for (int i = 0; i < stepsCount - 1; i++)
            {
                BigInteger m = n;
                n = result;
                result = n + m;
            }

            Console.WriteLine("You can climb a staircase by stepping one or two steps at one by {0} different wais.", result);
        }

        private static int GetStepsCount()
        {
            string input = Console.ReadLine();
            int count;

            while (!int.TryParse(input, out count))
            {
                Console.WriteLine();
                Console.Write("Incorect input. Try again. ");
                input = Console.ReadLine();
            }

            return count;
        }
    }
}