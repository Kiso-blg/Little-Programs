using System;

namespace _28_SubstringWithTwoSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#TwoCharSubstring" + Environment.NewLine);

            string str = "aababbbbbbbaaacacaacacccaab";
            //string str = "aababbbbbbbaaacacaacacccaabadadadadadadadadadadadad";
            //string str = "ABBA";
            //string str = "eeeeeeeeee";
            //string str = "1";
            Console.WriteLine(str);
            char firstChar = str[0];
            int firstCharLastIndex = 0;
            char secondChar = FindNextChar(str, firstChar, firstCharLastIndex, out int secondCharLastIndex);
            string longestString = string.Empty;
            string tempString = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (firstChar == str[i])
                {
                    tempString += str[i];
                    firstCharLastIndex = i;
                }
                else if (secondChar == str[i])
                {
                    tempString += str[i];
                    secondCharLastIndex = i;
                }
                else
                {
                    longestString = tempString.Length > longestString.Length ? tempString : longestString;
                    firstChar = str[Math.Max(firstCharLastIndex, secondCharLastIndex)];
                    firstCharLastIndex = Math.Min(firstCharLastIndex, secondCharLastIndex) + 1;
                    i = firstCharLastIndex;
                    tempString = string.Empty + str[i];
                    secondChar = FindNextChar(str, firstChar, firstCharLastIndex, out secondCharLastIndex);
                }
            }

            longestString = tempString.Length > longestString.Length ? tempString : longestString;

            Console.WriteLine("The longest substring containing only two symbols is: {0}", longestString);
        }

        private static char FindNextChar(string str, char firstChar, int firstIndex, out int secondIdex)
        {
            char ch = firstChar;
            secondIdex = 0;

            for (int i = firstIndex; i < str.Length; i++)
            {
                if (str[i] != firstChar)
                {
                    ch = str[i];
                    secondIdex = i;
                    break;
                }
            }

            return ch;
        }
    }
}