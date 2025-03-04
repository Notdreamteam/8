using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task30
    {
        private double R1 { get; }
        private double R2 { get; }
        private double R3 { get; }

        public Task30(double r1, double r2, double r3)
        {
            R1 = r1;
            R2 = r2;
            R3 = r3;
        }

        public string Resistance()
        {
            double R_seq = 12;
            double R_par = 3;

            if ((R1 == R_seq || R1 == R_par)) return $"Из {R1} может быть получено";
            else if ((R2 == R_seq || R2 == R_par)) return $"Из {R2} может быть получено";
            else if ((R3 == R_seq || R3 == R_par)) return $"Из {R3} может быть получено";
            else return "Нельзя получить";
        }
    }
}
