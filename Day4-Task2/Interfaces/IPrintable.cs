using Day4_Task2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Task2.Interfaces
{
    public interface IPrintable
    {
        public void ToString(List<Weather> weather);
    }
}
