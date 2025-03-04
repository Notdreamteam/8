using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task13
    {
        public double X {  get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Task13(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double Exp()
        {
            double mid = (X + Y + Z) / 3;
            return mid;
        }
    }
}
