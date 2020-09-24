using System;
using System.IO;

namespace _08_AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-9-methods/#_Toc362296457");
            Console.WriteLine("Exercise 8" + Environment.NewLine);

            Stream buffer = Console.OpenStandardInput(10000);
            Console.SetIn(new StreamReader(buffer, Console.InputEncoding, false, 10000));

            Console.WriteLine("This program calculates the sum of two very long positive numbers.");
            Console.Write("Enther the first number: ");
            int[] firstNum = GetNumber();
            Console.Write("Enther the second number: ");
            int[] secondNum = GetNumber();
            int[] sum = SumNumbers(firstNum, secondNum);
            Console.WriteLine("Sum = " + string.Join("", sum));
        }

        private static int[] SumNumbers(int[] firstNum, int[] secondNum)
        {
            string result = string.Empty;
            int length = Math.Max(firstNum.Length, secondNum.Length);
            int plusOne = 0;            

            for (int i = 0; i < length; i++)
            {
                int num1 = i < firstNum.Length ? firstNum[i] : 0;
                int num2 = i < secondNum.Length ? secondNum[i] : 0;
                int sum = num1 + num2 + plusOne;
                result += (sum % 10);
                plusOne = sum > 9 ? 1 : 0;
            }


            if (plusOne > 0)
            {
                result += plusOne;
            }

            int[] number = ReverseResult(result);

            return number;
        }

        private static int[] ReverseResult(string result)
        {
            int[] arr = new int[result.Length];
            int idx = 0;

            for (int i = result.Length - 1; i > -1; i--)
            {
                arr[idx++] = result[i] - 48;
            }

            return arr;
        }

        private static int[] GetNumber()
        {
            string input = Console.ReadLine();
            int length = GetLength(input);
            int[] number = new int[length];
            bool isIncorrect = false;
            int idx = 0;


            for (int i = input.Length - 1; i > input.Length - number.Length - 1; i--)
            {
                if (char.IsDigit(input[i]))
                {
                    number[idx++] = (int)char.GetNumericValue(input[i]);
                }
                else
                {
                    isIncorrect = true;
                    break;
                }
            }

            if (input == string.Empty)
            {
                isIncorrect = true;
            }

            if (isIncorrect)
            {
                Console.WriteLine("Invalid input. Enter the number again.");
                number = GetNumber();
            }

            return number;
        }

        private static int GetLength(string input)
        {
            int idx = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '0')
                {
                    idx++;
                }
                else
                {
                    break;
                }
            }

            return input.Length - idx;
        }
    }
}