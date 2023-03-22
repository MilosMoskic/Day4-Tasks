using Day4_Task2.Model;

namespace Day4_Task2.Interfaces
{
    public interface IFilterBySomething
    {
        public List<Weather> Filter(List<Weather> weather);
    }
}
