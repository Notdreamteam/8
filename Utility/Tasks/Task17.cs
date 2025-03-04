using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task17
    {
        public double X { get; }
        public double Y { get; }

        public Task17(double x, double y)
        {
            X = x;
            Y = y;
        }

        public string Quarter()
        {
            if (X < 0 && Y > 0) return "Данная точка в первой четверти";
            else return "Данная точка не в первой четверти";
        }
    }
}
