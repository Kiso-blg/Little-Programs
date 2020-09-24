using System;
using System.Collections.Generic;

namespace _19_Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-7-arrays/#_Toc362296436");
            Console.WriteLine("Exercise 19" + Environment.NewLine);

            Console.WriteLine("This program finds all prime numbers in range 1 - 10000000.");
            Console.WriteLine(2);
            List<int> primeNumbers = new List<int>
            {
                2
            };

            for (int i = 3; i < 10000000; i += 2)
            {
                bool isPrime = IsPrime(i);

                if (isPrime)
                {                    
                    primeNumbers.Add(i);
                    //Console.WriteLine(i);
                }
            }

            Console.WriteLine($"There are {primeNumbers.Count} prime numbers");
        }

        private static bool IsPrime(int candidate)
        {
            int limit = (int)Math.Ceiling(Math.Sqrt(candidate));

            //for (int i = 3; (i * i) < candidate; i += 2)
            for (int i = 3; i < limit; i += 2)
            {
                if (candidate % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}