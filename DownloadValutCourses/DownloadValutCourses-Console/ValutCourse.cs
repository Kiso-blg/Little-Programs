namespace DownloadValutCourses_Console
{
    public class ValutCourse
    {
        public ValutCourse(string country, string countryCode, string unitsCount, string unitRate, string reversedUnitRate)
        {
            this.Country = country;
            this.CountryCode = countryCode;
            this.UnitsCount = unitsCount;
            this.UnitRate = unitRate;
            this.ReversedUnitRate = reversedUnitRate;
        }

        public string Country { get; set; }

        public string CountryCode { get; set; }

        public string UnitsCount { get; set; }

        public string UnitRate { get; set; }

        public string ReversedUnitRate { get; set; }
    }
}