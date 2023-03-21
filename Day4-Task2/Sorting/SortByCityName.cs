using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day4_Task2.Classes;

namespace Day4_Task2.Sorting
{
    public class SortByCityName : Sort
    {
        public override List<Weather> Sorting(List<Weather> weather)
        {
            int size = weather.Count;
            for (int i = 0; i < size - 1; i++)
                for (int j = 0; j < size - i - 1; j++)
                    if (weather[j].City.CompareTo(weather[j + 1].City) > 0)
                    {
                        (weather[j + 1], weather[j]) = (weather[j], weather[j + 1]);
                    }

            return weather;
        }
    }
}
