using System;
using System.Linq;

namespace _04_Find_Max_Sequence_Of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program finds the maximal sub sequence of consecutive equal elements.");
            int[] sequence = new int[] { 1, 1, 2, 2, 3, 2, 2, 2, 1, 5, 5, 5, 5, 4, 4, 4, 4 };
            Console.WriteLine("Sequence: " + string.Join(" ", sequence));

            int maxLength = 1;
            int length = 1;
            int startIndex = 0;

            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] == sequence[i - 1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                }

                if (length > maxLength)
                {
                    maxLength = length;
                    startIndex = i - maxLength + 1;
                }
            }

            Console.WriteLine(
                $"The longest sub sequence is {string.Join(" ", sequence.Skip(startIndex).Take(maxLength).ToArray())}");
        }
    }
}