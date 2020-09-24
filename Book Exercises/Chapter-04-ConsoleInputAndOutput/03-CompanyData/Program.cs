using System;
using System.Text;

namespace _03_CompanyData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: https://introprogramming.info/english-intro-csharp-book/read-online/chapter-4-console-input-and-output/#_Toc362296407");
            Console.WriteLine("Exercise 3" + Environment.NewLine);

            Console.WriteLine("This program takes a company data from the console and prints it.");
            Company company = new Company();
            Console.Write("Enter a company name: ");
            company.CompanyName = GetData();
            Console.Write("Enter a company address: ");
            company.CompanyAddress = GetData();
            Console.Write("Enter a company phone number: ");
            company.CompanyPhone = GetData();
            Console.Write("Enter a company fax number: ");
            company.CompanyFax = GetData();
            Console.Write("Enter a company web site: ");
            company.CompanySite = GetData();

            Manager manager = new Manager();
            Console.Write("Enter a manager name: ");
            manager.ManagerName = GetData();
            Console.Write("Enter a company surname: ");
            manager.ManagerSurname = GetData();
            Console.Write("Enter a manager phone number: ");
            manager.ManagerPhone = GetData();
            company.Manager = manager;
            Console.WriteLine(company);
        }

        private static string GetData()
        {
            string input = Console.ReadLine();

            if (input == string.Empty || input == null)
            {
                Console.WriteLine("Please enter the required information.");
                input = GetData();
            }

            return input;
        }
    }

    class Company
    {
        public Company()
        {

        }

        public string CompanyName { get; set; }

        public string CompanyAddress { get; set; }

        public string CompanyPhone { get; set; }

        public string CompanyFax { get; set; }

        public string CompanySite { get; set; }

        public Manager Manager { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Company");
            sb.AppendLine($"Name: {this.CompanyName}");
            sb.AppendLine($"Address: {this.CompanyAddress}");
            sb.AppendLine($"Phone number: {this.CompanyPhone}");
            sb.AppendLine($"Fax number: {this.CompanyFax}");
            sb.AppendLine($"Company site: {this.CompanySite}");
            sb.AppendLine($"Manager");
            sb.AppendLine(this.Manager.ToString());

            return sb.ToString();
        }
    }

    class Manager
    {
        public Manager()
        {

        }

        public string ManagerName { get; set; }

        public string ManagerSurname { get; set; }

        public string ManagerPhone { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.ManagerName}");
            sb.AppendLine($"Surname: {this.ManagerSurname}");
            sb.AppendLine($"Phone number: {this.ManagerPhone}");

            return sb.ToString();
        }
    }
}