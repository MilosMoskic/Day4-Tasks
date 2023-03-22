using Day4_Task2.Filters;
using Day4_Task2.Model;
using Day4_Task2.Paging;
using Day4_Task2.Prints;
using Day4_Task2.Searching;
using Day4_Task2.Sorting;

class Program
{
    static void Main(string[] args)
    {
        #region WeatherData
        List<Weather> weather = new List<Weather>
        {
             new Weather("Serbia", 21000, "Novi Sad", 8, 2.68M),
             new Weather("Serbia", 11000, "Belgrade", 17, 3.13M),
             new Weather("Serbia", 26300, "Vrsac", 20, 10.99M),
             new Weather("Serbia", 26300, "Pancevo", 18, 7.13M),
             new Weather("Serbia", 25000, "Kragujevac", 15, 2.54M),
             new Weather("Slovenia", 43000, "Ljubljana", 19, 5.22M),
             new Weather("Croatia", 11044, "Zagreb", 3, 2.13M),
             new Weather("Croatia", 11055, "Dubrovnik", 30, 3.2M),
             new Weather("Germany", 80335, "Munich", 24, 3.6M),
             new Weather("Sweden", 10316, "Stockholm", 4, 5.81M),
             new Weather("Sweden", 10317, "Malmo", 19, 8.13M),
             new Weather("UK", 56273, "London", 2, 1.54M),
             new Weather("France", 70213, "Paris", 27, 2.68M),
             new Weather("Italy", 30100, "Venice", 17, 2.24M),
             new Weather("Italy", 20019, "Milano", 19, 0.89M),
             new Weather("Serbia", 23000, "Zrenjanin", 9, 0.51M),
             new Weather("Netherland", 10110, "Amsterdam", 9, 4.12M)
        };
        #endregion
        
        #region Varibales
        Sort sortByTemp = new SortByTemperature();
        List<Weather> sortedbyTemp = sortByTemp.Sorting(weather);
        List<Weather> filteredByTemperature = new List<Weather>();

        Sort sortByCountries = new SortByCountry();
        List<Weather> sortedbyCountry = sortByCountries.Sorting(weather);
        List<Weather> filteredByCountry = sortedbyCountry;

        TemperatureFilter temperatureFilter = new TemperatureFilter();
        CountryFilter countryFilter = new CountryFilter();
        Pagination pagination = new Pagination();

        bool terminate = true;
        #endregion

        Console.WriteLine("\nInsert T if you want to filter weather by Temperature.\n" +
                          "Insert C if you want to filter weather by Countries..\n" +
                          "Insert E if you want to exit program.\n");

        while (terminate)
        {
            string userInput = Console.ReadLine().ToLower();
            switch(userInput)
            {
                case "t":
                    filteredByTemperature = temperatureFilter.Filter(sortedbyTemp);
                    Console.WriteLine("\nHow many records do you want to list by page? \n");
                    int NumberOfRecordsPerPage1 = Convert.ToInt32(Console.ReadLine());
                    pagination.Paging(filteredByTemperature, NumberOfRecordsPerPage1);
                    break;
                case "c":
                    filteredByCountry = countryFilter.Filter(sortedbyCountry);
                    Console.WriteLine("\nHow many records do you want to list by page? \n");
                    int NumberOfRecordsPerPage2 = Convert.ToInt32(Console.ReadLine());
                    pagination.Paging(filteredByCountry, NumberOfRecordsPerPage2);
                    break;
                case "e":
                    terminate = false;
                    break;
                default:
                    Console.WriteLine("Invalid key.");
                    break;
            }
        }

    }
}

    
