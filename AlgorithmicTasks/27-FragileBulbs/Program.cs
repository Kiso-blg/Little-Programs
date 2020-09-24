using System;

namespace _27_FragileBulbs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#BreakingBulbs" + Environment.NewLine);

            int breakFloor = GetBreakingFloor();
            int minFloor = 1;
            int maxFloor = 100;
            int attemptsCount = 1;
            int attempt = (minFloor + maxFloor) / 2;

            while (attempt != breakFloor)
            {
                if (breakFloor < attempt)
                {
                    maxFloor = attempt;
                }
                else if (breakFloor > attempt)
                {
                    minFloor = attempt;
                }

                attempt = (minFloor + maxFloor) / 2;
                attemptsCount++;
            }

            Console.WriteLine($"The light bulbs can be broken from floor {attempt}. Found with {attemptsCount} attemps.");
        }

        private static int GetBreakingFloor()
        {
            Console.WriteLine("Enter a floor number (1-100):");

            if (int.TryParse(Console.ReadLine(), out int floor))
            {
                if (floor < 0 || floor > 100)
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 including.");
                    floor = GetBreakingFloor();
                }
            }
            else
            {
                Console.WriteLine("Please enter an integer between 1 and 100 including.");
                floor = GetBreakingFloor();
            }

            return floor;
        }
    }
}
