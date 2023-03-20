using Day4_Task2.Classes;
using Day4_Task2.Prints;

class Program
{
    static void Main(string[] args)
    {

        List<Weather> weather = new List<Weather>
        {
            new Weather("Serbia", "Novi Sad", 8, 2.68M),
            new Weather("Serbia", "Belgrade", 17, 3.13M),
            new Weather("Germany", "Munich", 24, 3.6M),
            new Weather("Sweden", "Stockholm", 4, 5.81M),
            new Weather("UK", "London", 2, 1.54M),
            new Weather("France", "Paris", 27, 2.68M),
            new Weather("Italy", "Venice", 17, 2.24M),
            new Weather("Italy", "Milano", 19, 0.89M),
            new Weather("Serbia", "Zrenjanin", 9, 0.51M),
            new Weather("Netherland", "Amsterdam", 9, 4.12M)
        };

        Sort sortByTemp = new SortByTemperature();
        Sort sortByCity = new SortByCityName();
        PrintWeatherByTemperature printWeatherByTemp = new PrintWeatherByTemperature();
        PrintWeatherByCities printWeatherByCity = new PrintWeatherByCities();

        List<Weather> sortedbyTemp = sortByTemp.Sorting(weather);

        printWeatherByTemp.ToString(sortedbyTemp);

        Console.WriteLine();

        List<Weather> sortedByCity = sortByCity.Sorting(weather);

        printWeatherByCity.ToString(sortedByCity);


    }
        
}