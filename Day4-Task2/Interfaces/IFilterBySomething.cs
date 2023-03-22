using Day4_Task2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Task2.Interfaces
{
    public interface IFilterBySomething
    {
        public List<Weather> Filter(List<Weather> weather);
    }
}
