using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task14
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Task14(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Formula()
        {
            if (Math.Abs(X) > 1) return Math.Pow(Math.Sin(Math.Pow(X, 3)), 2);
            else if (Math.Abs(X) <= 1) return Math.Sqrt(6 * Math.Asin(Math.Pow(X, 7)) + 4.5 * Math.Pow(X, 6) + 4 * Math.Pow(X, 2) + 2);
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
