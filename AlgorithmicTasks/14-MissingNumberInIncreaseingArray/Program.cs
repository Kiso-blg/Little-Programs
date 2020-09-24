using System;
using System.Collections.Generic;

namespace _14_MissingNumberInIncreaseingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#HoleInSortedArray" + Environment.NewLine);

            int[] array = GenerateArray();
            Console.WriteLine("Sequence: " + string.Join(" ", array));
            int missingNumber = -1;
            int down = array[array.Length - 1];

            for (int up = 0; up < array.Length / 2; up++, down--)
            {
                if (array[up] != up)
                {
                    missingNumber = up;
                    break;
                }
                else if (array[array.Length - up - 1] != down)
                {
                    missingNumber = down;
                    break;
                }
            }

            if (missingNumber > 0)
            {
                Console.WriteLine($"The missing number is {missingNumber}");
            }
            else
            {
                Console.WriteLine($"The missing number is {array.Length}");
            }
        }

        private static int[] GenerateArray()
        {
            List<int> listNums = new List<int>();

            for (int i = 0; i < 101; i++)
            {
                listNums.Add(i);
            }

            Random rand = new Random();
            int numToRemove = rand.Next(0, listNums.Count + 30);

            if (numToRemove < listNums.Count)
            {
                listNums.Remove(numToRemove);
            }

            return listNums.ToArray();
        }
    }
}