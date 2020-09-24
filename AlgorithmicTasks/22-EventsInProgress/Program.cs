using System;
using System.Collections.Generic;
using System.Linq;

namespace _22_EventsInProgress
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Source: http://www.informatika.bg/interviews#SchedulingProblem" + Environment.NewLine);

            List<int[]> events = new List<int[]>() { new int[] { 0, 13 }, new int[] { 2, 5 }, new int[] { 4, 6 }, new int[] { 5, 6 },
                new int[] { 5, 9 }, new int[] { 8, 14 }, new int[] { 11, 12 }, new int[] { 15, 20 }, new int[] { 14, 20 },
                new int[] { 18, 19 }, new int[] { 16, 18 }, new int[] { 12, 16 }, };
            FindNonOverLappingEvents(events);

            Console.WriteLine("Enter your onw list of events: Type 'Y' and press Enter:");
            string yes = Console.ReadLine().ToLower();

            if (yes == "y")
            {
                EnterEventsList(events);
            }
        }

        private static void PrintEvents(List<int[]> events)
        {
            for (int i = 0; i < events.Count; i++)
            {
                Console.Write(string.Join(", ", events[i]) + "; ");
            }
        }

        private static void EnterEventsList(List<int[]> events)
        {
            events.Clear();
            Console.WriteLine("Please events in the current format 'start hour' - 'end hour' separate by ' ' or '-' (start hour < end hour) " +
                "FROM 0 TO 24!! followed by Enter. Press any other key for exit.");

            while (true)
            {
                string input = Console.ReadLine();

                try
                {
                    int[] array = input.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    if (array.Length != 2)
                    {
                        Console.WriteLine("Wrong input!");
                        continue;
                    }

                    if (array[0] > array[1])
                    {
                        Console.WriteLine("Start hour must be lower than End hour!");
                    }
                    else if (array[0] > 24)
                    {
                        Console.WriteLine("Start hour must be less than 25!");
                    }
                    else if (array[1] > 24)
                    {
                        Console.WriteLine("End hour must be less than 25!");
                    }
                    else
                    {
                        events.Add(array);
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }

            FindNonOverLappingEvents(events);
        }

        private static void FindNonOverLappingEvents(List<int[]> events)
        {
            Console.WriteLine("List of events (start hour - end hour):");
            events.ForEach(arr => Console.Write(string.Join("-", arr) + "; "));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorted list of events (start hour - end hour):");
            events = events.OrderByDescending(arr => arr[1])
                .ThenBy(arr => arr[1] - arr[0])
                .ToList();
            events.ForEach(arr => Console.Write(string.Join("-", arr) + "; "));
            Console.WriteLine();
            Console.WriteLine();

            List<int[]> eventsList = new List<int[]>();
            eventsList.Add(events[0]);

            foreach (int[] nextEvent in events)
            {
                int[] lastEvent = eventsList[eventsList.Count - 1];

                if (nextEvent[1] <= lastEvent[0])
                {
                    eventsList.Add(nextEvent);
                }
                else if (nextEvent[1] == lastEvent[1] && nextEvent[0] > lastEvent[0])
                {
                    eventsList[eventsList.Count - 1] = nextEvent;
                }
                else if (nextEvent[1] <= lastEvent[1] && nextEvent[0] > lastEvent[0])
                {
                    eventsList[eventsList.Count - 1] = nextEvent;
                }
            }

            Console.WriteLine("Non-overlapping events (start hour - end hour):");
            eventsList.Reverse();
            eventsList.ToList().ForEach(arr => Console.Write(string.Join("-", arr) + "; "));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}