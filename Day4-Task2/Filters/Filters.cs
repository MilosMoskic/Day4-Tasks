using Day4_Task2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Task2.Filters
{
    public abstract class Filters
    {
        public abstract List<Weather> FilteringByTemp(List<Weather> weather, int amount, string input);

        public abstract List<Weather> FilteringCountryName(List<Weather> weather, string country, string input);
    }
}
