using Day4_Task2.Classes;
using Day4_Task2.Interfaces;
using System.Reflection;

namespace Day4_Task2.Searching
{
    public class ZipCodeSearch : IBinarySearch
    { 

        public int ZipCodeSearching(List<Weather> weather, int itemname)
        {
            if(BinarySearch(weather, 0, weather.Count, itemname) != -1)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }
        public int BinarySearch(List<Weather> weather, int left, int right, int item_to_find)
        {
            if (left <= right)
            {
                int middle = (right + left) / 2;

                if (weather[middle].ZipCode == item_to_find)
                {
                    return item_to_find;
                }

                if (weather[middle].ZipCode > item_to_find)
                {
                    return BinarySearch(weather, left, middle - 1, item_to_find);
                }
                else
                {
                    return BinarySearch(weather, middle + 1, right, item_to_find);
                }
            }

            return -1;
        }
    }
}
