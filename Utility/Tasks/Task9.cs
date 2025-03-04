using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task9
    {
        private double Rate { get; }
        private double Percent {  get; }

        public Task9(double rate, double percent)
        {
            Rate = rate;
            Percent = percent;
        }

        public string CostOfCall(double wd, double ws)
        {
            double WeekdaysCost = ws * Rate;
            double WeekendCost = WeekdaysCost - (wd * Rate * Percent);

            return $"Цена в будние дни: {WeekdaysCost}. Цена в выходные дни: {WeekendCost}\n";
        }
    }
}
