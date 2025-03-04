using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task28
    {
        private double R1 {  get; }
        private double R2 { get; }
        private double R3 {  get; }

        public Task28(double r1, double r2, double r3)
        {
            R1 = r1;
            R2 = r2;
            R3 = r3;
        }

        public double Resistance()
        {
            return (R1 * R2 * R3) / (R1 * R2 + R1 * R3 + R2 * R3);
        }
    }
}
