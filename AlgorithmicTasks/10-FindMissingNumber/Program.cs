using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_FindMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#ExactlyOneMissing" + Environment.NewLine);

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 7};
            Console.WriteLine("Sequence: " + string.Join(" ", list));
            int sum = list.Sum();
            int missingNumber = (list.Count + 1) * (list.Count + 2) / 2 - sum;
            Console.WriteLine("Missing number is: {0}", missingNumber);
        }
    }
}