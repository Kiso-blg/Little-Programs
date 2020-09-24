using System;

namespace _24_TextAndStrings
{
    class Program
    {      
        static void Main()
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#TextAndStrings" + Environment.NewLine);

            string str1 = "what";
            string str2 = "class";
            string str3 = "difference";

            int maxLength = str1.Length + str2.Length + str3.Length;
            int[] positions = new int[3];
            int startIndex = 0;
            int endIndex = maxLength - 1;
            string shortestSubText = text + " .";

            while (startIndex < text.Length - maxLength && endIndex <= text.Length)
            {
                string subText = text.Substring(startIndex, endIndex - startIndex).ToLower();

                bool doesContainWords = CheckIfContainsWords(subText, str1, str2, str3);

                if (doesContainWords)
                {
                    if (subText.Length < shortestSubText.Length)
                    {
                        shortestSubText = text.Substring(startIndex, endIndex - startIndex);
                        positions[0] = subText.IndexOf(str1) + startIndex;
                        positions[1] = subText.IndexOf(str2) + startIndex;
                        positions[2] = subText.IndexOf(str3) + startIndex;
                    }

                    startIndex++;
                }
                else
                {
                    endIndex++;
                }
            }

            if (shortestSubText.Length <= text.Length)
            {
                Console.WriteLine($"Shortest excerpt from thest is \"{shortestSubText}\".");
                Console.WriteLine($"String \"{str1}\" at index {positions[0]}");
                Console.WriteLine($"String \"{str2}\" at index {positions[1]}");
                Console.WriteLine($"String \"{str3}\" at index {positions[2]}");
            }
            else
            {
                Console.WriteLine("The text does not contains one or more of the words.");
            }
        }

        private static bool CheckIfContainsWords(string subText, string str1, string str2, string str3)
        {
            string[] strArray = subText.Split(new char[] { ' ', ',', '.', '-', '_', ';', ':', '+', '!', '?', '=' }, StringSplitOptions.RemoveEmptyEntries);
            bool containStr1 = false;
            bool containStr2 = false;
            bool containStr3 = false;

            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i] == str1)
                {
                    containStr1 = true;
                }

                if (strArray[i] == str2)
                {
                    containStr2 = true;
                }

                if (strArray[i] == str3)
                {
                    containStr3 = true;
                }
            }

            return containStr1 && containStr2 && containStr3;
        }

        //        static readonly string text2 = @"Read the following articles to learn more about structs vs classes, struct and class Differences in C#. 

        //6. What is the difference between Interface and Abstract Class in C#?";
        //        static readonly string text3 = @"class Difference in What";

        static readonly string text = @"clas what difference Struct

	The struct is a value type in C# and it inherits from System.Value Type.
	Struct is usually used for smaller amounts of data.
	Struct can’t be inherited from other types.
	A structure can't be abstract.
	No need to create an object with a new keyword.
	Do not have permission to create any default constructor.
	
Class

	The class is a reference type in C# and it inherits from the System.Object Type.
	Classes are usually used for large amounts of data.
	Classes can be inherited from other classes.
	A class can be an abstract type.
	We can create a default constructor.
	
5. What is the difference between a struct and a class in C#? 

Class and struct are both user-defined data types, but have some major differences:

Struct

	The struct is a value type in C# and it inherits from System.Value Type.
	Struct is usually used for smaller amounts of data.
	Struct can’t be inherited from other types.
	A structure can't be abstract.
	No need to create an object with a new keyword.
	Do not have permission to create any default constructor.
	
Class

	The class is a reference type in C# and it inherits from the System.Object Type.
	Classes are usually used for large amounts of data.
	Classes can be inherited from other classes.
	A class can be an abstract type.
	We can create a default constructor.
	
Read the following articles to learn more about structs vs classes, struct and class Differences in C#. 

6. What is the difference between Interface and Abstract Class in C#? 

Here are some of the common differences between an interface and an abstract class in C#.

	A class can implement any number of interfaces but a subclass can at most use only one abstract class.
	An abstract class can have non-abstract methods (concrete methods) while in case of interface, all the methods have to be abstract.
	An abstract class can declare or use any variables while an interface is not allowed to do so.
	In an abstract class, all data members or functions are private by default while in an interface all are public, we can’t change them manually.
	In an abstract class, we need to use abstract keywords to declare abstract methods, while in an interface we don’t need to use that.
	An abstract class can’t be used for multiple inheritance while the interface can be used as multiple inheritance.
	An abstract class use constructor while in an interface we don’t have any type of constructor.
	
To learn more about the difference between an abstract class and an interface, visit Abstract Class vs Interface. class what differenc";
    }
}