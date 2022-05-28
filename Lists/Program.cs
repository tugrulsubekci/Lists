using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };

            citiesList.Add("New York City");

            citiesList.Remove("Dubai");

            citiesList.AddRange(new string[] { "Cairo", "Johannesburg" });

            bool hasNewDelhi = citiesList.Contains("New Delhi");

            Console.WriteLine(hasNewDelhi);
            Console.WriteLine("--------------------------------");

            foreach (string city in citiesList)
            {
                Console.WriteLine(city);
            }

            //Creating and Adding
            List<double> marathons = new List<double>();

            marathons.Add(144.07);
            marathons.Add(143.12);

            Console.WriteLine(marathons[1]);
            Console.WriteLine("--------------------------------");

            //Object Initialization
            List<double> marathonss = new List<double> {144.07,143.12,146.73,146.33};

            double time = marathonss[1];

            Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");
            Console.WriteLine("--------------------------------");

            //Count and Contains
            Console.WriteLine(marathonss.Count);

            marathonss.Add(143.23);

            bool IsAdded = marathonss.Contains(143.23);

            Console.WriteLine(IsAdded);

            Console.WriteLine(marathonss.Count);
            Console.WriteLine("--------------------------------");

            // Removing
            List<double> marathons2 = new List<double> {144.07,143.12,146.73,146.33};

            Console.WriteLine(marathons2[1]);
            bool removed = marathons2.Remove(143.12);
            Console.WriteLine($"bool removed: {removed}\nsecond element: {marathons2[1]}");
            Console.WriteLine("--------------------------------");

            // Clearing
            marathons2.Clear();
            Console.WriteLine($"Count: {marathons2.Count}");
            Console.WriteLine("--------------------------------");

            //Working with Ranges
            List<string> places = new List<string>() { "first","second" };

            places.AddRange(new string[] { "fifth", "sixth" });
            foreach (string place in places)
            {
                Console.WriteLine(place);
            }
            Console.WriteLine("--------------------------------");

            places.InsertRange(2, new string[] { "third", "fourth" });
            foreach (string place in places)
            {
                Console.WriteLine(place);
            }
            Console.WriteLine("--------------------------------");

            places.RemoveRange(4, 2);
            foreach (string place in places)
            {
                Console.WriteLine(place);
            }
            Console.WriteLine("--------------------------------");

            List<string> newPlaces = places.GetRange(0, 3);
            foreach (string place in newPlaces)
            {
                Console.WriteLine(place);
            }
            Console.WriteLine("--------------------------------");

            List<double> marathons3 = new List<double>{144.07,143.12,146.73,146.33};

            List<double> topMarathons = marathons3.GetRange(0, 3);

            foreach (double time1 in topMarathons)
            {
                Console.WriteLine(time1);
            }
            Console.WriteLine("--------------------------------");

            // Looping through Lists
            List<string> runners = new List<string> { "Jemima Sumgong", "Tiki Gelana", "Constantina Tomescu", "Mizuki Noguchi" };
            Random rand = new Random();

            Console.WriteLine("In reverse chronological order, the gold medalists are...");

            // First loop
            for (int i = 0; i < runners.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {runners[i]}");
            }

            Console.WriteLine("\nPrinting runner bibs...");

            // Second loop
            for (int i = 0; i < runners.Count; i++)
            {
                string name = runners[i].ToUpper();
                int id = rand.Next(100, 1000);
                Console.WriteLine($"{id} - {name}");
            }
            Console.WriteLine("--------------------------------");

            // Second loop with foreach
            foreach (string runner in runners)
            {
                string name = runner.ToUpper();
                int id = rand.Next(100,1000);
                Console.WriteLine($"{id} - {name}");
            }

            // to keep console open
            Console.ReadLine();

        }
    }
}
