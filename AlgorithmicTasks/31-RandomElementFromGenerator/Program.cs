using System;

namespace _31_RandomElementFromGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#RandomElementFromGenerator" + Environment.NewLine);

            Console.Write("Enter generator's min value: ");
            decimal min = GetRangeValue();
            Console.Write("Enter generator's max value: ");
            decimal max = GetRangeValue();
            decimal[] generator = CreateGenerator(min, max);
            Console.Write("Enter the count of the elements:");
            int n = generator.Length;
            int elementsCount = GetElementsCount(n);
            SelectKItems(generator, n, elementsCount);
        }

        private static int GetElementsCount(int length)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int count))
            {
                if (count > length)
                {
                    Console.WriteLine("Incorrect input.");
                    count = GetElementsCount(length);
                }
            }
            else
            {
                Console.WriteLine("Incorrect input.");
                count = GetElementsCount(length);
            }

            return count;
        }

        private static decimal[] CreateGenerator(decimal min, decimal max)
        {
            int minValue = (int)Math.Min(min, max);
            int maxValue = (int)Math.Max(min, max);
            int length = maxValue - minValue;
            decimal[] array = new decimal[length];
            Random rand = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(minValue, maxValue);
            }

            return array;
        }

        private static decimal GetRangeValue()
        {
            string input = Console.ReadLine();

            if (!decimal.TryParse(input, out decimal num))
            {
                Console.WriteLine("Incorrect input.");
                num = GetRangeValue();
            }

            return num;
        }

        private static void SelectKItems(decimal[] array, int n, int k)
        {
            int i;
            decimal[] reservior = new decimal[k];
            Random rand = new Random();

            for (i = 0; i < k; i++)
            {
                reservior[i] = array[i];
            }

            for (; i < n; i++)
            {
                int j = rand.Next(i + 1);

                if (j < k)
                {
                    reservior[j] = array[i];
                }
            }

            Console.WriteLine("The following are K randomly selected items:");
            Console.WriteLine(string.Join(" ", reservior));
        }
    }
}