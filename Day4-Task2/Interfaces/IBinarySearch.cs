using Day4_Task2.Model;

namespace Day4_Task2.Interfaces
{
    public interface IBinarySearch
    {
        public int BinarySearch(List<Weather> weather, int left, int right, int item_to_find);
    }
}
