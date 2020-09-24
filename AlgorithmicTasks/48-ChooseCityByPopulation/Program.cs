using System;
using System.Collections.Generic;
using System.Linq;

namespace _48_ChooseCityByPopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#CityByPopulation" + Environment.NewLine);

            List<KeyValuePair<string, int>> cityAndPopulation = new List<KeyValuePair<string, int>>
            {
                //new KeyValuePair<string, int>("Sofia", 1263328),
                new KeyValuePair<string, int>("Stara Zagora", 150081),
                new KeyValuePair<string, int>("Varna", 350064),
                new KeyValuePair<string, int>("Blagoevgrad", 69178),
                new KeyValuePair<string, int>("Simitli", 6334),
                new KeyValuePair<string, int>("Burgas", 203299),
                new KeyValuePair<string, int>("Plovdiv", 347851)
            };
            PrintCities(cityAndPopulation);

            int[] population = new int[cityAndPopulation.Count];
            int wholePopulation = cityAndPopulation.Select(item => item.Value).ToArray().Sum();
            Random rand = new Random();
            int pop = rand.Next(wholePopulation);
            Console.WriteLine($"Random number population: {pop}");

            for (int i = 0; i < population.Length; i++)
            {
                wholePopulation -= cityAndPopulation[i].Value;
                population[i] = wholePopulation;
            }

            for (int i = 0; i < population.Length; i++)
            {
                if (pop > population[i])
                {
                    Console.WriteLine($"{cityAndPopulation[i].Key} : {cityAndPopulation[i].Value}");
                    break;
                }
            }
        }

        private static void PrintCities(List<KeyValuePair<string, int>> cityAndPopulation)
        {
            for (int i = 0; i < cityAndPopulation.Count; i++)
            {
                Console.WriteLine($"City: {cityAndPopulation[i].Key} | Population: {cityAndPopulation[i].Value}");
            }
        }
    }
}
