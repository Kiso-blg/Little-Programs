﻿using System;
using System.Linq;

namespace _12_SumOfPolynoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-9-methods/#_Toc362296457");
            Console.WriteLine("Exercise 12" + Environment.NewLine);

            Console.WriteLine("This program calculates the sum of two polynoms whith integer coefficients.");
            Console.WriteLine("Entet the first polynom coefficients separate by ' ': ");
            int[] firstPolynom = GetPolynom();
            Console.WriteLine("Entet the second polynom coefficients separate by ' ': ");
            int[] secondPolynom = GetPolynom();
            int[] resultPolynom = CalculatePolynoms(firstPolynom, secondPolynom);
            PrintPolynoms(firstPolynom, secondPolynom, resultPolynom);
        }

        private static void PrintPolynoms(int[] firstPolynom, int[] secondPolynom, int[] resultPolynom)
        {
            Console.WriteLine($"({GetStringPolynom(firstPolynom)}) + ({GetStringPolynom(secondPolynom)}) = {GetStringPolynom(resultPolynom)}");
        }

        private static object GetStringPolynom(int[] polynom)
        {
            string strPolynom = polynom[polynom.Length - 1] > 0 ? "" : "-";

            for (int i = polynom.Length - 1; i > -1; i--)
            {
                if (polynom[i] != 0)
                {
                    if (i > 1)
                    {
                        strPolynom += $"{Math.Abs(polynom[i])}x^{i}";
                    }
                    else if (i == 1)
                    {
                        strPolynom += Math.Abs(polynom[i]) != 1 ? $"{Math.Abs(polynom[i])}x" : "x";
                    }
                    else
                    {
                        strPolynom += Math.Abs(polynom[i]);
                    }

                    if (i > 0)
                    {
                        strPolynom += GetNextSign(polynom, i);
                    }
                }
            }

            return strPolynom;
        }

        private static string GetNextSign(int[] polynom, int idx)
        {
            for (int i = idx - 1; i > -1; i--)
            {
                if (polynom[i] != 0)
                {
                    return polynom[i] > 0 ? " + " : " - ";
                }
            }

            return string.Empty;
        }

        private static int[] CalculatePolynoms(int[] firstPolynom, int[] secondPolynom)
        {
            int[] result = new int[Math.Max(firstPolynom.Length, secondPolynom.Length) + 1];

            for (int i = 0; i < result.Length; i++)
            {
                int first = i < firstPolynom.Length ? firstPolynom[i] : 0;
                int second = i < secondPolynom.Length ? secondPolynom[i] : 0;
                result[i] = first + second;
            }

            return result;
        }

        private static int[] GetPolynom()
        {
            string input = Console.ReadLine();
            int[] arr;

            if (input == string.Empty)
            {
                Console.WriteLine("Invalid input. Enter the polynom again.");
                arr = GetPolynom();
            }

            try
            {
                arr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .Reverse()
                           .ToArray();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Enter the polynom again.");
                arr = GetPolynom();
            }

            return arr;
        }
    }
}