using System;

namespace _29_WineBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#WineBottlesV2" + Environment.NewLine);

            //int[] bottles = new int[] { 1, 4, 2, 3 };
            //int[] bottles = new int[] { 2, 3, 5, 1, 4 };
            int[] bottles = new int[] { 2, 3, 5, 1, 4, 6, 3, 2 };
            Console.WriteLine("Prices of the bottles: " + string.Join(" ", bottles));
            int year = 1;
            int[,] dyn = new int[bottles.Length, bottles.Length];
            int left = 0;
            int right = bottles.Length - 1;

            int result = Recurse(left, right, year, dyn, bottles);
            Console.WriteLine($"The maximum profit which can be earned is {result} leva.");
        }

        private static int Recurse(int left, int right, int year, int[,] dyn, int[] price)
        {
            if (left > right)
            {
                return 0;
            }

            int winLeft = Recurse(left + 1, right, year + 1, dyn, price) + year * price[left];
            int winRight = Recurse(left, right - 1, year + 1, dyn, price) + year * price[right];;

            return dyn[left, right] = Math.Max(winLeft, winRight);
        }
    }
}