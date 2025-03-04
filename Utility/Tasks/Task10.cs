using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Utility.Tasks
{
    public class Task10
    {
        private int Number { get; }
        private string Text { get; }

        public Task10(int number, string text)
        {
            Number = number;
            Text = text;
        }

        public bool Machine(double nt, string no)
        {
            if (nt == Number) return true;
            else return false;
        }

        public string Print(double nt, string no)
        {
            if (Machine(nt, no)) return $"{Number}) {Text}, вариант {no}\n";
            else return "unluck";
        }
    }
}
