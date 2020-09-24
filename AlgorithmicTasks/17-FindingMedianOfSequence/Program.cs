using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_FindingMedianOfSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#Median" + Environment.NewLine);

            int[] sequence = new int[] {10, 2, 3, 3, 5, 7, 8 };
            Console.WriteLine("Sequence: " + string.Join(" ", sequence));
            List<int> lowNumbers = new List<int>();
            List<int> highNumbers = new List<int>();
            lowNumbers.Add(sequence[0]);

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] > lowNumbers.Max())
                {
                    highNumbers.Add(sequence[i]);
                }
                else
                {
                    lowNumbers.Add(sequence[i]);
                }

                if (highNumbers.Count > lowNumbers.Count)
                {
                    int swap = highNumbers.Min();
                    highNumbers.Remove(highNumbers.Min());
                    lowNumbers.Add(swap);
                }
                else if (lowNumbers.Count > highNumbers.Count)
                {
                    int swap = lowNumbers.Max();
                    lowNumbers.Remove(lowNumbers.Max());
                    highNumbers.Add(swap);
                }
            }

            int median;

            if (lowNumbers.Count > highNumbers.Count)
            {
                median = lowNumbers.Max();
            }
            else if (highNumbers.Count > lowNumbers.Count)
            {
                median = highNumbers.Min();
            }
            else
            {
                median = (lowNumbers.Max() + highNumbers.Min()) / 2;
            }

            Console.WriteLine($"The median of the sequence is {median}");
        }
    }
}