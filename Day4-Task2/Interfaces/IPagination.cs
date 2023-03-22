using Day4_Task2.Model;

namespace Day4_Task2.Interfaces
{
    public interface IPagination
    {
        public void Paging(List<Weather> weather, int NumOfRecordsPerPage);
    }
}
