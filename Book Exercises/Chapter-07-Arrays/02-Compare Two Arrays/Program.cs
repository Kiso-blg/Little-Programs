using System;
using System.Linq;

namespace _02_Compare_Two_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 2" + Environment.NewLine);

            Console.WriteLine("This program reads two arrays of type Int from the console and compare them if they are equal.");
            Console.Write("Enter first array elements separate by \", \": ");
            int[] firstArray = ReadArray();
            Console.Write("Enter second array elements separate by \", \": ");
            int[] secondArray = ReadArray();
            bool areEqual = CompareArrays(firstArray, secondArray);

            if (areEqual)
            {
                Console.WriteLine("The arrays are equal.");
            }
            else
            {
                Console.WriteLine("The arrays are not equal.");
            }
        }

        private static bool CompareArrays(int[] firstArray, int[] secondArray)
        {
            if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        return false;
                    }                    
                }

                return true;
            }

            return false;
        }

        private static int[] ReadArray()
        {
            string strArray = Console.ReadLine();
            int[] array;

            try
            {
                array = strArray
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(item => int.Parse(item)).ToArray();
            }
            catch 
            {
                Console.WriteLine("Incorrect input. Enter correct array.");
                array = ReadArray();
            }

            return array;
        }
    }
}