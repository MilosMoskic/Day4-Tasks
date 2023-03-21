using Day4_Task2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Task2.Filters
{
    public class FilterByTemperature : Filters
    {
        public override List<Weather> Filtering(List<Weather> weather, int amount, string input)
        {
            List<Weather> filteredList = new List<Weather>();
            if(input == "1")
            {
                foreach(var item in weather)
                {
                    if(item.Temperature == amount)
                    {
                        filteredList.Add(item);
                    }
                }
            }else if(input == "2")
            {
                foreach (var item in weather)
                {
                    if (item.Temperature > amount)
                    {
                        filteredList.Add(item);
                    }
                }
            }
            else if(input == "3")
            {
                foreach (var item in weather)
                {
                    if (item.Temperature < amount)
                    {
                        filteredList.Add(item);
                    }
                }
            }
            return filteredList;
        }
    }
}
