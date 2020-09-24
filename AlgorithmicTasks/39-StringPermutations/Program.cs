using System;
using System.Collections.Generic;

namespace _39_StringPermutations
{
    class Program
    {
        static readonly HashSet<string> strSet = new HashSet<string>();

        static void Main()
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#AllPermutations" + Environment.NewLine);

            Console.WriteLine("Enter a string.");
            string input = Console.ReadLine();
            int start = 0;
            GetPermutations(start, input);
            Console.WriteLine($"There are {strSet.Count} permutations.");

            foreach (string str in strSet)
            {
                Console.WriteLine(str);
            }            
        }

        private static void GetPermutations(int start, string str)
        {
            if (start == str.Length)
            {
                strSet.Add(str);
            }

            char[] chr = str.ToCharArray();

            for (int i = start; i < str.Length; i++)
            {
                char ch = chr[i];
                chr[i] = chr[start];
                chr[start] = ch;
                GetPermutations(start + 1, new string(chr));
            }
        }
    }
}