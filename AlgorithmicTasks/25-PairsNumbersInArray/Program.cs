using System;
using System.Linq;

namespace _25_PairsNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#PairsInArray" + Environment.NewLine);

            int[] sequence = new int[] { 7, -7, -5, -9, 2, 3, 10, 11, -4, 0, 8, 1, -6, 17, 13 };
            Console.WriteLine("Sequence: " + string.Join(" ", sequence));
            int numT = GetSeekingNumber(sequence);
            Array.Sort(sequence);
            Console.WriteLine("Sequence: " + string.Join(" ", sequence));
            int lessOrEqualCount = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = sequence.Length - 1; j > i; j--)
                {
                    if (sequence[i] + sequence[j] <= numT)
                    {
                        lessOrEqualCount += (j - i + 1) * 2;
                        break;
                    }
                }
            }

            Console.WriteLine($"There are {lessOrEqualCount} combinations with two numbers with sum less or equal to {numT}");
            Console.WriteLine();

            int equalsCount = 0;
            int left = 0;
            int right = sequence.Length - 1;

            while (right > left)
            {
                if (sequence[left] + sequence[right] == numT)
                {
                    equalsCount++;
                    left++;
                }
                else if (sequence[left] + sequence[right] < numT)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            Console.WriteLine($"There are {equalsCount} combination of two numbers with sum equal to {numT}");
        }

        private static int GetSeekingNumber(int[] sequence)
        {
            Console.WriteLine($"Please enter input between {sequence.Min()} and {sequence.Max()}");
            int num;

            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out num))
                {
                    if (num >= sequence.Min() && num <= sequence.Max())
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter input between {sequence.Min()} and {sequence.Max()}");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input.");
                }
            }

            return num;
        }
    }
}