using Day4_Task2.Classes;
using Day4_Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Task2.Prints
{
    public class PrintWeatherByCountries : IPrintable
    {
        public void ToString(List<Weather> weather)
        {
            Console.WriteLine("\nWeather sorted by Countries (alphabetically):\n");

            foreach (var item in weather)
            {
                Console.WriteLine($"{item.Country}, {item.City}, {item.Temperature}, {item.WindSpeed}");
            }
        }
    }
}
