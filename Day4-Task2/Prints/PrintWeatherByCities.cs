using Day4_Task2.Classes;
using Day4_Task2.Interfaces;

namespace Day4_Task2.Prints
{
    public class PrintWeatherByCities : IPrintable
    {
        public void ToString(List<Weather> weather)
        {
            Console.WriteLine("\nWeather sorted by City Names (alphabetically):\n");

            foreach (var item in weather)
            {
                Console.WriteLine($"{item.Country},{item.ZipCode}, {item.City}, {item.Temperature}, {item.WindSpeed}");
            }
        }
    }
}
