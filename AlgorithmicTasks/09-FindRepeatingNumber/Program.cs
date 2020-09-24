using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_FindRepeatingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#ExactlyOneRepeated" + Environment.NewLine);

            List<int> list = new List<int> { 1, 2, 6, 3, 4, 5, 4, 7 };
            Console.WriteLine("Sequence: " + string.Join(" ", list));
            int sum = list.Sum();
            int repeatingNumber = sum - list.Count * (list.Count - 1) / 2;
            Console.WriteLine("Repeating number is: {0}", repeatingNumber);
        }
    }
}