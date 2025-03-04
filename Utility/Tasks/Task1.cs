using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task1
    {
        public double X { get; }
        public double Y { get; }

        public Task1(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool IsInArea()
        {
            double parabolaY = 2 - X * X;
            return Y >= 0 && Y <= parabolaY;
        }
    }
}
