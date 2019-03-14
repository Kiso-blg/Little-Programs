using System;
using System.Xml.Serialization;

namespace DownloadValutCourses_Form
{  
    public class ValutCourse
    {
        public ValutCourse()
        {

        }

        public ValutCourse(string country, string countryCode, string unitsCount, string unitRate, string reversedUnitRate)
        {
            this.Country = country;
            this.CountryCode = countryCode;
            this.UnitsCount = unitsCount;
            this.UnitRate = unitRate;
            this.ReversedUnitRate = reversedUnitRate;
        }

        [XmlAttribute]
        public string Country { get; set; }

        [XmlAttribute]
        public string CountryCode { get; set; }

        [XmlAttribute]
        public string UnitsCount { get; set; }

        [XmlAttribute]
        public string UnitRate { get; set; }

        [XmlAttribute]
        public string ReversedUnitRate { get; set; }
    }
}