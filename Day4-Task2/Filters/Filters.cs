using Day4_Task2.Model;

namespace Day4_Task2.Filters
{
    public abstract class Filters
    {
        public abstract List<Weather> FilteringByTemp(List<Weather> weather, int amount, string input);

        public abstract List<Weather> FilteringCountryName(List<Weather> weather, string country, string input);
    }
}
