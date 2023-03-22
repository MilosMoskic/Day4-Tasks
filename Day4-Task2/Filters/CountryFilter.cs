using Day4_Task2.Interfaces;
using Day4_Task2.Model;
using Day4_Task2.Prints;
using Day4_Task2.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Task2.Filters
{
    internal class CountryFilter : IFilterBySomething
    {
        public List<Weather> Filter(List<Weather> weather)
        {
            Sort sortByCountry = new SortByTemperature();

            Filters filter = new Filtering();

            List<Weather> sortedbyCountry = sortByCountry.Sorting(weather);

            bool terminate = true;

            while (terminate)
            {
                Console.WriteLine("\nInsert 1 if you want to filter countries by exact name.\n" +
                                  "Insert 2 if you want to filter countries by first letter.\n");

                string key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.WriteLine("\nInsert country: ");
                        string input = Console.ReadLine();
                        sortedbyCountry = filter.FilteringCountryName(weather, input, "1");
                        terminate = false;
                        break;
                    case "2":
                        Console.WriteLine("\nInsert first letter of country: ");
                        string input1 = Console.ReadLine();
                        sortedbyCountry = filter.FilteringCountryName(weather, input1, "2");
                        terminate = false;
                        break;
                    default:
                        Console.WriteLine("Invalid key.");
                        break;
                }
            }

            return sortedbyCountry;
        }
    }
}
