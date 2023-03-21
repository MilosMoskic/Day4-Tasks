using Day4_Task2.Classes;
using Day4_Task2.Prints;
using Day4_Task2.Searching;
using Day4_Task2.Sorting;

class Program
{
    static void Main(string[] args)
    {

        List<Weather> weather = new List<Weather>
        {
             new Weather("Serbia", 21000, "Novi Sad", 8, 2.68M),
             new Weather("Serbia", 11000, "Belgrade", 17, 3.13M),
             new Weather("Germany", 80335, "Munich", 24, 3.6M),
             new Weather("Sweden", 10316, "Stockholm", 4, 5.81M),
             new Weather("UK", 56273, "London", 2, 1.54M),
             new Weather("France", 70213, "Paris", 27, 2.68M),
             new Weather("Italy", 30100, "Venice", 17, 2.24M),
             new Weather("Italy", 20019, "Milano", 19, 0.89M),
             new Weather("Serbia", 23000, "Zrenjanin", 9, 0.51M),
             new Weather("Netherland", 10110, "Amsterdam", 9, 4.12M)
        };

        //Sort sortByTemp = new SortByTemperature();
        //Sort sortByCity = new SortByCityName();
        //Sort sortByCountry = new SortByCountry();
        //Sort sortByWindSpeed = new SortByWindSpeed();
        Sort sortByZipCode = new SortByZipCode();
        ZipCodeSearch zipCodeSearch = new ZipCodeSearch();
        //PrintWeatherByTemperature printWeatherByTemp = new PrintWeatherByTemperature();
        //PrintWeatherByCities printWeatherByCity = new PrintWeatherByCities();
        //PrintWeatherByCountries printWeatherByCountry = new PrintWeatherByCountries();
        //PrintWeatherByWindSpeed printWeatherByWindSpeed = new PrintWeatherByWindSpeed();
        PrintWeatherByZipCode printweatherByZipCode = new PrintWeatherByZipCode();


        //List<Weather> sortedbyTemp = sortByTemp.Sorting(weather);

        //printWeatherByTemp.ToString(sortedbyTemp);

        //Console.WriteLine();

        //List<Weather> sortedByCity = sortByCity.Sorting(weather);

        //printWeatherByCity.ToString(sortedByCity);

        //List<Weather> sortedByCountry = sortByCountry.Sorting(weather);

        //printWeatherByCountry.ToString(sortedByCountry);

        //List<Weather> sortedByWindSpeed = sortByWindSpeed.Sorting(weather);

        //printWeatherByWindSpeed.ToString(sortedByWindSpeed);

        List<Weather> sortedByZipCode = sortByZipCode.Sorting(weather);

        printweatherByZipCode.ToString(sortedByZipCode);

        Console.WriteLine("\nEnter Zip Code: ");

        int zipcode = Convert.ToInt32(Console.ReadLine());

        int result = zipCodeSearch.ZipCodeSearching(sortedByZipCode, zipcode);
        if(result == 1)
        {
            int index = weather.FindIndex(a => a.ZipCode == zipcode);
            Weather resultWeather = weather[index];
            Console.WriteLine($"{resultWeather.Country}, {resultWeather.ZipCode}," +
                $" {resultWeather.City}, {resultWeather.Temperature}, {resultWeather.WindSpeed}");
        }
    }
        
}