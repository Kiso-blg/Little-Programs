using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_SubsetWithZeroSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program reads 5 integers and finds those subsets whose sum is 0.");
            //int[] sequence = new int[] { 3, -2, 1, 1, 5, -8, 8 };
            bool found = false;
            int[] sequence = new int[5];

            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write("Enter the first number: ");
                sequence[i] = GetNumber();
            }

            Console.WriteLine("Sequence: " + string.Join(" ", sequence));

            for (int start = 0; start < sequence.Length; start++)
            {
                int sum = 0;

                for (int end = start; end < sequence.Length; end++)
                {
                    sum += sequence[end];

                    if (sum == 0)
                    {
                        found = true;
                        string subSequence = string.Join(", ", sequence.Skip(start).Take(end - start + 1));
                        Console.WriteLine(subSequence);
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("There are no sumsets with sum 0.");
            }
        }

        private static int GetNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Incorrect input. Try again.");
                num = GetNumber();
            }

            return num;
        }
    }
}
