using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task18
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Task18(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Formula()
        {
            if (Math.Abs(X) <= 2) return Math.Pow(X, 2);
            else if (Math.Abs(X) > 2) return 4;
            else return X;
        }

        public string Ans()
        {
            double f = Formula();

            if (Math.Abs(Formula() - Y) < Math.Pow(10, -3)) return "Точка лежит на кривой";
            else return "Точка не лежит на кривой";
        }
    }
}
