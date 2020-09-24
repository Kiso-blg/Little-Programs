using System;
using System.Collections.Generic;
using System.Linq;

namespace _13_FindFirstMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#FirstMissing" + Environment.NewLine);

            int[] array = GenerateArray();
            Console.WriteLine("Sequence: ");
            Console.WriteLine(string.Join(" ", array) + Environment.NewLine);

            HashSet<int> set = new HashSet<int>();

            foreach (int num in array)
            {
                set.Add(num);
            }

            int lowestNum = set.First();

            foreach (int num in set)
            {
                if (num < lowestNum)
                {
                    lowestNum = num;
                }
            }

            while (set.Contains(++lowestNum))
            {
            }

            if (!set.Contains(lowestNum))
            {
                Console.WriteLine($"First missing number is: {lowestNum}");
            }
            else
            {
                Console.WriteLine($"First missing number is: {++lowestNum}");
            }

            Console.WriteLine(string.Join(" ", set.OrderBy(n => n)));
        }

        private static int[] GenerateArray()
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 250; i++)
            {
                list.Add(i + 1);
            }

            Random rand = new Random();

            for (int i = 0; i < rand.Next(10); i++)
            {
                int possition = rand.Next(1, list.Count);
                list.RemoveAt(possition);
            }

            //int possition = 161;
            //list.RemoveAt(possition);            

            for (int i = 0; i < list.Count; i++)
            {
                int possition = rand.Next(1, list.Count);
                int swap = list[i];
                list[i] = list[possition];
                list[possition] = swap;
            }

            return list.ToArray();
        }
    }
}
