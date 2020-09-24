using System;

namespace _16_ShuffleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-6-loops/#_Toc362296424");
            Console.WriteLine("Exercise 16" + Environment.NewLine);

            Console.WriteLine("This program prints the numbers form 1 to N in random order by given N.");
            Console.Write("Enter the count of the numbers: N = ");
            int n = GetInteger();
            int[] numbers = FillArray(n);
            Console.WriteLine(string.Join(", ", numbers));
            ShuffleArray(numbers);
            Console.WriteLine("The numbers in shuffled order are:");
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void ShuffleArray(int[] numbers)
        {
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                int newIdx = rand.Next(numbers.Length);

                if (newIdx != i)
                {
                    numbers[i] ^= numbers[newIdx];
                    numbers[newIdx] ^= numbers[i];
                    numbers[i] ^= numbers[newIdx];
                }
            }
        }

        private static int[] FillArray(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            return arr;
        }

        private static int GetInteger()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetInteger();
            }

            return Math.Abs(num);
        }
    }
}