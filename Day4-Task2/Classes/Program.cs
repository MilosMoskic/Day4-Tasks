using Day4_Task2.Classes;
using Day4_Task2.Filters;
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
        PrintFilter printFilter = new PrintFilter();

        Filters filter = new Filtering();

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

        List<Weather> filteredByTemperature = new List<Weather>();
        List<Weather> filteredByCountry = new List<Weather>();

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

        bool terminate = true;





        while (terminate)
        {

            Console.WriteLine("\nInsert 1 if you want to filter temperature by exact temperature.\n" +
                              "Insert 2 if you want to filter temperature by greater than inserted temperature.\n" +
                              "Insert 3 if you want to filter temperature by less than inserted temperature.\n");

            string key = Console.ReadLine();

            switch (key)
            {
                case "1":
                    Console.WriteLine("\nInsert temperature: ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    filteredByTemperature = filter.FilteringByTemp(weather, input, "1");
                    printFilter.ToString(filteredByTemperature);
                    terminate = false;
                    break;
                case "2":
                    Console.WriteLine("\nInsert temperature: ");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    filteredByTemperature = filter.FilteringByTemp(weather, input1, "2");
                    printFilter.ToString(filteredByTemperature);
                    terminate = false;
                    break;
                case "3":
                    Console.WriteLine("\nInsert temperature: ");
                    int input2 = Convert.ToInt32(Console.ReadLine());
                    filteredByTemperature = filter.FilteringByTemp(weather, input2, "3");
                    printFilter.ToString(filteredByTemperature);
                    terminate = false;
                    break;
                default:
                    Console.WriteLine("Invalid Key.");
                    break;
            }
        }

        terminate = true;

        Console.WriteLine("\nInsert 1 if you want to filter temperature by exact name.\n" +
                          "Insert 2 if you want to filter temperature by first letter.\n");

        while (terminate)
        {

            string key = Console.ReadLine();
            switch(key){
                case"1":
                    Console.WriteLine("\nInsert country: ");
                    string input = Console.ReadLine();
                    filteredByCountry = filter.FilteringCountryName(weather, input, "1");
                    printFilter.ToString(filteredByCountry);
                    terminate = false;
                    break;
                case"2":
                    Console.WriteLine("\nInsert first letter of country: ");
                    string input1 = Console.ReadLine();
                    filteredByCountry = filter.FilteringCountryName(weather, input1, "2");
                    printFilter.ToString(filteredByCountry);
                    terminate = false;
                    break;
                default:
                    Console.WriteLine("Invalid key.");
                    break;
            }
        }
    }
        
}