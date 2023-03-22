using Day4_Task2.Model;

namespace Day4_Task2.Sorting
{
    public class SortByZipCode : Sort
    {
        public override List<Weather> Sorting(List<Weather> weather)
        {
            QuickSort(weather, 0, weather.Count - 1);
            return weather;
        }

        public void QuickSort(List<Weather> weather, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(weather, left, right);
                QuickSort(weather, left, pivot - 1);
                QuickSort(weather, pivot + 1, right);
            }
        }

        public int Partition(List<Weather> weather, int left, int right)
        {
            decimal pivot = weather[right].ZipCode;
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (weather[j].ZipCode <= pivot)
                {
                    i++;
                    Swap(weather, i, j);
                }
            }
            Swap(weather, i + 1, right);
            return i + 1;
        }

        public void Swap(List<Weather> weather, int i, int j)
        {
            Weather temp = weather[i];
            weather[i] = weather[j];
            weather[j] = temp;
        }
    }
}
