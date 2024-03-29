﻿namespace Day4_Task2.Model
{
    public class Weather
    {
        public string Country { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public int Temperature { get; set; }
        public decimal WindSpeed { get; set; }

        public Weather(string country, int zipcode, string city, int temperature, decimal windspeed)
        {
            Country = country;
            ZipCode = zipcode;
            City = city;
            Temperature = temperature;
            WindSpeed = windspeed;
        }
    }
}
