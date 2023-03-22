using Day4_Task2.Interfaces;
using Day4_Task2.Model;
using Day4_Task2.Sorting;

namespace Day4_Task2.Filters
{
    public class TemperatureFilter : IFilterBySomething
    {
        public List<Weather> Filter(List<Weather> weather)
        {
            Sort sortByTemp = new SortByTemperature();

            Filters filter = new Filtering();

            List<Weather> sortedbyTemp = sortByTemp.Sorting(weather);

            List<Weather> filteredByTemperature = sortedbyTemp;

            bool terminate = true;

            while (terminate)
            {

                Console.WriteLine("\nInsert 1 if you want to filter temperature by exact temperature.\n" +
                                  "Insert 2 if you want to filter temperature by greater than inserted temperature.\n" +
                                  "Insert 3 if you want to filter temperature by less than inserted temperature.\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("\nInsert temperature: \n");
                        int input = Convert.ToInt32(Console.ReadLine());
                        filteredByTemperature = filter.FilteringByTemp(weather, input, "1");
                        terminate = false;
                        break;
                    case "2":
                        Console.WriteLine("\nInsert temperature: \n");
                        int input1 = Convert.ToInt32(Console.ReadLine());
                        filteredByTemperature = filter.FilteringByTemp(weather, input1, "2");
                        terminate = false;
                        break;
                    case "3":
                        Console.WriteLine("\nInsert temperature: \n");
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        filteredByTemperature = filter.FilteringByTemp(weather, input2, "3");
                        terminate = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Key.");
                        break;

                }
            }

            return filteredByTemperature;
        }
        
    }
}
