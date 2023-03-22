using Day4_Task2.Model;

namespace Day4_Task2.Filters
{
    public class Filtering : Filters
    {
        public override List<Weather> FilteringByTemp(List<Weather> weather, int amount, string input)
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

        public override List<Weather> FilteringCountryName(List<Weather> weather, string country, string input)
        {
            List<Weather> filteredList = new List<Weather>();
            if (input == "1")
            {
                foreach (var item in weather)
                {
                    if (item.Country.ToLower() == country.ToLower())
                    {
                        filteredList.Add(item);
                    }
                }
            }
            else if (input == "2")
            {
                foreach (var item in weather)
                {
                    if (item.Country.Substring(0,1).ToLower() == country.ToLower())
                    {
                        filteredList.Add(item);
                    }
                }
            }
            return filteredList;
        }
    }
}
