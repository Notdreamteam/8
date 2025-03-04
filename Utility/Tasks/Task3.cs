using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task3
    {
        public double X { get; }
        public double Y { get; }

        public Task3(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool Belongs(double R)
        {
            return Math.Pow(X - 0, 2) + Math.Pow(Y - 0, 2) <= Math.Pow(R, 2);
        }
    }
}
