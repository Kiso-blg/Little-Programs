using System;

namespace _12_EmployeeDataRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-2-primitive-types-and-variables/#_Toc362296391");
            Console.WriteLine("Exercise 12" + Environment.NewLine);

            Console.Write("Enter employee's first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter employee's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter employee's age: ");
            byte age = GetAge();
            Console.Write("Enter employee's gender: ");
            char gender = GetGender();
            Console.Write("Enter employee's unique number: ");
            int uniqueEmployeeNumber = GetUEN();

            Employee employee = new Employee(firstName, lastName, age, gender, uniqueEmployeeNumber);
            Console.WriteLine(employee);
        }

        private static int GetUEN()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Incorrect input. Try again.");
                number = GetUEN();
            }

            while (!(number >= 27560000 && number < 27570000))
            {
                Console.WriteLine("Incorrect input. Try again.");
                number = GetUEN();
            }

            return number;
        }

        private static char GetGender()
        {
            string input = Console.ReadLine().ToLower();

            if (!char.TryParse(input, out char gender))
            {
                Console.WriteLine("Incorrect input. Try again.");
                gender = GetGender();
            }

            while (!(gender == 'm' || gender == 'f'))
            {
                Console.WriteLine("Incorrect input. Enter you gender again.");
                gender = GetGender();
            }

            return gender;
        }

        private static byte GetAge()
        {
            string input = Console.ReadLine();

            if (!byte.TryParse(input, out byte age))
            {
                Console.WriteLine("Incorrect input. Try again.");
                age = GetAge();
            }

            return age;
        }
    }

    class Employee
    {
        public Employee(string firstName, string lastName, byte age, char gender, int uniqueNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;
            this.UniqueNumber = uniqueNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public char Gender { get; set; }
        public int UniqueNumber { get; set; }

        public override string ToString()
        {
            string data = $"Firs name: {this.FirstName}" + Environment.NewLine;
            data += $"Last name: {this.LastName}" + Environment.NewLine;
            data += $"Age: {this.Age}" + Environment.NewLine;
            data += $"Gender: {this.Gender}" + Environment.NewLine;
            data += $"Employee number: {this.UniqueNumber}";

            return data;
        }
    }
}