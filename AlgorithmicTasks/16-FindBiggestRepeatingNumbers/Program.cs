using System;
using System.Collections.Generic;
using System.Linq;

namespace _16_FindBiggestRepeatingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#LargestRepeated" + Environment.NewLine);

            int[] numbers = GenerateArray();
            Console.WriteLine("Sequence: " + string.Join(" ", numbers));
            Dictionary<int, int> allNumbers = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!allNumbers.ContainsKey(numbers[i]))
                {
                    allNumbers.Add(numbers[i], 0);
                }
                else
                {
                    allNumbers[numbers[i]]++;
                }
            }

            int firstBiggestNumber = -1;
            int secondBiggestNumber = -1;

            foreach (KeyValuePair<int, int> number in allNumbers.OrderByDescending(item => item.Key))
            {
                if (number.Value > 0)
                {
                    if (firstBiggestNumber > 0)
                    {
                        secondBiggestNumber = number.Key;
                        break;
                    }
                    else
                    {
                        firstBiggestNumber = number.Key;
                    }
                }
            }

            Console.WriteLine("First largest repeating number is {0}", firstBiggestNumber);
            Console.WriteLine("Second largest repeating number is {0}", secondBiggestNumber);
        }

        private static int[] GenerateArray()
        {
            int[] array = new int[60];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 50);
            }

            return array;
        }
    }
}