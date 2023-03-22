using Day4_Task2.Interfaces;
using Day4_Task2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Task2.Paging
{
    public class Pagination : IPagination
    {
        public void Paging(List<Weather> weather, int NumOfRecordsPerPage) 
        {
            bool terminate = true;
            List<Weather> filteredByTemperature = weather;
            int TotalRecords, NumberOfRecordsPerPage = NumOfRecordsPerPage;
            int TotalPages;


            TotalRecords = filteredByTemperature.Count;
            TotalPages = TotalRecords / NumberOfRecordsPerPage;

            if (TotalRecords % NumberOfRecordsPerPage > 0)
                TotalPages++;

            Console.WriteLine("\nType 'next' for next page.\nType 'previous' for previous page.\nType 't' for terminating.\n" +
                              "Type 'first' for first page.\nType 'last' for last page.\n");

            Console.WriteLine("\nTotal Pages:{0}\n", TotalPages);

            int currentPage = 1;
            while (terminate)
            {
                List<Weather> list = filteredByTemperature.ToList();

                int i, j;
                Console.WriteLine("\n=====Page No:{0}===== \n", currentPage);
                i = (currentPage - 1) * NumberOfRecordsPerPage;
                int start = i;
                int end = 0;
                j = currentPage * NumberOfRecordsPerPage;
                for (; i < j; i++)
                {
                    if (i >= TotalRecords)
                    {
                        break;
                    }
                    Console.WriteLine($"{list[i].Country}, {list[i].ZipCode}, {list[i].City}, {list[i].Temperature}, {list[i].WindSpeed}");

                    end = i;
                }

                Console.WriteLine("\nRecords Showing From {0} to {1}\n", (start + 1), (end + 1));
                Console.WriteLine("=====End of Page=====\n");

                string userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "next":
                        currentPage++;
                        if (currentPage > TotalPages)
                        {
                            currentPage = TotalPages;
                            Console.WriteLine("\n=====You are one the last page====");
                        }
                        break;
                    case "previous":
                        currentPage--;
                        if (currentPage <= 0)
                        {
                            currentPage = 1;
                            Console.WriteLine("\n====You are on the first page====");
                        }
                        break;
                    case "first":
                        currentPage = 1;
                        break;
                    case "last":
                        currentPage = TotalPages;
                        break;
                    case "t":
                        terminate = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

            }
        }
    }
}
