using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DownloadValutCourses_Form
{
    [XmlRoot("ValutCoursesList", Namespace = "http://www.yoursite.com", IsNullable = false)]
    public class ValutCoursesList
    {
        [XmlArray("ValutCoursesList"), XmlArrayItem(typeof(ValutCourse), ElementName = "ValutCourse")]
        private readonly List<ValutCourse> valutCourses = new List<ValutCourse>();

        public List<ValutCourse> ValutCourses
        {
            get
            {
                return this.valutCourses;
            }
        }

        public int Count
        {
            get
            {
                return this.valutCourses.Count;
            }
        }

        public byte ElementsCount
        {
            get
            {
                return 5;
            }
        }

        public ValutCourse GetValutCourse(int element)
        {
            return this.valutCourses[element];
        }

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
                throw new NullReferenceException("ERROR! ValutCourses not found.");
            }

            while (IsElementDecimal(splitedSite[index + 4]))
            {
                this.valutCourses.Add(new ValutCourse(splitedSite[index], splitedSite[index + 1],
                    splitedSite[index + 2], splitedSite[index + 3], splitedSite[index + 4]));
                index += 5;
            }

            this.valutCourses.Add(new ValutCourse(splitedSite[index], splitedSite[index + 1],
                    splitedSite[index + 2], splitedSite[index + 3], string.Empty));
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
                        if (IsElementInt(splitedSite[i + 2]))
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

        private static bool IsElementInt(string element)
        {
            if (byte.TryParse(element, out byte intValue))
            {
                return true;
            }

            return false;
        }

        private static bool IsElementDecimal(string element)
        {
            if (decimal.TryParse(element, out decimal decValue))
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