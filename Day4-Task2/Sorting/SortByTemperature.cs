using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day4_Task2.Model;

namespace Day4_Task2.Sorting
{
    public class SortByTemperature : Sort
    {
        public override List<Weather> Sorting(List<Weather> weather)
        {
            int size = weather.Count();
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    if (weather[j].Temperature > weather[j + 1].Temperature)
                    {
                        (weather[j + 1], weather[j]) = (weather[j], weather[j + 1]);
                    }
                }
            }

            return weather;
        }
    }
}
