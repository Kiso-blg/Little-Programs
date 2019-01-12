using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DownloadValutCourses_Console
{
    public class ValutCoursesList
    {
        private readonly List<ValutCourse> valutCourses = new List<ValutCourse>();

        public void AddElement(ValutCourse course)
        {
            this.valutCourses.Add(course);
        }

        public void GetValutCourses(string text)
        {
            List<string> splitedSite = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(element => element.Trim())
                .Where(element => element != string.Empty)
                .ToList();

            int index = FindCollectionsStart(splitedSite);

            if (index == -1)
            {
                Executor.StopProccessing();
                Console.WriteLine("ERROR! ValutCourses not found.");
                return;
            }

            while (IsElementDecimal(splitedSite[index + 4]))
            {
                this.valutCourses.Add(new ValutCourse(splitedSite[index], splitedSite[index + 1],
                    splitedSite[index + 2], splitedSite[index + 3], splitedSite[index + 4]));
                index += 5;
            }

            this.valutCourses.Add(new ValutCourse(splitedSite[index], splitedSite[index + 1],
                    splitedSite[index + 2], splitedSite[index + 3], string.Empty));
            Executor.StopProccessing();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine('|' + "Country".PadRight(25) +
                '\0' + "Code".PadLeft(5) +
                '\0' + "Units count".PadLeft(11) +
                '\0' + "Leva".PadLeft(10) +
                '\0' + "Reverse course".PadLeft(15) + '|');

            foreach (ValutCourse course in this.valutCourses)
            {
                sb.AppendLine('|' + course.Country.PadRight(25) +
                '|' + course.CountryCode.PadLeft(5) +
                '|' + course.UnitsCount.PadLeft(11) +
                '|' + course.UnitRate.PadLeft(10) +
                '|' + course.ReversedUnitRate.PadLeft(15) + '|');
            }

            return sb.ToString();
        }

        private static int FindCollectionsStart(List<string> splitedSite)
        {
            for (int i = 0; i < splitedSite.Count; i++)
            {
                if (i + 4 <= splitedSite.Count)
                {
                    if (IsUpperString(splitedSite[i + 1]))
                    {
                        if (isElementInt(splitedSite[i + 2]))
                        {
                            if (IsElementDecimal(splitedSite[i + 3]))
                            {
                                if (IsElementDecimal(splitedSite[i + 4]))
                                {
                                    return i;
                                }
                            }
                        }
                    }
                }
            }

            return -1;
        }

        private static bool isElementInt(string element)
        {
            int intValue;

            if (int.TryParse(element, out intValue))
            {
                return true;
            }

            return false;
        }

        private static bool IsElementDecimal(string element)
        {
            decimal decValue;

            if (decimal.TryParse(element, out decValue))
            {
                return true;
            }

            return false;
        }

        private static bool IsUpperString(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];

                if (!char.IsUpper(letter))
                {
                    return false;
                }
            }

            return true;
        }        
    }
}