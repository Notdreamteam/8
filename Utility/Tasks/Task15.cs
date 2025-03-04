using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task15
    {
        public double X { get; }
        public double Y { get; }

        public Task15(double x, double y)
        {
            X = x;
            Y = y;
        }

        public string Quarter()
        {
            if (X < 0 && Y < 0) return "Данная точка в четвертой четверти";
            else return "Данная точка не в четвертой четверти";
        }
    }
}
