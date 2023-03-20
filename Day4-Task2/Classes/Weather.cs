using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Task2.Classes
{
    public class Weather
    {
        public string Country { get; set; }
        public string City { get; set; }
        public decimal Temperature { get; set; }
        public decimal WindSpeed { get; set; }

        public Weather(string country, string city, decimal temperature, decimal windspeed)
        {
            Country = country;
            City = city;
            Temperature = temperature;
            WindSpeed = windspeed;
        }
    }
}
