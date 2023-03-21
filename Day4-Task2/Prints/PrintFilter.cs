using Day4_Task2.Classes;
using Day4_Task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Task2.Prints
{
    public class PrintFilter : IPrintable
    {
        public void ToString(List<Weather> weather)
        {
            foreach(var item in weather)
            {
                Console.WriteLine($"{item.Country},{item.ZipCode}, {item.City}, {item.Temperature}, {item.WindSpeed}");
            }
        }
    }
}
