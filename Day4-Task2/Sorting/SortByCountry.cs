using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day4_Task2.Classes;

namespace Day4_Task2.Sorting
{
    public class SortByCountry : Sort
    {
        public override List<Weather> Sorting(List<Weather> weather)
        {
            var size = weather.Count;
            for (int i = 0; i < size - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (string.Compare(weather[j].Country, weather[smallestVal].Country) < 0)
                    {
                        smallestVal = j;
                    }
                }
                var temp = weather[smallestVal];
                weather[smallestVal] = weather[i];
                weather[i] = temp;
            }
            return weather;
        }
    }
}
