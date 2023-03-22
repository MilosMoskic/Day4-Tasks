﻿using Day4_Task2.Interfaces;
using Day4_Task2.Model;

namespace Day4_Task2.Prints
{
    public class PrintWeatherByZipCode : IPrintable
    {
        public void ToString(List<Weather> weather)
        {
            Console.WriteLine("\nWeather sorted by ZipCodes:\n");

            foreach (var item in weather)
            {
                Console.WriteLine($"{item.Country}, {item.ZipCode}, {item.City}, {item.Temperature}, {item.WindSpeed}");
            }
        }
    }
}
